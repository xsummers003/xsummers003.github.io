using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public class Login
    {
        private string username;
        public string Username
        {
            get { return username; }
        }
        
        private string encriptPass;
        public string EncriptPass
        {
            get { return encriptPass; }
        }

        public Login(string username, string password)
        {
            this.username = username;
            this.encriptPass = _PassEncription.Encript(password);
        }

        public bool Validate()
        {
            //add validation code here
            return true;
        }

    }
}
