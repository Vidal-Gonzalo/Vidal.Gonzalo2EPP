using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class User
    {
        protected string _email;
        protected string _password;

        public User()
        {
            _email = "";
            _password = "";
        }

        public User(string email, string password)
        {
            _email = email;
            _password = password;
        }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }

    }
}
