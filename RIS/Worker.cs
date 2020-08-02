using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RIS
{
    public class Worker
    {
        private bool        Running;
        private Semaphore   Lock;


        public Worker()
        {
            Running = false;
            Lock = new Semaphore(0, 1);
        }

        //Our threads main process
        public static void Run()
        {
            List<File> Files_to_Process = null;

            while (Manager.GetRunning() || (Manager.GetQueueSize()>0))
            {
                    Files_to_Process = Manager.GetTask();
                    if (Files_to_Process.Count() > 0)
                        Process(Files_to_Process);
                    else
                        Thread.Sleep(1);
            }

        //Delete our thread ?
        }


        //if we have files to process then get on with it
        public static void Process(List<File> Files)
        {
            //Lets check what access 
            //Lets check if we can delete the file

            for (int i=0;i<Files.Count();i++)
            {
                File F = Files[i];
                File.Process(ref F);
            }

            Console.WriteLine(" Got: " + Files.Count() + " files");
        }



    }
}
