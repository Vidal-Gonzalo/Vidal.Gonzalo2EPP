using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    static class Data
    {
        static List<User> _users;
        static List<Admin> _admins;
        static List<Professor> _professors;
        static List<Student> _students;
        static List<Subject> _subjects;

        static Data()
        {
            #region Lists
            _users = new List<User>();
            _admins = new List<Admin>();
            _students = new List<Student>();
            _professors = new List<Professor>();
            _subjects = new List<Subject>();
            #endregion
            #region Students
            Student hardCodedStudent1 = new(1, "gonzalo@gmail.com", "gonza123");
            Student hardCodedStudent2 = new(2, "vidal@gmail.com", "vidal123");
            _students.Add(hardCodedStudent1);
            _students.Add(hardCodedStudent2);
            #endregion

            #region Professors
            Professor hardCodedProfessor1 = new(1, "mario@gmail.com", "mario123");
            Professor hardCodedProfessor2 = new(2, "rampi@gmail.com", "rampi123");
            _professors.Add(hardCodedProfessor1);
            _professors.Add(hardCodedProfessor2);
            #endregion

            #region Admins
            Admin hardCodedAdmin1 = new(1, "admin@gmail.com", "admin123");
            _admins.Add(hardCodedAdmin1);
            #endregion

            #region Subjects
            //Subject hardCodedSubject1 = new(1, "Matematica", 1,);
            //Subject hardCodedSubject2 = new();
            //Subject hardCodedSubject3 = new();
            //Subject hardCodedSubject4 = new();
            #endregion

            #region UsersAdd
            _users.Add(hardCodedStudent1);
            _users.Add(hardCodedProfessor1);
            _users.Add(hardCodedAdmin1);
            #endregion
        }
        public static List<User> Users { get { return _users; } set { _users = value; } }

        public static List<Admin> Admins { get { return _admins; } }

        public static List<Student> Students { get { return _students; } }

        public static List<Professor> Professors { get { return _professors; } }

        public static User? CheckLogin(string email, string password)
        {
            foreach (User user in _users)
            {
                if(user.Email == email && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }


    }
}


//Entiendo que este no es el mejor método para solucionar el problema pero estoy tratando de imitar una base de datos para no tener que 
//terminar haciendo prop drilling.