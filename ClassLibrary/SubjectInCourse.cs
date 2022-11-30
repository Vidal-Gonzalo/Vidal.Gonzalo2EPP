using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    public class SubjectInCourse
    {
        //1: Regular - 0:Free
        private short _status;
        private string _name;
        private List<Student> _students;
        private List<Professor> _professors;
        private List<Exam> _exams;


        public SubjectInCourse()
        {
            _status = -1;
            _name = "";
            _students = new List<Student>();
            _professors = new List<Professor>();
            _exams = new List<Exam>();
        }

        public SubjectInCourse(short status, string name, List<Student> students, List<Exam> exams)
        {
            _status = status;
            _name = name;
            _students = students;
            _exams = exams;
        }

        public SubjectInCourse(short status, string name, Student student) //admin form 259
        {
            _status = status;
            _name = name;
            _students = new List<Student>();
            _professors = new List<Professor>();
            _exams = new List<Exam>();
            _students.Add(student);
        }

        public SubjectInCourse(short status, string name)
        {
            _status = status;
            _name = name;
            _students = new List<Student>();
            _professors = new List<Professor>();
            _exams = new List<Exam>();

        }

        public short Status { get { return _status; } set { _status = value; } }

        public string Name { get { return _name; } }

        public List<Student> Students { get { return _students; } set { _students = value; } }

        public List<Professor> Professors { get { return _professors; } set { _professors = value; } }

        public List<Exam> Exams { get { return _exams; } set { _exams = value; } }

        public static bool operator ==(SubjectInCourse subject, string name)
        {
            bool r = false;
            if (subject is not null && name != "")
            {
                if (subject.Name == name)
                {
                    r = true;
                }
            }

            return r;
        }

        public static bool operator !=(SubjectInCourse subject, string name)
        {
            return !(subject == name);
        }

        public static bool operator ==(SubjectInCourse subject, Student student)
        {
            bool r = false;
            if (subject is not null && student is not null)
            {
                for (int i = 0; i < subject.Students.Count; i++)
                    if (subject.Students[i] == student)
                    {
                        r = true;
                    }
            }
            return r;
        }

        public static bool operator !=(SubjectInCourse subject, Student student)
        {
            return !(subject == student);
        }


        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
