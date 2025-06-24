using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMS.Controllers;
using UMS.Models;

namespace UMS.Views
{
    public partial class StudentMainForm : Form
    {
        public StudentMainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentController.AddStudent(new Student
            {
                StudentName = txtStudentName.Text.Trim(),
                CourseID = Convert.ToInt32(cmbSelectCourse.SelectedValue)
            });
            LoadStudents();
            MessageBox.Show("Student added.");
        }

        private void LoadCourses()
        {
            var courses = CourseController.GetAllCourses();
            cmbSelectCourse.DataSource = courses;
            cmbSelectCourse.DisplayMember = "CourseName";
            cmbSelectCourse.ValueMember = "CourseID";
        }
        private void LoadStudents()
        {
            dgvStudents.DataSource = StudentController.GetAllStudents();
        }

    }
}
