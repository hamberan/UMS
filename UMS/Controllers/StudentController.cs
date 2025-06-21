using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.Models;

namespace UMS.Controllers
{
    internal class StudentController
    {
        public Task<List<Student>> GetAllAsync()
        {
            return Task.FromResult(new List<Student>());
        }
        public Task AddAsync(Student s)
        {
            return Task.CompletedTask;
        }
        public Task UpdateAsync(Student s) 
        {
            return Task.CompletedTask;
        }
        public Task DeleteAsync(int id)
        {
            return Task.CompletedTask;
        }
    }

}

