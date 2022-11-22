﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Login
{
    static class Data
    {
        static List<User> _users;
        static List<Admin> _admins;
        static List<Professor> _professors;
        static List<Student> _students;
        static List<Subject> _subjects;
        static List<SubjectInCourse> _subjectsInCourse1;
        static List<SubjectInCourse> _subjectsInCourse2;
        static List<Exam> _exams;
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;

        static Data()
        {

            _sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=parcial_dos;Integrated Security=True");
            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;


            #region Lists
            _users = new List<User>();
            _admins = new List<Admin>();
            _students = new List<Student>();
            _professors = new List<Professor>();
            _subjects = new List<Subject>();
            _subjectsInCourse1 = new List<SubjectInCourse>();
            _subjectsInCourse2 = new List<SubjectInCourse>();
            _exams = new List<Exam>();

            #endregion

            #region Students
            #endregion
            #region Subjects in course

            #endregion
            #region Professors
            #endregion

            #region Admins
            #endregion

            #region Subjects
            #endregion

            #region UsersAdd
            #endregion
        }
        public static List<User> Users { get { return _users; } set { _users = value; } }

        public static List<Admin> Admins { get { return _admins; } }

        public static List<Student> Students { get { return _students; } }

        public static List<Professor> Professors { get { return _professors; } }

        public static List<Subject> Subjects { get { return _subjects; } }

        public static List<SubjectInCourse> SubjectsInCourses { get { return _subjectsInCourse1; } }

        public static bool GetUsers()
        {
            bool r = false;

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM USUARIOS";
                _sqlConnection.Open();
                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    _users.Add(new User(Convert.ToInt32(reader["ID"]), reader["EMAIL"].ToString(), reader["CONTRASEÑA"].ToString(), Convert.ToInt32(reader["ROL"])));
                    r = true;
                }
                AssignUserRoles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El error está en: " + ex.Message);
            }
            finally
            {
                _sqlConnection.Close();
            }
            return r;
        }

        public static bool GetSubjects()
        {
            bool r = false;

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM MATERIAS";
                _sqlConnection.Open();
                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    _subjects.Add(new Subject(Convert.ToInt16(reader["ID"]), reader["NOMBRE"].ToString(), Convert.ToInt16(reader["PERIODO"]), Convert.ToInt32(reader["CORRELATIVA"])));
                    r = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El error está en: " + ex.Message);
            }
            finally
            {
                _sqlConnection.Close();

            }
            return r;
        }

        public static User GetEmailUser(string email)
        {
            User userAux = new();
            try
            {
                _sqlCommand.CommandText = $"SELECT * FROM USUARIOS WHERE EMAIL = '{email}'";
                _sqlConnection.Open();
                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    userAux = new(Convert.ToInt32(reader["ID"]), reader["EMAIL"].ToString(), reader["CONTRASEÑA"].ToString(), Convert.ToInt32(reader["ROL"]));

                }
                AssignUserRoles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El error está en: " + ex.Message);
            }
            finally
            {
                _sqlConnection.Close();
            }
            return userAux;
        }


        private static bool AssignUserRoles()
        {
            bool r = false;
            foreach (User user in _users)
            {
                switch (user.Role)
                {
                    case 1:
                        Admin admin = new Admin(user.Id, user.Email, user.Password, user.Role);
                        _admins.Add(admin);
                        r = true;
                        break;
                    case 2:
                        Professor professor = new Professor(user.Id, user.Email, user.Password, user.Role);
                        _professors.Add(professor);
                        r = true;
                        break;
                    case 3:
                        Student student = new Student(user.Id, user.Email, user.Password, user.Role);
                        _students.Add(student);
                        r = true;
                        break;
                    default:
                        break;
                }
            }
            return r;
        }

        public static bool EnrollSubjectToUser(int idUser, string nameSubject)
        {
            bool r = false;
            try
            {
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"INSERT INTO MATERIAS_A_USUARIOS(ID_USUARIO, ESTADO, NOMBRE, EXAMEN) VALUES(@id_usuario, @estado, @nombre, @examen)";
                _sqlCommand.Parameters.AddWithValue("@id_usuario", idUser);
                _sqlCommand.Parameters.AddWithValue("@estado", 1);
                _sqlCommand.Parameters.AddWithValue("@nombre", nameSubject);
                _sqlCommand.Parameters.AddWithValue("@examen", 0);
                SqlDataReader reader = _sqlCommand.ExecuteReader();
                _sqlCommand.ExecuteNonQuery();

                r = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El error está en: " + ex.Message);
            }
            finally
            {
                _sqlConnection.Close();
            }
            return r;
        }

        public static bool AssignSubjectsToUsers()
        {
            bool r = false;
            try
            {
                _sqlCommand.CommandText = "SELECT * FROM MATERIAS_A_USUARIOS";
                _sqlConnection.Open();
                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    SubjectInCourse subjectInCourse = new(Convert.ToInt16(reader["ESTADO"]), reader["NOMBRE"].ToString());
                    Student? studentAux = FindStudentById(Convert.ToInt16(reader["ID_USUARIO"]));
                    if (studentAux is not null)
                    {
                        Student student = studentAux;
                        subjectInCourse.Student = student;
                    }
                    r = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El error está en: " + ex.Message);
            }
            finally
            {
                _sqlConnection.Close();
            }
            return r;
        }

        public static bool RegisterUser(string email, string password, int role)
        {
            bool r = false;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = "INSERT INTO USUARIOS (EMAIL, CONTRASEÑA, ROL) VALUES (@email, @contraseña, @rol)";
                _sqlCommand.Parameters.AddWithValue("@email", email);
                string hashedPassword = Hashing.HashPassword(password);
                _sqlCommand.Parameters.AddWithValue("@contraseña", hashedPassword);
                _sqlCommand.Parameters.AddWithValue("@rol", role);
                _sqlCommand.ExecuteNonQuery();
                r = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _sqlConnection.Close();
            }

            return r;
        }

        public static User? CheckLogin(string email, string password)
        {
            User user = GetEmailUser(email);
            if (user is not null)
            {
                if (user.Email == email && Hashing.ValidatePassword(password, user.Password))
                {
                    return user;
                }
            }

            return null;
        }



        public static Student? FindStudentByEmail(string? email)
        {
            if (email is not null)
            {
                foreach (Student student in _students)
                {
                    if (student.Email == email)
                    {
                        return student;
                    }
                }
            }

            return null;
        }
        public static Student? FindStudentById(short id)
        {
            if (id > 0)
            {
                foreach (Student student in _students)
                {
                    if (student.Id == id)
                    {
                        return student;
                    }
                }
            }

            return null;
        }

        public static Professor? FindProfessorByEmail(string? email)
        {
            if (email is not null)
            {
                foreach (Professor professor in _professors)
                {
                    if (professor.Email == email)
                    {
                        return professor;
                    }
                }
            }

            return null;
        }

        public static SubjectInCourse? FindSubjectByName(Student? student, string? name)
        {
            SubjectInCourse subjectInCourse = new();
            if (name != "" && student is not null)
            {
                foreach (SubjectInCourse subject in student.SubjectsInCourse)
                {
                    if (subject.Name == name)
                    {
                        subjectInCourse = subject;
                    }
                }
            }
            return subjectInCourse;
        }

        public static Subject? FindSubjectById(short subjectId)
        {
            if (subjectId > 0)
            {
                foreach (Subject subject in _subjects)
                {
                    if (subject.Id == subjectId)
                    {
                        return subject;
                    }
                }
            }

            return null;
        }
        public static bool AssignProfessorToSubject(short subjectId, Professor professor)
        {
            bool r = false;
            if (subjectId > 0 && professor is not null)
            {
                Subject? subject = FindSubjectById(subjectId);
                if (subject is not null)
                {
                    subject.Professors.Add(professor);
                    r = true;
                }
            }
            return r;
        }

        public static SubjectInCourse? FindSubjectInCourseByName(string name)
        {
            if (name != "")
            {
                foreach (SubjectInCourse item in Data.SubjectsInCourses)
                {
                    if (item.Name == name)
                    {
                        return item;
                    }
                }
            }
            return null;
        }


        public static bool CheckIfSubjectContainsStudent(string subject, string student)
        {
            bool r = false;
            if (student != "")
            {
                foreach (SubjectInCourse item in SubjectsInCourses)
                {
                    if (item.Name == subject)
                    {
                        if (item.StudentEmail == student)
                        {
                            r = true;
                        }
                    }
                }
            }
            return r;
        }

        public static bool CorrectNumberOfSubjects(int max, Student student)
        {
            bool r = false;
            if (max >= 0 && student is not null)
            {
                if (student.SubjectsInCourse.Count < max)
                {
                    r = true;
                }
            }
            return r;
        }

    }
}


//Entiendo que este no es el mejor método para solucionar el problema pero estoy tratando de imitar una base de datos para no tener que 
//terminar haciendo prop drilling.