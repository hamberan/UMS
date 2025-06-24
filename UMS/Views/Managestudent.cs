using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UMS.Controllers;
using UMS.Models;
using UMS.Repositories;

namespace UMS.Views
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            LoadCourses();
            LoadStudents();
        }
        private void LoadCourses()
        {
            using (var conn = DatabaseManager.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT Id, CourseName FROM Courses", conn);
                var reader = cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(reader);

                cmbCourse.DataSource = dt;
                cmbCourse.DisplayMember = "CourseName";
                cmbCourse.ValueMember = "Id";
            }
        }

        private void LoadStudents()
        {
            dgvStudents.DataSource = StudentController.GetAllStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                StudentName = txtName.Text,
                CourseID = Convert.ToInt32(cmbCourse.SelectedValue)
            };
            StudentController.AddStudent(student);
            LoadStudents();
            MessageBox.Show("Student added.");
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null)
            {
                txtName.Text = dgvStudents.CurrentRow.Cells["Name"].Value.ToString();
                cmbCourse.SelectedValue = Convert.ToInt32(dgvStudents.CurrentRow.Cells["CourseId"].Value);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null)
            {
                var student = new Student
                {
                    StudentID = Convert.ToInt32(dgvStudents.CurrentRow.Cells["Id"].Value),
                    StudentName = txtName.Text,
                    CourseID = Convert.ToInt32(cmbCourse.SelectedValue)
                };
                StudentController.UpdateStudent(student);
                LoadStudents();
                MessageBox.Show("Student updated.");
            }
        }
        private void txtName_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            StudentController.AddStudent(new Student
            {
                StudentName = txtName.Text.Trim(),
                CourseID = Convert.ToInt32(cmbCourse.SelectedValue)
            });
            LoadStudents();
            MessageBox.Show("Student added.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvStudents.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvStudents.CurrentRow.Cells["Id"].Value);
                StudentController.DeleteStudent(id);
                LoadStudents();
                MessageBox.Show("Student deleted.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvStudents.CurrentRow != null)
            {

                if (dgvStudents.CurrentRow != null)
                {
                    txtName.Text = dgvStudents.CurrentRow.Cells["Name"].Value.ToString();
                    cmbCourse.SelectedValue = Convert.ToInt32(dgvStudents.CurrentRow.Cells["CourseId"].Value);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
