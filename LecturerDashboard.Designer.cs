using System.ComponentModel;

namespace Course_Managment_APP
{
    partial class LecturerDashboard
    {
        private System.ComponentModel.IContainer components = null;

        public LecturerDashboard(IContainer components)
        {
            this.components = components;
        }

        private System.Windows.Forms.Label lblWelcome;  
        private System.Windows.Forms.Button lLogBtn;
        private System.Windows.Forms.Button MngTaskBtn;
        private System.Windows.Forms.Button ViewStndsBtn;
        private System.Windows.Forms.Button MngCourseBtn;
        private System.Windows.Forms.Label label1;

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lLogBtn = new System.Windows.Forms.Button();
            this.MngTaskBtn = new System.Windows.Forms.Button();
            this.ViewStndsBtn = new System.Windows.Forms.Button();
            this.MngCourseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelLecture = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.SystemColors.Window;
            this.lblWelcome.Location = new System.Drawing.Point(20, 70);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 16);
            this.lblWelcome.TabIndex = 0;
            // 
            // lLogBtn
            // 
            this.lLogBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lLogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lLogBtn.ForeColor = System.Drawing.Color.White;
            this.lLogBtn.Location = new System.Drawing.Point(0, 295);
            this.lLogBtn.Name = "lLogBtn";
            this.lLogBtn.Size = new System.Drawing.Size(238, 64);
            this.lLogBtn.TabIndex = 10;
            this.lLogBtn.Text = "Log out";
            this.lLogBtn.UseVisualStyleBackColor = false;
            this.lLogBtn.Click += new System.EventHandler(this.lLogBtn_Click);
            // 
            // MngTaskBtn
            // 
            this.MngTaskBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.MngTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MngTaskBtn.ForeColor = System.Drawing.Color.White;
            this.MngTaskBtn.Location = new System.Drawing.Point(-8, 232);
            this.MngTaskBtn.Name = "MngTaskBtn";
            this.MngTaskBtn.Size = new System.Drawing.Size(246, 64);
            this.MngTaskBtn.TabIndex = 9;
            this.MngTaskBtn.Text = "Manage Tasks";
            this.MngTaskBtn.UseVisualStyleBackColor = false;
            this.MngTaskBtn.Click += new System.EventHandler(this.MngTaskBtn_Click);
            // 
            // ViewStndsBtn
            // 
            this.ViewStndsBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ViewStndsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewStndsBtn.ForeColor = System.Drawing.Color.White;
            this.ViewStndsBtn.Location = new System.Drawing.Point(-8, 110);
            this.ViewStndsBtn.Name = "ViewStndsBtn";
            this.ViewStndsBtn.Size = new System.Drawing.Size(246, 64);
            this.ViewStndsBtn.TabIndex = 8;
            this.ViewStndsBtn.Text = "View Students";
            this.ViewStndsBtn.UseVisualStyleBackColor = false;
            this.ViewStndsBtn.Click += new System.EventHandler(this.ViewStndsBtn_Click);
            // 
            // MngCourseBtn
            // 
            this.MngCourseBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.MngCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MngCourseBtn.ForeColor = System.Drawing.Color.White;
            this.MngCourseBtn.Location = new System.Drawing.Point(-8, 170);
            this.MngCourseBtn.Name = "MngCourseBtn";
            this.MngCourseBtn.Size = new System.Drawing.Size(246, 64);
            this.MngCourseBtn.TabIndex = 7;
            this.MngCourseBtn.Text = "Manage Courses";
            this.MngCourseBtn.UseVisualStyleBackColor = false;
            this.MngCourseBtn.Click += new System.EventHandler(this.MngCourseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Swis721 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 68);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lecturer\r\nDashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.ViewStndsBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lLogBtn);
            this.panel1.Controls.Add(this.MngCourseBtn);
            this.panel1.Controls.Add(this.MngTaskBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 540);
            this.panel1.TabIndex = 13;
            // 
            // PanelLecture
            // 
            this.PanelLecture.AutoScroll = true;
            this.PanelLecture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelLecture.Location = new System.Drawing.Point(238, 0);
            this.PanelLecture.Name = "PanelLecture";
            this.PanelLecture.Size = new System.Drawing.Size(663, 540);
            this.PanelLecture.TabIndex = 14;
            // 
            // LecturerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 540);
            this.Controls.Add(this.PanelLecture);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblWelcome);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "LecturerDashboard";
            this.Text = "LecturerDashboardForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelLecture;
    }
}
