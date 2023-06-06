using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class User
    {
        private int _id;
        private string _email;
        private string _password;
        private string _role;

        public User()
        {

        }

        public User(string _email, string _password, string _role ) {

            this._email = _email;
            this._password = _password;
            this._role = _role;
        }

        public User (string _email, string _password)
        {
            this._email= _email;
            this._password = _password;
        }

        public void Setemail(string _email)
        {
            this._email = _email;
        }
        
        public void Setpassword(string _password)
        {
            this._password = _password;
        }

        public void Setrole(string _role)
        {
            this._role = _role;
        }

        
        public string   getUserEmail()
        {
            return _email;
        }

        public string getPassword()
        {
            return _password;
        }

        public string getRole()
        {
            return _role;
        }

    }
}
