using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class User
    {
        protected int _id;
        protected string _email;
        protected string _password;
        protected int _role;

        public User()
        {
            _id = 0;
            _email = "";
            _password = "";
            _role = 0;
        }

        public User(int id, string email, string password, int role)
        {
            _id = id;
            _email = email;
            _password = password;
            _role = role;
        }
        public int Id { get => _id; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }
        public int Role { get => _role; }

    }
}
