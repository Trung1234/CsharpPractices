using ContosoUniversityApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversityApp.Services
{
    public interface IStudentService
    {
        void FilterList(string searchString);
        int TotalStudent();
        int NumberPage(int totalstudent, int limit);
        Task<IEnumerable<Student>> PaginationStudent(int start, int limit);
    }
}
