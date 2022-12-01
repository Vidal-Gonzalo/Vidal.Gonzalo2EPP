using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using ServiceStack.Text;
using System.Windows;

namespace ClassLibrary
{
    public class Admin : User, ISerialize<Student>
    {
        #region Fields
        #endregion

        #region Builders
        public Admin(int id, string email, string password, int role) : base(id, email, password, role)
        {
        }
        #endregion

        public Admin()
        {
            _email = "";
            _password = "";
        }

        #region Props
        public new int Id { get { return _id; } }
        #endregion

        #region Methods


        public bool RegisterSubject(Delegate register, List<Subject> subjectList, string name, short period, short correlativeId)
        {
            bool r = false;
            if (subjectList is not null && name != "" && period > 0 && correlativeId > 0)
            {
                r = (bool)register.DynamicInvoke(name, period, correlativeId);
                if (r)
                    subjectList.Clear();
            }
            return r;
        }

        public bool AssignProfessorToSubject(Delegate assign, List<SubjectInCourse> subjectList, int userId, string subjectName, int status)
        {
            bool r = false;
            if (subjectList is not null && subjectName != "" && userId > 0 && status >= 0 && status <= 1)
            {
                r = (bool)assign.DynamicInvoke(userId, subjectName, status);
                if (r)
                    subjectList.Clear();
            }
            return r;
        }

        public Student FindStudentByEmail(List<Student> students, string email)
        {
            if (students is not null && email != "")
            {
                foreach (Student student in students)
                {
                    if (student.Email == email)
                    {
                        return student;
                    }
                }
            }

            return null;
        }

        public SubjectInCourse FindSubjectByName(List<SubjectInCourse> subjectsInCourse, string name, Student student)
        {
            if (name != "" && student is not null)
            {
                foreach (SubjectInCourse subject in subjectsInCourse)
                {
                    if (subject.Name == name)
                    {
                        SubjectInCourse subjectInCourse = subject;
                        return subjectInCourse;
                    }
                }
            }
            return null;
        }

        public Professor FindProfessorByEmail(string email, List<Professor> professorsList)
        {
            if (email != "" && professorsList.Count > 0)
            {
                foreach (Professor professor in professorsList)
                {
                    if (professor.Email == email)
                    {
                        return professor;
                    }
                }
            }

            return null;
        }

        public Subject FindSubjectById(short subjectId, List<Subject> subjects)
        {
            if (subjectId > 0 && subjects.Count > 0)
            {
                foreach (Subject subject in subjects)
                {
                    if (subject.Id == subjectId)
                    {
                        return subject;
                    }
                }
            }

            return null;
        }

        public bool SerializeToJson(List<Student> students)
        {
            bool r = false;
            if (students.Count > 0)
            {
                r = true;
                string fileName = "studentsInJson.json";
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = System.Text.Json.JsonSerializer.Serialize(students, options);

                File.WriteAllText(fileName, jsonString);
            }
            return r;
        }

        public bool SerializeToCsv(List<Student> students)
        {
            bool r = false;
            if (students.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                string fileName = "studentsInCsv";
                foreach (Student student in students)
                {
                    var csv = CsvSerializer.SerializeToCsv(new[] { student });
                    sb.AppendLine(csv);
                }

                File.WriteAllText(fileName, sb.ToString());
                r = true;
            }
            return r;
        }

        public bool DeserializeFromJson(Delegate addStudent, string path, List<Student> students) //Data.students
        {
            bool r = false;
            if (path != "" && students is not null)
            {
                bool exists = File.Exists(path);
                if (exists)
                {
                    string jsonString = File.ReadAllText(path);
                    bool added = false;
                    var list = System.Text.Json.JsonSerializer.Deserialize<List<Student>>(jsonString);
                    foreach (Student student in list)
                    {
                        if (AddStudentToStudentsList(addStudent, students, student))
                        {
                            added = true;
                        }
                        else
                        {
                            added = false;
                            break;
                        }
                    }
                    if (added)
                    {
                        r = true;
                    }
                }
            }
            return r;
        }

        public bool AddStudentToStudentsList(Delegate addStudent, List<Student> students, Student student)
        {
            bool r = false;
            if (students is not null && student is not null)
            {
                for(int i = 0; i < students.Count; i++)
                {
                    r = students[i].Email == student.Email;
                    if (r)
                        break;
                }
                if (!r)
                {
                    r = (bool)addStudent.DynamicInvoke(student.Email, student.Password);
                }
            }
            return r;
        }
        #endregion
    }
}
