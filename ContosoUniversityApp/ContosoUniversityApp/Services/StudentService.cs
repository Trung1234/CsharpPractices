using ContosoUniversityApp.Data;
using ContosoUniversityApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversityApp.Services
{
    public class StudentService : IStudentService
    {
        private readonly SchoolContext _db;
        private IQueryable<Student> students;

        public StudentService(SchoolContext db)
        {
            _db = db;
            this.students = _db.Students.AsNoTracking();
        }

        public int NumberPage(int totalstudent, int limit)
        {
            float numberpage = totalstudent / limit;
            return (int)Math.Ceiling(numberpage);
        }

        public void FilterList(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.LastName.Contains(searchString)
                                       || s.FirstMidName.Contains(searchString));
            }
        }
        public async Task<IEnumerable<Student>> PaginationStudent(int start, int limit)
        {
            //var data = (from s in _db.Students select s);
            return await students.Skip(start).Take(limit).ToListAsync();
        }

        public int TotalStudent()
        {
            return students.ToList().Count;
        }

    }
}
