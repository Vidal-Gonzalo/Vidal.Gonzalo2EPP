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
        private Student _student;
        private List<Exam> _exams;


        public SubjectInCourse()
        {
            _status = -1;
            _name = "";
            _student = new Student();
            _exams = new List<Exam>();
        }

        public SubjectInCourse(short status, string name, Student student, List<Exam> exams)
        {
            _status = status;
            _name = name;
            _student = student;
            _exams = exams;
        }

        public SubjectInCourse(short status, string name, Student student)
        {
            _status = status;
            _name = name;
            _student = student;
            _exams = new List<Exam>();
        }

        public short Status { get { return _status; } set { _status = value; } }

        public string Name { get { return _name; } }

        public Student Student { get { return _student; } }

        public string StudentEmail { get { return _student.Email; } }

        public List<Exam> Exams { get { return _exams; } set { _exams = value; } }

        public static bool operator ==(SubjectInCourse subject, string name)
        {
            bool r = false;
            if(subject is not null && name != "")
            {
                if(subject.Name == name)
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
