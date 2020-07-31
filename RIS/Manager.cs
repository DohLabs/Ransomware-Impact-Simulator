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
        private static Int32            MAX_TASKS_PER_THREAD;


        static Manager()
        {
            Running = false;
            Tasks = new List<File>();
            Lock = new Semaphore(0, 1);
            MAX_TASKS_PER_THREAD = 5;
        }

        private static void AddTask(ref File F)
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
            Lock.Release();
            return (FL);
        }


        public static Folder Process(String Location)
        {
            Folder F = new Folder(Location);
            
        }
        


    }
}
