using System;
using System.Collections.Generic;
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

        public Folder(String fName)
        {
            Name        = fName;
            Folders     = new List<Folder>();
            Files       = new List<File>();
        }


        public static Process(String Name)
        {

        }

    }
}
