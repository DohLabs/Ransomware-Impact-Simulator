using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS
{
    public class Folder
    {
        private String          Name;
        private List<Folder>    Folders;
        private List<File>      Files;

        public Folder(String fName, String Location)
        {
            Name        = fName;
            Folders     = new List<Folder>();
            Files       = new List<File>();

            String TargetName = fName;

            if (!Manager.GetRunning())
                return;

            if (Directory.Exists(fName))
            {

                //Add any files to our TaskList
                try
                {
                    String[] sFiles = Directory.GetFiles(fName);
                    foreach (String S in sFiles)
                    {
                        File F = new File(S, fName);
                        Files.Add(F);
                        Manager.AddTask(ref F);
                    }
                }
                catch (Exception E)
                {

                }

                try
                {
                    String[] sFolders = Directory.GetDirectories(TargetName);
                    foreach (String S in sFolders)
                    {
                        Folder F = new Folder(S, fName);
                        Folders.Add(F);
                    }
                }
                catch (Exception E)
                {
                }

            }

        }
    }
}
