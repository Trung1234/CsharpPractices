using SimpleLoginApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleLoginApp.Services
{
    public class UserService : IUserService
    {
        public UserProfile GetUserProfile(string name, string password)
        {
            try
            {
                using (UserManagementEntities db = new UserManagementEntities())
                {
                    return db.UserProfiles.FirstOrDefault(a => a.UserName.Equals(name) && a.Password.Equals(password));                      
                }
            }
            catch
            {
                return null;
            }     
        }
            
    }
}