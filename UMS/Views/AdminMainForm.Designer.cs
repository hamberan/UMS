namespace UMS.Views
{
    partial class AdminMainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnLecturers = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.btnExams = new System.Windows.Forms.Button();
            this.btnMarks = new System.Windows.Forms.Button();
            this.btnTimetables = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!! \"ADMIN";
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(120, 87);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(150, 23);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "Manage Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(120, 137);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(150, 23);
            this.btnStaff.TabIndex = 2;
            this.btnStaff.Text = "Manage Staffs";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnLecturers
            // 
            this.btnLecturers.Location = new System.Drawing.Point(141, 195);
            this.btnLecturers.Name = "btnLecturers";
            this.btnLecturers.Size = new System.Drawing.Size(129, 23);
            this.btnLecturers.TabIndex = 3;
            this.btnLecturers.Text = "Manage Lecturers";
            this.btnLecturers.UseVisualStyleBackColor = true;
            this.btnLecturers.Click += new System.EventHandler(this.btnLecturers_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Location = new System.Drawing.Point(160, 249);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(123, 23);
            this.btnCourses.TabIndex = 4;
            this.btnCourses.Text = "Manage Courses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.Location = new System.Drawing.Point(372, 99);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(128, 23);
            this.btnSubjects.TabIndex = 5;
            this.btnSubjects.Text = "Manage Subjects";
            this.btnSubjects.UseVisualStyleBackColor = true;
            this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
            // 
            // btnExams
            // 
            this.btnExams.Location = new System.Drawing.Point(372, 147);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(128, 23);
            this.btnExams.TabIndex = 6;
            this.btnExams.Text = "Manage Exans";
            this.btnExams.UseVisualStyleBackColor = true;
            this.btnExams.Click += new System.EventHandler(this.btnExams_Click);
            // 
            // btnMarks
            // 
            this.btnMarks.Location = new System.Drawing.Point(372, 195);
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Size = new System.Drawing.Size(128, 23);
            this.btnMarks.TabIndex = 7;
            this.btnMarks.Text = "Manage Marks";
            this.btnMarks.UseVisualStyleBackColor = true;
            this.btnMarks.Click += new System.EventHandler(this.btnMarks_Click);
            // 
            // btnTimetables
            // 
            this.btnTimetables.Location = new System.Drawing.Point(372, 249);
            this.btnTimetables.Name = "btnTimetables";
            this.btnTimetables.Size = new System.Drawing.Size(139, 23);
            this.btnTimetables.TabIndex = 8;
            this.btnTimetables.Text = "Manage Timetables";
            this.btnTimetables.UseVisualStyleBackColor = true;
            this.btnTimetables.Click += new System.EventHandler(this.btnTimetables_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(340, 303);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(121, 23);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "L0GOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnTimetables);
            this.Controls.Add(this.btnMarks);
            this.Controls.Add(this.btnExams);
            this.Controls.Add(this.btnSubjects);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnLecturers);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.label1);
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnLecturers;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button btnExams;
        private System.Windows.Forms.Button btnMarks;
        private System.Windows.Forms.Button btnTimetables;
        private System.Windows.Forms.Button btnLogout;
    }
}