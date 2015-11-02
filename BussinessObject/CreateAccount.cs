using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public class CreateAccount
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string encriptPass;
        public string EncriptPass
        {
            get { return encriptPass; }
            set { encriptPass = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private UserEnum userType;
        public UserEnum UserTyper
        {
            get { return userType; }
            set { userType = value; }
        }

        public CreateAccount(string firstName, string lastName, string userName, string password, string email, UserEnum userType)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = userName;
            this.encriptPass = _PassEncription.Encript(password);
            this.email = email;
            this.userType = userType;

            //insert code to make new account here
        }

    }
}
