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
        public static class StudentController
        {
        public static List<Student> GetAllStudents()
            {
                var students = new List<Student>();
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    var cmd = new SQLiteCommand("SELECT * FROM Students", conn);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            StudentID = reader.GetInt32(0),
                            StudentName = reader.GetString(1),
                            CourseID = reader.GetInt32(2)
                        });
                    }
                }
                return students;
            }

            public static void AddStudent(Student student)
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    var cmd = new SQLiteCommand("INSERT INTO Students (Name, CourseId) VALUES (@Name, @CourseId)", conn);
                    cmd.Parameters.AddWithValue("@Name", student.StudentName);
                    cmd.Parameters.AddWithValue("@CourseId", student.CourseID);
                    cmd.ExecuteNonQuery();
                }
            }

            public static void UpdateStudent(Student student)
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    var cmd = new SQLiteCommand("UPDATE Students SET Name = @Name, CourseId = @CourseId WHERE Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Name", student.StudentName);
                    cmd.Parameters.AddWithValue("@CourseId", student.CourseID);
                    cmd.Parameters.AddWithValue("@Id", student.CourseID);
                    cmd.ExecuteNonQuery();
                }
            }

            public static void DeleteStudent(int id)
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    var cmd = new SQLiteCommand("DELETE FROM Students WHERE Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
}












