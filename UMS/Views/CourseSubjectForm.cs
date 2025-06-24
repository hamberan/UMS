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
    public partial class CourseSubjectForm : Form
    {
        public CourseSubjectForm()
        {
            InitializeComponent();
            LoadCourses();
        }
        private void LoadCourses()
        {
            var courses = CourseController.GetAllCourses();
            dgvSubjects.AutoGenerateColumns = true;
            dgvSubjects.DataSource = null;
            dgvSubjects.DataSource = courses;

            if (dgvSubjects.Columns["CourseID"] != null)
            {
                dgvSubjects.Columns["CourseID"].HeaderText = "Course ID"; // Hide CourseID column if it exists
            }
            if (dgvSubjects.Columns["CourseName"] != null)
            {
                dgvSubjects.Columns["CourseName"].HeaderText = "Course Name"; // Hide CourseID column if it exists
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

            if (dgvSubjects.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvSubjects.CurrentRow.Cells[0].Value);
                SubjectController.UpdateSubject(new Subject
                {
                    SubjectID = id,
                    SubjectName = txtCourseName.Text.Trim(),
                    CourseID = Convert.ToInt32(txtCourseName.Text.Trim())
                });
                MessageBox.Show("Subject updated.");
            }
        }

        private void CourseSubjectForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            {
                CourseController.AddCourse(new Course
                {
                    CourseName = txtCourseName.Text.Trim()
                });
                LoadCourses();
                MessageBox.Show("Course added.");
                txtCourseName.Clear();
            }
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            SubjectController.AddSubject(new Subject
            {
                SubjectName = txtCourseName.Text.Trim(),
                //CourseID = Convert.ToInt32(cmbCourseForSubject.SelectedValue)
            });
            //LoadSubjects();
            MessageBox.Show("Subject added.");
            txtCourseName.Clear();
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvSubjects.CurrentRow.Cells[0].Value);
                SubjectController.RemoveSubject(id);
                //LoadSubjects();
                MessageBox.Show("Subject deleted.");
            }
        }

        private void dgvSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSubjects.Rows[e.RowIndex];
                txtCourseName.Text = dgvSubjects.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}