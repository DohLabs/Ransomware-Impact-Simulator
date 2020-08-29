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


        //Holds our current data structure
        //This allows us to re-build if we change any viewing options
        private Folder Current_Data = null;

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

            Current_Data = ResultSet;

            ResultView.Nodes.Clear();

            foreach(Folder F in Current_Data.Folders)
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
            bool ContainsEncrypted = false;

            foreach (Folder F in ResultSet.Folders)
            {
                TreeNode N = new TreeNode(F.Name,2,2);

                //Only add nodes that it was possible to write to (If option is enabled ??) 
                ContainsEncrypted = AddNode(N, F);

                if (ContainsEncrypted)
                {
                    Parent.Nodes.Add(N);
                }
                else if (Show_Protected_Menu.Checked && !ContainsEncrypted)
                {
                    Parent.Nodes.Add(N);
                }
                else
                {
                    //What else is there ?
                }
                    
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

        private void Show_Encrypted_Menu_CheckStateChanged(object sender, EventArgs e)
        {
            LoadResults(Current_Data);
        }

        private void Show_Protected_Menu_CheckedChanged(object sender, EventArgs e)
        {
            LoadResults(Current_Data);
        }

        private void Show_Encrypted_Menu_CheckedChanged(object sender, EventArgs e)
        {
            LoadResults(Current_Data);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Current_Data != null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Save our output
                    Folder.WriteResult(saveFileDialog1.FileName, Current_Data);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               //Load our sample data
            Current_Data = Folder.LoadResult(openFileDialog1.FileName);
            LoadResults(Current_Data);

            }
        }
    }
}
