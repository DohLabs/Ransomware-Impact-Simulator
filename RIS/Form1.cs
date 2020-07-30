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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Include_All_Files_check_CheckedChanged(object sender, EventArgs e)
        {
            if(Include_All_Files_check.Checked)
            {
                Include_Files_list.Enabled = false;
               
            }
            else
            {
                Include_Files_list.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stopSimulationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
