using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{


    public class Student : User
    {
        private short _studentId;
        private List<Subject> _subjects;
        private List<SubjectInCourse> _subjectsInCourse;

        public Student()
        {
            _studentId = 0;
            _subjects = new List<Subject>();
            _subjectsInCourse = new List<SubjectInCourse>();
        }
        public Student(short studentId, string email, string password) : base(email, password)
        {
            _studentId = studentId;
            _subjects = new List<Subject>();
            _subjectsInCourse = new List<SubjectInCourse>();
        }
        public Student(short studentId,List<Subject> subjects, string email, string password) : base(email, password)
        {
            _studentId = studentId;
            _subjects = subjects;
        }

        public short StudentId { get { return _studentId; } }
        
        public List<Subject> Subjects { get { return _subjects; } }

        public List<SubjectInCourse> SubjectsInCourse { get { return _subjectsInCourse; } set { _subjectsInCourse = value; } }

    }
}
