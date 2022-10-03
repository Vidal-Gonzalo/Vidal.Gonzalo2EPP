using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Admin : User
    {
        #region Fields
        private short _adminId;
        #endregion

        #region Builders
        public Admin(short adminId, string email, string password) : base(email, password)
        {
            _adminId = adminId;
        }
        #endregion

        public Admin()
        {
            _adminId = 0;
            _email = "";
            _password = "";
        }

        #region Props
        public short AdminId { get { return _adminId; } }
        #endregion

        #region Methods
        public bool RegisterUser(List<User> usersList, short id, string email, string password, string typeOfUser)
        {
            bool r = false;

            if(usersList.Count > 0 && id > 0 && email != "" && password != "")
            {
                switch (typeOfUser)
                {
                    case "Admin":
                        Admin admin = new(id, email, password);
                        usersList.Add(admin);
                        break;
                    case "Student":
                        Student student = new(id, email, password);
                        usersList.Add(student);
                        break;
                    case "Professor":
                        Professor professor = new(id, email, password);
                        usersList.Add(professor);
                        break;
                }
                r = true;
            }

            return r;
        }

        public short GetNewAdminId(List<Admin> adminList)
        {
            short max = 0;
            foreach (Admin admin in adminList)
            {
               if(admin.AdminId > max)
                    max = admin.AdminId;
            }

            return max += 1;
        }

        public short GetNewStudentId(List<Student> studentList)
        {
            short max = 0;
            foreach (Student student in studentList)
            {
                if (student.StudentId > max)
                    max = student.StudentId;
            }

            return max += 1;
        }

        public short GetNewProfessorId(List<Professor> professorList)
        {
            short max = 0;
            foreach (Professor professor in professorList)
            {
                if (professor.ProfessorId > max)
                    max = professor.ProfessorId;
            }

            return max += 1;
        }
        #endregion
    }
}
