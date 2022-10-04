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
        private int _exams;

        public SubjectInCourse()
        {
            _status = -1;
            _name = "";
            _student = new Student();
            _exams = 0;
        }

        public SubjectInCourse(short status, string name, Student student, int exams)
        {
            _status = status;
            _name = name;
            _student = student;
            _exams = exams;
        }

        public short Status { get { return _status; } set { _status = value; } }

        public string Name { get { return _name; } }

        public Student Student { get { return _student; } }

        public string StudentEmail { get { return _student.Email; } }

        public int Exams { get { return _exams; } }
    }
}
