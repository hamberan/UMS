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

namespace UMS.Views
{
    public partial class AdminMainForm : Form
    {
    
        private readonly AdminController _admincontroller;

        public AdminMainForm()
        {
            InitializeComponent();
            _admincontroller = new AdminController();
        }


        private void btnStudents_Click(object sender, EventArgs e)
        {
            var form = new StudentForm();
            form.ShowDialog(); 
        }

           
        

        private void btnStaff_Click(object sender, EventArgs e)
        {
            _admincontroller.OpenStaffForm();

        }

        private void btnLecturers_Click(object sender, EventArgs e)
        {
            _admincontroller.OpenLecturerForm();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            //_admincontroller.OpenCourseForm();
            var form = new CourseSubjectForm();
            form.ShowDialog();

        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            _admincontroller.OpenSubjectForm();

        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            _admincontroller.OpenExamForm();

        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            _admincontroller.OpenMarkForm();

        }

        private void btnTimetables_Click(object sender, EventArgs e)
        {
            _admincontroller.OpenTimetableForm();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
