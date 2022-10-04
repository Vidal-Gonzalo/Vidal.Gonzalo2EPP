using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Login
{
    static class Data
    {
        static List<User> _users;
        static List<ClassLibrary.Admin> _admins;
        static List<Professor> _professors;
        static List<Student> _students;
        static List<Subject> _subjects;
        static List<SubjectInCourse> _subjectsInCourse1;
        static List<SubjectInCourse> _subjectsInCourse2;

        static Data()
        {
            #region Lists
            _users = new List<User>();
            _admins = new List<ClassLibrary.Admin>();
            _students = new List<Student>();
            _professors = new List<Professor>();
            _subjects = new List<Subject>();
            _subjectsInCourse1 = new List<SubjectInCourse>();
            _subjectsInCourse2 = new List<SubjectInCourse>();
            #endregion

            #region Students
            Student hardCodedStudent1 = new(1, "gonzalo@gmail.com", "gonza123");
            Student hardCodedStudent2 = new(2, "vidal@gmail.com", "vidal123");
            _students.Add(hardCodedStudent1);
            _students.Add(hardCodedStudent2);
            #endregion
            #region Subjects in course
            SubjectInCourse subjectInCourse1 = new(1, "Matematica", hardCodedStudent1, 3);
            SubjectInCourse subjectInCourse2 = new(1, "Física", hardCodedStudent1, 4);
            SubjectInCourse subjectInCourse3 = new(1, "Programacion", hardCodedStudent2, 3);
            SubjectInCourse subjectInCourse4 = new(1, "Química", hardCodedStudent2, 4);
            _subjectsInCourse1.Add(subjectInCourse1);
            _subjectsInCourse1.Add(subjectInCourse2);
            _subjectsInCourse2.Add(subjectInCourse3);
            _subjectsInCourse2.Add(subjectInCourse4);
            hardCodedStudent1.SubjectsInCourse = _subjectsInCourse1;
            hardCodedStudent2.SubjectsInCourse = _subjectsInCourse2;

            #endregion
            #region Professors
            Professor hardCodedProfessor1 = new(1, "mario@gmail.com", "mario123");
            Professor hardCodedProfessor2 = new(2, "rampi@gmail.com", "rampi123");
            _professors.Add(hardCodedProfessor1);
            _professors.Add(hardCodedProfessor2);
            #endregion

            #region Admins
            ClassLibrary.Admin hardCodedAdmin1 = new(1, "admin@gmail.com", "admin123");
            _admins.Add(hardCodedAdmin1);
            #endregion

            #region Subjects
            Subject hardCodedSubject1 = new(1, "Matematica", 1, 5);
            Subject hardCodedSubject2 = new(2, "Programación", 2, 6);
            //Subject hardCodedSubject3 = new();
            //Subject hardCodedSubject4 = new();
            _subjects.Add(hardCodedSubject1);
            _subjects.Add(hardCodedSubject2);
            #endregion

            #region UsersAdd
            _users.Add(hardCodedStudent1);
            _users.Add(hardCodedProfessor1);
            _users.Add(hardCodedAdmin1);
            #endregion
        }
        public static List<User> Users { get { return _users; } set { _users = value; } }

        public static List<ClassLibrary.Admin> Admins { get { return _admins; } }

        public static List<Student> Students { get { return _students; } }

        public static List<Professor> Professors { get { return _professors; } }

        public static List<Subject> Subjects { get { return _subjects; } }

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

        public static Student? FindStudentByEmail(string? email)
        {
            if(email is not null)
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
            if(name != "" && student is not null)
            {
                foreach(SubjectInCourse subject in student.SubjectsInCourse)
                {
                    if(subject.Name == name)
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
            if(subjectId > 0 && professor is not null)
            {
                Subject? subject = FindSubjectById(subjectId);
                if(subject is not null)
                {
                    subject.Professors.Add(professor);
                    r = true;
                }
            }
            return r;
        }
    }
}


//Entiendo que este no es el mejor método para solucionar el problema pero estoy tratando de imitar una base de datos para no tener que 
//terminar haciendo prop drilling.