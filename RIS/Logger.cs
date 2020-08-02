using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RIS
{
    public static class Logger
    {
        static String Filename  = "";
        static Semaphore Lock   = null;
        private static List<String> WorkQueue;
        static Thread LogThread = null;
        static Int32 MAX_LOGS   = 100;

        static Logger()
        {
            Filename = "Log.txt";
            Lock = new Semaphore(1, 1);
            WorkQueue = new List<string>();

            LogThread = new Thread(Process);
            LogThread.Start();

        }


        public static void Write(String S)
        {
            DateTime now = DateTime.Now;
            String LogDateTime = String.Format("{0}:{1}:{2} {3}/{4}/{5}", now.Hour, now.Minute, now.Second, now.Day, now.Month, now.Year);

            Lock.WaitOne();
                WorkQueue.Add(LogDateTime + ": " + S);
            Lock.Release();
        }
        
        public static void Write(Exception E)
        {
            Write(E.Message.ToString());
        }


        static void Process()
        {
            List<String> Tasks;
            Int32 TaskLength    =0;

            while (true)
            {
                Lock.WaitOne();
                if (WorkQueue.Count() > MAX_LOGS)
                    TaskLength = MAX_LOGS;
                else
                    TaskLength = WorkQueue.Count();

                Tasks = WorkQueue.GetRange(0, TaskLength);
                WorkQueue.RemoveRange(0, TaskLength);
                Lock.Release();

                if (Tasks.Count() > 0)
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(Filename,true))
                    {
                        foreach (String S in Tasks)
                        {
                            file.WriteLine(S);
                        }
                    }
                        
                }

            Thread.Sleep(10);
            }

        }
    }
}
