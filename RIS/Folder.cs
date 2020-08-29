using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace RIS
{
    [Serializable]
    public class Folder
    {
        public String Name;
        public List<Folder> Folders;
        public List<File> Files;

        public Folder(String fName, String[] Patterns)
        {
            Name = fName;
            Folders = new List<Folder>();
            Files = new List<File>();

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
                        Folder F = new Folder(S, Patterns);
                        Folders.Add(F);
                    }
                }
                catch (Exception E)
                {
                    Logger.Write(E);
                }

            }

        }

        public bool MergeResult(Folder F)
        {
            Folders.Add(F);
            return (true);
        }


        public static bool WriteResult(String Filename, Folder F)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream S = new FileStream(Filename, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(S, F);
            S.Close();

            return (true);
        }


        public static Folder LoadResult(String Filename)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream S = new FileStream(Filename, FileMode.Open, FileAccess.Read, FileShare.Read);
            Folder F = (Folder) formatter.Deserialize(S);
            S.Close();
            return (F);
        }

    }
}
