using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{


    public class Student : User
    {
        private List<Subject> _subjects;
        private List<SubjectInCourse> _subjectsInCourse;

        public Student()
        {
            _subjects = new List<Subject>();
            _subjectsInCourse = new List<SubjectInCourse>();
        }
        public Student(int id, string email, string password, int role) : base(id, email, password, role)
        {
            _subjects = new List<Subject>();
            _subjectsInCourse = new List<SubjectInCourse>();
        }
        public Student(short id, List<Subject> subjects, string email, string password, int role) : base(id, email, password, role)
        {
            _subjects = subjects;
        }

        public int StudentId { get { return _id; } }
        
        public List<Subject> Subjects { get { return _subjects; } }

        public List<SubjectInCourse> SubjectsInCourse { get { return _subjectsInCourse; } set { _subjectsInCourse = value; } }

    }
}
