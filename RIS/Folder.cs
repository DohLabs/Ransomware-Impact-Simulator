using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace RIS
{
    public class Folder
    {
        private String          Name;
        private List<Folder>    Folders;
        private List<File>      Files;

        public Folder(String fName, String[] Patterns)
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
                    //var sFiles = Directory.GetFiles(fName).Where(file => allowedExtensions.Any(file.ToLower().EndsWith))
                    var files = Directory.GetFiles(fName).Where(file => Patterns.Contains(Path.GetExtension(file).ToLower()));
                    foreach (String S in files)
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
                        Folder F = new Folder(S,Patterns);
                        Folders.Add(F);
                    }
                }
                catch (Exception E)
                {
                    Logger.Write(E);
                }

            }

        }
    }
}
