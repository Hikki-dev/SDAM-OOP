namespace Course_Managment_APP
{
    partial class StudentDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;  
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewCrsBtn;
        private System.Windows.Forms.Button EnrolledBtn;
        private System.Windows.Forms.Button GradesBtn;
        private System.Windows.Forms.Button sLogBtn;

        // Required method for Designer support
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewCrsBtn = new System.Windows.Forms.Button();
            this.EnrolledBtn = new System.Windows.Forms.Button();
            this.GradesBtn = new System.Windows.Forms.Button();
            this.sLogBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelStudent = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.PanelStudent.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblWelcome.Font = new System.Drawing.Font("Swis721 BT", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(6, 3);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(119, 29);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Swis721 BT", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student \r\nDashboard";
            // 
            // ViewCrsBtn
            // 
            this.ViewCrsBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ViewCrsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewCrsBtn.ForeColor = System.Drawing.Color.White;
            this.ViewCrsBtn.Location = new System.Drawing.Point(0, 117);
            this.ViewCrsBtn.Name = "ViewCrsBtn";
            this.ViewCrsBtn.Size = new System.Drawing.Size(200, 52);
            this.ViewCrsBtn.TabIndex = 2;
            this.ViewCrsBtn.Text = "View Courses";
            this.ViewCrsBtn.UseVisualStyleBackColor = false;
            this.ViewCrsBtn.Click += new System.EventHandler(this.ViewCrsBtn_Click);
            // 
            // EnrolledBtn
            // 
            this.EnrolledBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.EnrolledBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnrolledBtn.ForeColor = System.Drawing.Color.White;
            this.EnrolledBtn.Location = new System.Drawing.Point(0, 168);
            this.EnrolledBtn.Name = "EnrolledBtn";
            this.EnrolledBtn.Size = new System.Drawing.Size(200, 52);
            this.EnrolledBtn.TabIndex = 3;
            this.EnrolledBtn.Text = "Enrolled Courses";
            this.EnrolledBtn.UseVisualStyleBackColor = false;
            this.EnrolledBtn.Click += new System.EventHandler(this.EnrolledBtn_Click);
            // 
            // GradesBtn
            // 
            this.GradesBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.GradesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GradesBtn.ForeColor = System.Drawing.Color.White;
            this.GradesBtn.Location = new System.Drawing.Point(0, 219);
            this.GradesBtn.Name = "GradesBtn";
            this.GradesBtn.Size = new System.Drawing.Size(200, 52);
            this.GradesBtn.TabIndex = 4;
            this.GradesBtn.Text = "View Grades";
            this.GradesBtn.UseVisualStyleBackColor = false;
            this.GradesBtn.Click += new System.EventHandler(this.GradesBtn_Click);
            // 
            // sLogBtn
            // 
            this.sLogBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.sLogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sLogBtn.ForeColor = System.Drawing.Color.White;
            this.sLogBtn.Location = new System.Drawing.Point(0, 267);
            this.sLogBtn.Name = "sLogBtn";
            this.sLogBtn.Size = new System.Drawing.Size(200, 52);
            this.sLogBtn.TabIndex = 5;
            this.sLogBtn.Text = "Log out";
            this.sLogBtn.UseVisualStyleBackColor = false;
            this.sLogBtn.Click += new System.EventHandler(this.sLogBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.sLogBtn);
            this.panel1.Controls.Add(this.EnrolledBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.GradesBtn);
            this.panel1.Controls.Add(this.ViewCrsBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 6;
            // 
            // PanelStudent
            // 
            this.PanelStudent.Controls.Add(this.panel2);
            this.PanelStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelStudent.Location = new System.Drawing.Point(200, 0);
            this.PanelStudent.Name = "PanelStudent";
            this.PanelStudent.Size = new System.Drawing.Size(600, 450);
            this.PanelStudent.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.lblWelcome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 41);
            this.panel2.TabIndex = 0;
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelStudent);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelStudent.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelStudent;
        private System.Windows.Forms.Panel panel2;
    }
}
