using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS
{
    public class File
    {
        public String ParentFolder;
        public String Name;
        public EncryptionResult Result;


        public File()
        {
            Name = "";
            Result = EncryptionResult.NOT_PROCESSED;
            ParentFolder = "";
        }

    }
}
