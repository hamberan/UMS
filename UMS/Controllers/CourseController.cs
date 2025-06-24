using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.Models;
using UMS.Repositories;

namespace UMS.Controllers
{
    internal class CourseController
    
{
        public static List<Course> GetAllCourses()
        {
            var courses = new List<Course>();
            using (var conn = DatabaseManager.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT Id, CourseName FROM Courses", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    courses.Add(new Course
                    {
                        CourseID = reader.GetInt32(0),
                        CourseName = reader.GetString(1)
                    });
                }
            }
            return courses;
        }

        
        public static void AddCourse(Course course)
        {
            using (var conn = DatabaseManager.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Courses (CourseName) VALUES (@CourseName)", conn);
                cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
                cmd.ExecuteNonQuery();
            }
        }

        
        public static void UpdateCourse(Course course)
        {
            using (var conn = DatabaseManager.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("UPDATE Courses SET CourseName = @CourseName WHERE Id = @CourseID", conn);
                cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
                cmd.Parameters.AddWithValue("@CourseID", course.CourseID);
                cmd.ExecuteNonQuery();
            }
        }

        
        public static void DeleteCourse(int courseId)
        {
            using (var conn = DatabaseManager.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Courses WHERE Id = @CourseID", conn);
                cmd.Parameters.AddWithValue("@CourseID", courseId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
