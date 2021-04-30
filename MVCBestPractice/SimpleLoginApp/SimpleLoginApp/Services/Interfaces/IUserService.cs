using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLoginApp.Services.Interfaces
{
    public interface IUserService
    {
        UserProfile GetUserProfile(string name, string password);
    }
}
