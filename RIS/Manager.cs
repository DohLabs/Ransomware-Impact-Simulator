using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RIS
{
    public static class Manager
    {

        private static bool             Running;
        private static List<File>       Tasks;
        private static Semaphore        Lock;
        private static Semaphore        Status_Lock;
        private static Int32            MAX_TASKS_PER_THREAD;
        private static Int32            MAX_THREADS;
        private static String[]         Extensions;
        private static Folder           Scan_Results;


        static Manager()
        {
            Running         = false;
            Tasks           = new List<File>();
            Lock            = new Semaphore(1, 1);
            Status_Lock     = new Semaphore(1, 1);
            MAX_TASKS_PER_THREAD = 20;
            MAX_THREADS          = 2;

            //Worker Thread creation
            for (int i = 0; i < MAX_THREADS; i++)
            {
                Thread t = new Thread(Worker.Run);
                t.Start();
            }
        }

        public static void SetExtensions(String[] Exts)
        {
            Lock.WaitOne();
                Extensions = Exts;
            Lock.Release();
        }

        public static void AddTask(ref File F)
        {
            Lock.WaitOne();
                Tasks.Add(F);
            Lock.Release();
        }


        public static List<File> GetTask()
        {
            Int32 TaskCount = 0;
            List<File> FL = null;

            Lock.WaitOne();
                if (Tasks.Count() < MAX_TASKS_PER_THREAD)
                    TaskCount = Tasks.Count();
                else
                    TaskCount = MAX_TASKS_PER_THREAD;

                FL = Tasks.GetRange(0, TaskCount);
                Tasks.RemoveRange(0, TaskCount);    

            Lock.Release();
            return (FL);
        }


        public static void Process(Object Destinations)
        {
            String[] DestinationName = (String[])Destinations;

            SetRunning(true);

            Scan_Results = new Folder("",null);

            //Perform a loop for all destinations to scan
            foreach (String Name in DestinationName)
            {
                Logger.Write("Starting scan process for " + Name);
                Folder F = new Folder((String)Name, Extensions);

                while (Manager.GetQueueSize() > 0)
                {
                    Thread.Sleep(10);
                }
                Logger.Write("Scan process for " + Name + " Complete");

                Scan_Results.MergeResult(F);
            }

        SetRunning(false);
        }


        public static Folder GetResult()
        {
            return (Scan_Results);
        }



        public static void SetRunning(bool R)
        {
            Status_Lock.WaitOne();
                Running = R;
            Status_Lock.Release();
        }


        public static bool GetRunning()
        {
            bool Result;
            Status_Lock.WaitOne();
                Result = Running;
            Status_Lock.Release();

        return (Result);
        }


        public static Int32 GetQueueSize()
        {
            Int32 Queue_Size = 0;
            Lock.WaitOne();
                Queue_Size = Tasks.Count();
            Lock.Release();
        return (Queue_Size);
        }
        



    }
}
