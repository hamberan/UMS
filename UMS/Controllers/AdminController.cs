using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.Controllers
{
   
    
        public class AdminController
        {
            public void OpenStudentForm()
            {
                new Views.StudentForm().Show();
            }

            public void OpenStaffForm()
            {
                new Views.StaffForm().Show();
            }

            public void OpenLecturerForm()
            {
                new Views.LecturerForm().Show();
            }

            public void OpenCourseForm()
            {
                new Views.CourseSubjectForm().Show();
            }

            public void OpenSubjectForm()
            {
                new Views.SubjectForm().Show();
            }

            public void OpenExamForm()
            {
                new Views.ExamForm().Show();
            }

            public void OpenMarkForm()
            {
                new Views.MarkForm().Show();
            }

            public void OpenTimetableForm()
            {
                new Views.TimetableForm().Show();
            }
        }
    }


