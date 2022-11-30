using ClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
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
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "SELECT * FROM USUARIOS";
                _sqlConnection.Open();
                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    User userAux = new User(Convert.ToInt32(reader["ID"]), reader["EMAIL"].ToString(), reader["CONTRASEÑA"].ToString(), Convert.ToInt32(reader["ROL"]));
                    if (userAux is not null && !CheckIfUserExists(userAux.Email))
                    {
                        _users.Add(userAux);
                        r = true;
                    }
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
                _sqlCommand.Parameters.Clear();
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
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = $"SELECT * FROM USUARIOS WHERE EMAIL = '{email}'";
                _sqlConnection.Open();
                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    userAux = new(Convert.ToInt32(reader["ID"]), reader["EMAIL"].ToString(), reader["CONTRASEÑA"].ToString(), Convert.ToInt32(reader["ROL"]));

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
                        if (FindAdminByEmail(user.Email) is null)
                        {
                            Admin admin = new Admin(user.Id, user.Email, user.Password, user.Role);
                            _admins.Add(admin);
                            r = true;
                        }
                        break;
                    case 2:
                        if (FindProfessorByEmail(user.Email) is null)
                        {
                            Professor professor = new Professor(user.Id, user.Email, user.Password, user.Role);
                            _professors.Add(professor);
                            r = true;
                        }
                        break;
                    case 3:
                        if (FindStudentByEmail(user.Email) is null)
                        {
                            Student student = new Student(user.Id, user.Email, user.Password, user.Role);
                            _students.Add(student);
                            r = true;
                        }
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
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"INSERT INTO MATERIAS_A_USUARIOS(ID_USUARIO, ESTADO, NOMBRE, EXAMEN) VALUES(@id_usuario, @estado, @nombre, @examen)";
                _sqlCommand.Parameters.AddWithValue("@id_usuario", idUser);
                _sqlCommand.Parameters.AddWithValue("@estado", 1);
                _sqlCommand.Parameters.AddWithValue("@nombre", nameSubject);
                _sqlCommand.Parameters.AddWithValue("@examen", 0);
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


        public static bool AssignUsersToSubjects()
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
                    User? user = FindUserById(Convert.ToInt16(reader["ID_USUARIO"]));
                    if (user is not null)
                    {
                        switch (user.Role)
                        {
                            case 2:
                                Professor professor = new(user.Id, user.Email, user.Password, user.Role);
                                if (!CheckIfProfessorExists(subjectInCourse.Name, professor.Email))
                                {
                                    subjectInCourse.Professors.Add(professor);
                                }
                                break;
                            case 3:
                                Student student = new(user.Id, user.Email, user.Password, user.Role);
                                if (!CheckIfSubjectContainsStudent(subjectInCourse.Name, student.Email))
                                {
                                    subjectInCourse.Students.Add(student);
                                }
                                break;
                            default:
                                break;
                        }
                        if (!CheckIfSubjectInCourseContainsSubject(subjectInCourse.Name, user.Id))
                        {
                            _subjectsInCourse1.Add(subjectInCourse);
                        }
                    }
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




        public static bool ChangeSubjectStatus(int userId, string subjectName, int status)
        {
            bool r = false;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = "UPDATE MATERIAS_A_USUARIOS SET ESTADO=@status WHERE(ID_USUARIO=@user_id) AND (NOMBRE=@subject)";
                _sqlCommand.Parameters.AddWithValue("@status", status);
                _sqlCommand.Parameters.AddWithValue("@user_id", userId);
                _sqlCommand.Parameters.AddWithValue("@subject", subjectName);
                _sqlCommand.ExecuteNonQuery();
                r = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El error esta en " + ex.Message);
            }
            finally
            {
                _sqlConnection.Close();
            }

            return r;
        }

        public static bool RegisterSubject(string name, short period, short correlativeId)
        {
            bool r = false;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = "INSERT INTO MATERIAS (NOMBRE, PERIODO, CORRELATIVA) VALUES (@nombre, @periodo, @correlativa)";
                _sqlCommand.Parameters.AddWithValue("@nombre", name);
                _sqlCommand.Parameters.AddWithValue("@periodo", period);
                _sqlCommand.Parameters.AddWithValue("@correlativa", correlativeId);
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

        public static bool AssignProfessorToSubject(int userId, string subjectName, int status)
        {
            bool r = false;
            int exam = 0;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = "INSERT INTO MATERIAS_A_USUARIOS(ID_USUARIO, ESTADO, NOMBRE, EXAMEN) VALUES(@id_usuario, @estado, @nombre, @examen)";
                _sqlCommand.Parameters.AddWithValue("@id_usuario", userId);
                _sqlCommand.Parameters.AddWithValue("@estado", status);
                _sqlCommand.Parameters.AddWithValue("@nombre", subjectName);
                _sqlCommand.Parameters.AddWithValue("@examen", exam);
                _sqlCommand.ExecuteNonQuery();
                r = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El error esta en " + ex.Message);
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

        public static Professor? FindProfessorById(int id)
        {
            if (id > 0)
            {
                foreach (Professor professor in _professors)
                {
                    if (professor.Id == id)
                    {
                        return professor;
                    }
                }
            }

            return null;
        }

        public static User? FindUserById(int id)
        {
            if (id > 0)
            {
                foreach (User user in _users)
                {
                    if (user.Id == id)
                    {
                        return user;
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

        public static Admin? FindAdminByEmail(string? email)
        {
            if (email is not null)
            {
                foreach (Admin admin in _admins)
                {
                    if (admin.Email == email)
                    {
                        return admin;
                    }
                }
            }

            return null;
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


        public static SubjectInCourse? FindSubjectInCourseByName(string? name)
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

        public static bool CheckIfSubjectInCourseContainsSubject(string subjectInCourse, int userId)
        {
            bool r = false;
            if (subjectInCourse != "" && userId > 0)
            {
                foreach (SubjectInCourse item in SubjectsInCourses)
                {
                    if (item.Name == subjectInCourse)
                    {
                        for (int i = 0; i < item.Students.Count; i++)
                        {
                            if (item.Students[i].Id == userId)
                            {
                                MessageBox.Show("entre");
                                r = true;
                                break;
                            }
                        }
                        for (int i = 0; i < item.Professors.Count; i++)
                        {
                            if (item.Professors[i].Id == userId)
                            {
                                MessageBox.Show("entre");
                                r = true;
                                break;
                            }
                        }

                    }
                }
            }
            return r;
        }

        public static bool CheckIfSubjectContainsStudent(string subject, string student)
        {
            bool r = false;
            if (student != "")
            {
                for (int i = 0; i < SubjectsInCourses.Count; i++)
                {
                    if (SubjectsInCourses[i].Name == subject)
                    {
                        for (int j = 0; j < SubjectsInCourses[i].Students.Count; j++)
                        {
                            if (SubjectsInCourses[i].Students[j].Email == student)
                            {
                                r = true;
                            }
                        }
                        break;
                    }

                }
            }
            return r;
        }

        private static bool CheckIfUserExists(string userEmail)
        {
            bool r = false;
            foreach (User item in _users)
            {
                if (item.Email == userEmail)
                    r = true;
            }
            return r;
        }


        public static bool CheckIfProfessorExists(string subjectName, string professorEmail)
        {
            bool r = false;
            for (int i = 0; i < SubjectsInCourses.Count; i++)
            {
                if (subjectName == SubjectsInCourses[i].Name)
                {
                    for (int j = 0; j < SubjectsInCourses[i].Professors.Count; j++)
                    {
                        if (professorEmail == SubjectsInCourses[i].Professors[j].Email)
                        {
                            r = true;
                        }
                    }
                }
            }
            return r;
        }

        public static List<SubjectInCourse>? GetSubjectsFromStudent(Student student)
        {
            List<SubjectInCourse> subjectsFromStudent = new List<SubjectInCourse>();

            for (int i = 0; i < SubjectsInCourses.Count; i++)
            {
                for (int j = 0; j < SubjectsInCourses[i].Students.Count; j++)
                {
                    if (SubjectsInCourses[i].Students[j].Email == student.Email)
                    {
                        subjectsFromStudent.Add(SubjectsInCourses[i]);
                    }
                }
            }
            if (subjectsFromStudent.Count > 0)
            {
                return subjectsFromStudent;
            }
            else
            {
                return null;
            }
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
