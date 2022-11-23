using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Design_Project
{
    internal class User
    {
        private int userId;
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private string role;

        /// <summary>
        /// Constructor.
        /// </summary>
        public User()
        {

        }

        private int UserId { get { return userId; } set { userId = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        private string LastName { get { return lastName; } set { lastName = value; } }

        private string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        private string Email { get { return email; } set { email = value; } }
        private string Password { get { return password; } set { password = value; } }
        private string Role { get { return role; } set { role = value; } }

    }
}
