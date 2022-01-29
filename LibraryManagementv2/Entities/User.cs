using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementv2.Entities
{
    internal class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public bool IsActive { get; set; }
        public User(int userId, string firstName,string lastName,bool isActive)
        {

            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            IsActive = isActive;
        }
    }
}
