using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace RIS
{
    public partial class Form1 : Form
    {

        Thread SystemThread = null;
        Stopwatch Running_Timer;

        public Form1()
        {
            InitializeComponent();
            Running_Timer = new Stopwatch();
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
            Manager.SetRunning(false);
        }

        private void beginSimulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemThread = new Thread(Manager.Process);
            
            

            Status_Queue_lbl.Text = "Queue size: 0";
            Status_Info_lbl.Text = "Status: Running";
            Running_Timer.Reset();
            Running_Timer.Start();


            List<String> E = new List<string>();
            foreach (DataGridViewRow item in Include_Files_list.Rows)
            {
                if(item.Cells[0].Value !=null)
                    E.Add(item.Cells[0].Value.ToString());
            }
            Manager.SetExtensions(E.ToArray());


            SystemThread.Start("H:\\");
            Manager.SetRunning(true);




            while (Manager.GetRunning())
            {
                Application.DoEvents();
                String RunningTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",Running_Timer.Elapsed.Hours, Running_Timer.Elapsed.Minutes, Running_Timer.Elapsed.Seconds, Running_Timer.Elapsed.Milliseconds/10);
                Status_Running_Time_lbl.Text = RunningTime;
                Thread.Sleep(10);

                //Show our Queue Size
                Status_Queue_lbl.Text = "Queue size: " + Manager.GetQueueSize();
            }


            Running_Timer.Stop();
            Status_Info_lbl.Text = "Status: Stopped";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 B = new AboutBox1();
            B.Show();
        }
    }
}
