using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public interface IUserProfileService
    {
        UserProfile GetUserProfile(long id); 
    }
}
