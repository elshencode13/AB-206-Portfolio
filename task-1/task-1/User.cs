using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class User : Human
    {
        private string _username;
        private int _password;

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                if (value.Length > 6 && value.Length < 25)
                {

                }

            }
        }
        public int Password
        {
            get { return _password; }
            set
            {
                _password = value;
                if (value > 8 && value < 25)
                {

                }

            }
        }
        public User(string name, string surname, byte age, string username, int password) : base(name, surname, age)
        {
            Password = password;
            Username = username;
        }


    }
}
