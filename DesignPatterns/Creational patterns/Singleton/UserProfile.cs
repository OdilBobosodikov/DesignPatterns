using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_patterns.Singleton
{
    internal class UserProfile
    {
        private static UserProfile? userProfile;

        public string UserName { get; set; }


        private UserProfile(string username) 
        {
            UserName = username;
        }


        public static UserProfile LogIn(string username)
        {
            if (userProfile is null)
            {
                userProfile = new UserProfile(username);
            }

            return userProfile;
        }

        public override string ToString()
        {
            return UserName;
        }
    }
}
