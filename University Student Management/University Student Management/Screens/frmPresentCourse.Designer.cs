﻿namespace University_Student_Management.Screens
{
    partial class frmPresentCourse
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
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewPresent = new System.Windows.Forms.DataGridView();
            this.Course_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intake_Sec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Out_of_30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresent)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = global::University_Student_Management.Properties.Resources.b5ca34c1b0d5917f1475e85510f16d74;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(45, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(685, 98);
            this.label8.TabIndex = 107;
            this.label8.Text = "Current Semester Course";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.summaryToolStripMenuItem,
            this.presentCourseToolStripMenuItem,
            this.previousCourseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1900, 31);
            this.menuStrip1.TabIndex = 110;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(72, 27);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click_1);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.summaryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(102, 27);
            this.summaryToolStripMenuItem.Text = "Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click_1);
            // 
            // presentCourseToolStripMenuItem
            // 
            this.presentCourseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.presentCourseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentCourseToolStripMenuItem.Name = "presentCourseToolStripMenuItem";
            this.presentCourseToolStripMenuItem.Size = new System.Drawing.Size(86, 27);
            this.presentCourseToolStripMenuItem.Text = "Routine";
            this.presentCourseToolStripMenuItem.Click += new System.EventHandler(this.presentCourseToolStripMenuItem_Click);
            // 
            // previousCourseToolStripMenuItem
            // 
            this.previousCourseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.previousCourseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousCourseToolStripMenuItem.Name = "previousCourseToolStripMenuItem";
            this.previousCourseToolStripMenuItem.Size = new System.Drawing.Size(150, 27);
            this.previousCourseToolStripMenuItem.Text = "Previous Course";
            this.previousCourseToolStripMenuItem.Click += new System.EventHandler(this.previousCourseToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.dataGridViewPresent);
            this.panel1.Location = new System.Drawing.Point(20, 493);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1868, 436);
            this.panel1.TabIndex = 111;
            // 
            // dataGridViewPresent
            // 
            this.dataGridViewPresent.AllowUserToAddRows = false;
            this.dataGridViewPresent.AllowUserToDeleteRows = false;
            this.dataGridViewPresent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPresent.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPresent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPresent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course_Code,
            this.Course_Title,
            this.Credit,
            this.Intake_Sec,
            this.Mid,
            this.Final,
            this.Out_of_30});
            this.dataGridViewPresent.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewPresent.GridColor = System.Drawing.Color.Green;
            this.dataGridViewPresent.Location = new System.Drawing.Point(59, 56);
            this.dataGridViewPresent.Name = "dataGridViewPresent";
            this.dataGridViewPresent.ReadOnly = true;
            this.dataGridViewPresent.RowHeadersWidth = 51;
            this.dataGridViewPresent.RowTemplate.Height = 24;
            this.dataGridViewPresent.Size = new System.Drawing.Size(1750, 327);
            this.dataGridViewPresent.TabIndex = 9;
            // 
            // Course_Code
            // 
            this.Course_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Course_Code.DataPropertyName = "Course_Code";
            this.Course_Code.FillWeight = 110F;
            this.Course_Code.HeaderText = "Course Code";
            this.Course_Code.MinimumWidth = 6;
            this.Course_Code.Name = "Course_Code";
            this.Course_Code.ReadOnly = true;
            // 
            // Course_Title
            // 
            this.Course_Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Course_Title.DataPropertyName = "Course_Title";
            this.Course_Title.FillWeight = 120F;
            this.Course_Title.HeaderText = "Course Title";
            this.Course_Title.MinimumWidth = 6;
            this.Course_Title.Name = "Course_Title";
            this.Course_Title.ReadOnly = true;
            // 
            // Credit
            // 
            this.Credit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Credit.DataPropertyName = "Credit";
            this.Credit.HeaderText = "Credit";
            this.Credit.MinimumWidth = 6;
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            // 
            // Intake_Sec
            // 
            this.Intake_Sec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Intake_Sec.DataPropertyName = "Intake_Sec";
            this.Intake_Sec.HeaderText = "Intake-Sec";
            this.Intake_Sec.MinimumWidth = 6;
            this.Intake_Sec.Name = "Intake_Sec";
            this.Intake_Sec.ReadOnly = true;
            // 
            // Mid
            // 
            this.Mid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mid.DataPropertyName = "Mid";
            this.Mid.HeaderText = "Mid";
            this.Mid.MinimumWidth = 6;
            this.Mid.Name = "Mid";
            this.Mid.ReadOnly = true;
            // 
            // Final
            // 
            this.Final.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Final.DataPropertyName = "Final";
            this.Final.HeaderText = "Final";
            this.Final.MinimumWidth = 6;
            this.Final.Name = "Final";
            this.Final.ReadOnly = true;
            // 
            // Out_of_30
            // 
            this.Out_of_30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Out_of_30.DataPropertyName = "Out_of_30";
            this.Out_of_30.HeaderText = "Out of 30";
            this.Out_of_30.MinimumWidth = 6;
            this.Out_of_30.Name = "Out_of_30";
            this.Out_of_30.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(503, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 165);
            this.panel2.TabIndex = 112;
            // 
            // frmPresentCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 981);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "frmPresentCourse";
            this.Text = "Present Course Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PresentCourse_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresent)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presentCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousCourseToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewPresent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intake_Sec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Final;
        private System.Windows.Forms.DataGridViewTextBoxColumn Out_of_30;
    }
}