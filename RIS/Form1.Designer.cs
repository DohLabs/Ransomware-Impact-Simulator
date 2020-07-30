namespace RIS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Log_Success_check = new System.Windows.Forms.CheckBox();
            this.Log_Ignored_check = new System.Windows.Forms.CheckBox();
            this.Log_Other_check = new System.Windows.Forms.CheckBox();
            this.Log_AD_check = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Include_Files_list = new System.Windows.Forms.DataGridView();
            this.Ext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Include_All_Files_check = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Exclude_Files_list = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exclude_All_Files_check = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Remove_Location_btn = new System.Windows.Forms.Button();
            this.Add_Location_btn = new System.Windows.Forms.Button();
            this.Location_lst = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status_strip = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSimulationTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Include_Files_list)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exclude_Files_list)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Log_Success_check);
            this.groupBox1.Controls.Add(this.Log_Ignored_check);
            this.groupBox1.Controls.Add(this.Log_Other_check);
            this.groupBox1.Controls.Add(this.Log_AD_check);
            this.groupBox1.Location = new System.Drawing.Point(13, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log the following items:";
            // 
            // Log_Success_check
            // 
            this.Log_Success_check.Checked = true;
            this.Log_Success_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Log_Success_check.Location = new System.Drawing.Point(48, 46);
            this.Log_Success_check.Name = "Log_Success_check";
            this.Log_Success_check.Size = new System.Drawing.Size(132, 24);
            this.Log_Success_check.TabIndex = 2;
            this.Log_Success_check.Text = "Success";
            this.Log_Success_check.UseVisualStyleBackColor = true;
            // 
            // Log_Ignored_check
            // 
            this.Log_Ignored_check.Location = new System.Drawing.Point(48, 76);
            this.Log_Ignored_check.Name = "Log_Ignored_check";
            this.Log_Ignored_check.Size = new System.Drawing.Size(132, 24);
            this.Log_Ignored_check.TabIndex = 1;
            this.Log_Ignored_check.Text = "Ignored Files";
            this.Log_Ignored_check.UseVisualStyleBackColor = true;
            // 
            // Log_Other_check
            // 
            this.Log_Other_check.Location = new System.Drawing.Point(48, 136);
            this.Log_Other_check.Name = "Log_Other_check";
            this.Log_Other_check.Size = new System.Drawing.Size(132, 24);
            this.Log_Other_check.TabIndex = 1;
            this.Log_Other_check.Text = "Other Errors";
            this.Log_Other_check.UseVisualStyleBackColor = true;
            // 
            // Log_AD_check
            // 
            this.Log_AD_check.Location = new System.Drawing.Point(48, 106);
            this.Log_AD_check.Name = "Log_AD_check";
            this.Log_AD_check.Size = new System.Drawing.Size(132, 24);
            this.Log_AD_check.TabIndex = 0;
            this.Log_AD_check.Text = "Access Denied Errors";
            this.Log_AD_check.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Include_Files_list);
            this.groupBox2.Controls.Add(this.Include_All_Files_check);
            this.groupBox2.Location = new System.Drawing.Point(257, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Include file types";
            // 
            // Include_Files_list
            // 
            this.Include_Files_list.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Include_Files_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Include_Files_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ext,
            this.Desc});
            this.Include_Files_list.Location = new System.Drawing.Point(7, 44);
            this.Include_Files_list.Name = "Include_Files_list";
            this.Include_Files_list.RowHeadersVisible = false;
            this.Include_Files_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Include_Files_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Include_Files_list.Size = new System.Drawing.Size(224, 110);
            this.Include_Files_list.TabIndex = 1;
            // 
            // Ext
            // 
            this.Ext.HeaderText = "Extension";
            this.Ext.Name = "Ext";
            this.Ext.Width = 70;
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Description";
            this.Desc.Name = "Desc";
            this.Desc.Width = 150;
            // 
            // Include_All_Files_check
            // 
            this.Include_All_Files_check.AutoSize = true;
            this.Include_All_Files_check.Location = new System.Drawing.Point(7, 20);
            this.Include_All_Files_check.Name = "Include_All_Files_check";
            this.Include_All_Files_check.Size = new System.Drawing.Size(61, 17);
            this.Include_All_Files_check.TabIndex = 0;
            this.Include_All_Files_check.Text = "All Files";
            this.Include_All_Files_check.UseVisualStyleBackColor = true;
            this.Include_All_Files_check.CheckedChanged += new System.EventHandler(this.Include_All_Files_check_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Exclude_Files_list);
            this.groupBox3.Controls.Add(this.Exclude_All_Files_check);
            this.groupBox3.Location = new System.Drawing.Point(257, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 170);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exclude file types";
            // 
            // Exclude_Files_list
            // 
            this.Exclude_Files_list.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Exclude_Files_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Exclude_Files_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.Exclude_Files_list.Location = new System.Drawing.Point(7, 44);
            this.Exclude_Files_list.Name = "Exclude_Files_list";
            this.Exclude_Files_list.RowHeadersVisible = false;
            this.Exclude_Files_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Exclude_Files_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Exclude_Files_list.Size = new System.Drawing.Size(224, 110);
            this.Exclude_Files_list.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Extension";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // Exclude_All_Files_check
            // 
            this.Exclude_All_Files_check.AutoSize = true;
            this.Exclude_All_Files_check.Location = new System.Drawing.Point(7, 20);
            this.Exclude_All_Files_check.Name = "Exclude_All_Files_check";
            this.Exclude_All_Files_check.Size = new System.Drawing.Size(61, 17);
            this.Exclude_All_Files_check.TabIndex = 0;
            this.Exclude_All_Files_check.Text = "All Files";
            this.Exclude_All_Files_check.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Remove_Location_btn);
            this.groupBox4.Controls.Add(this.Add_Location_btn);
            this.groupBox4.Controls.Add(this.Location_lst);
            this.groupBox4.Location = new System.Drawing.Point(13, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 170);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Target location(s)";
            // 
            // Remove_Location_btn
            // 
            this.Remove_Location_btn.Location = new System.Drawing.Point(157, 26);
            this.Remove_Location_btn.Name = "Remove_Location_btn";
            this.Remove_Location_btn.Size = new System.Drawing.Size(75, 23);
            this.Remove_Location_btn.TabIndex = 2;
            this.Remove_Location_btn.Text = "Remove";
            this.Remove_Location_btn.UseVisualStyleBackColor = true;
            // 
            // Add_Location_btn
            // 
            this.Add_Location_btn.Location = new System.Drawing.Point(7, 26);
            this.Add_Location_btn.Name = "Add_Location_btn";
            this.Add_Location_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_Location_btn.TabIndex = 1;
            this.Add_Location_btn.Text = "Add";
            this.Add_Location_btn.UseVisualStyleBackColor = true;
            // 
            // Location_lst
            // 
            this.Location_lst.FormattingEnabled = true;
            this.Location_lst.Location = new System.Drawing.Point(7, 55);
            this.Location_lst.Name = "Location_lst";
            this.Location_lst.Size = new System.Drawing.Size(225, 82);
            this.Location_lst.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_strip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 393);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(506, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status_strip
            // 
            this.Status_strip.AutoSize = false;
            this.Status_strip.Name = "Status_strip";
            this.Status_strip.Size = new System.Drawing.Size(100, 17);
            this.Status_strip.Text = "Status:";
            this.Status_strip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(506, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSimulationTemplateToolStripMenuItem,
            this.openReportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openSimulationTemplateToolStripMenuItem
            // 
            this.openSimulationTemplateToolStripMenuItem.Name = "openSimulationTemplateToolStripMenuItem";
            this.openSimulationTemplateToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.openSimulationTemplateToolStripMenuItem.Text = "&Open Simulation Template";
            // 
            // openReportToolStripMenuItem
            // 
            this.openReportToolStripMenuItem.Name = "openReportToolStripMenuItem";
            this.openReportToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.openReportToolStripMenuItem.Text = "&Open Result Report";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginSimulationToolStripMenuItem,
            this.pauseSimulationToolStripMenuItem,
            this.stopSimulationToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "&Actions";
            // 
            // beginSimulationToolStripMenuItem
            // 
            this.beginSimulationToolStripMenuItem.Name = "beginSimulationToolStripMenuItem";
            this.beginSimulationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beginSimulationToolStripMenuItem.Text = "&Begin Simulation";
            // 
            // stopSimulationToolStripMenuItem
            // 
            this.stopSimulationToolStripMenuItem.Name = "stopSimulationToolStripMenuItem";
            this.stopSimulationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stopSimulationToolStripMenuItem.Text = "&Stop Simulation";
            this.stopSimulationToolStripMenuItem.Click += new System.EventHandler(this.stopSimulationToolStripMenuItem_Click);
            // 
            // pauseSimulationToolStripMenuItem
            // 
            this.pauseSimulationToolStripMenuItem.Name = "pauseSimulationToolStripMenuItem";
            this.pauseSimulationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pauseSimulationToolStripMenuItem.Text = "&Pause Simulation";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 415);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ransomware Impact Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Include_Files_list)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exclude_Files_list)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Include_Files_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ext;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.CheckBox Include_All_Files_check;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView Exclude_Files_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.CheckBox Exclude_All_Files_check;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox Location_lst;
        private System.Windows.Forms.Button Remove_Location_btn;
        private System.Windows.Forms.Button Add_Location_btn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status_strip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Log_Success_check;
        private System.Windows.Forms.CheckBox Log_Ignored_check;
        private System.Windows.Forms.CheckBox Log_Other_check;
        private System.Windows.Forms.CheckBox Log_AD_check;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSimulationTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginSimulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopSimulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseSimulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

