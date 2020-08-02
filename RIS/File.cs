using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS
{
    public class File
    {
        public String Name;
        public String Location;
        public EncryptionResult Result;
        public long Size;


        public File(String sName, String sLocation)
        {
            Name        = sName;
            Location    = sLocation;
            Size        = 0;
            Result      = EncryptionResult.NOT_PROCESSED;
        }


        public static void Process(ref File F)
        {
            

            try
            {
                FileStream fs = System.IO.File.Open(F.Name, FileMode.Open, FileAccess.Write);
                if (fs.CanWrite)
                {
                    F.Result = EncryptionResult.SUCCESS;
                    F.Size = new System.IO.FileInfo(F.Name).Length;
                    Logger.Write("(SUCCESS) " + F.Name);
                }
                fs.Close();
            }
            catch (Exception E)
            {
                F.Result = EncryptionResult.FAILURE_OTHER;
                Logger.Write("(FAILED) " + F.Name);
                Logger.Write(E);
            }
        }

    }
}
