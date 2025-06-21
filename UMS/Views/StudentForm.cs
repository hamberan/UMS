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
    public partial class StudentForm : Form
    {
        private readonly StudentController _controller;
        private int selectedId = -1;


        public StudentForm()
        {
            
            InitializeComponent();
            LoadStudents();
        }

        private async void LoadStudents()
        {
            dgvStudents.DataSource = await _controller.GetAllAsync();
        }







        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                StudentName = txtName.Text,
                CourseID = int.Parse(txtCourseId.Text)
            };

             _controller.AddAsync(student);
            LoadStudents();
            ClearFields();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            var student = new Student
            {
                StudentID = selectedId,
                StudentName = txtName.Text,
                CourseID = int.Parse(txtCourseId.Text)

            };
             _controller.UpdateAsync(student);
            LoadStudents();
            ClearFields();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

             _controller.DeleteAsync(selectedId);
            LoadStudents();
            ClearFields();

        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvStudents.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtCourseId.Text = row.Cells["CourseId"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtCourseId.Clear();
            selectedId = -1;


        }
    }
}
