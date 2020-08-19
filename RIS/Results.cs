using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIS
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void Results_Load(object sender, EventArgs e)
        {

        }


        public void LoadResults(Folder ResultSet)
        {
            foreach(Folder F in ResultSet.Folders)
            {
                TreeNode N = new TreeNode(F.Name,2,2);
                ResultView.Nodes.Add(N);
                AddNode(N, F);
            }
        }

        //Add a folder to our structure
        private bool AddNode(TreeNode Parent, Folder ResultSet)
        {

            bool Result = false;

            foreach (Folder F in ResultSet.Folders)
            {
                TreeNode N = new TreeNode(F.Name,2,2);
                
                //Only add nodes that it was possible to write to (If option is enabled ??) 
                if(AddNode(N, F))
                    Parent.Nodes.Add(N);
                
            }




            foreach (File F in ResultSet.Files)
            {
                Int32 R = 0;

                switch (F.Result)
                {
                    case EncryptionResult.SUCCESS:
                        R = 0;
                        Result = true;
                        break;

                    case EncryptionResult.FAILURE_ACCESS_DENIED:
                        R = 1;
                        break;

                    case EncryptionResult.FAILURE_OTHER:
                        R = 1;
                        break;

                    case EncryptionResult.NOT_PROCESSED:
                        R = 1;
                        break;

                    default:
                        R = 0;
                        break;

                }
            
                TreeNode N = new TreeNode(F.Name,R,R);
                Parent.Nodes.Add(N);
                N.ToolTipText = F.Result.ToString();
            }

        return (Result);
        }



    }
}
