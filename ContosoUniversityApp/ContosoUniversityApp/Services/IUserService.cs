using ContosoUniversityApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversityApp.Services
{
    public interface IUserService
    {
        string RegisterUser(UserDetails user);
        string ValidateLogin(UserDetails user);
    }
}
