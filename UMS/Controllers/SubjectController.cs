using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.Models;

namespace UMS.Controllers
{
    internal class SubjectController
    {
        public static List<Subject> GetAllSubjectsWithCourse()
        {
            // This method should return a list of all subjects with their associated courses from the database
            // For now, returning an empty list as a placeholder
            return new List<Subject>();
        }
        public static void UpdateSubject(Subject subject)
        {
            // This method should update the subject in the database
            // Implementation goes here
        }
        
        public static void AddSubject(Subject subject)
        {
            // This method should add a new subject to the database
            // Implementation goes here
        }

        public static void RemoveSubject(int Id) { }
    }
}
