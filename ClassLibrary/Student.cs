using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    public class Student : User
    {
        private List<Exam> _exams;

        public Student()
        {
            _exams = new List<Exam>();
        }
        public Student(int id, string email, string password, int role) : base(id, email, password, role)
        {
            _exams = new List<Exam>();
        }
        public Student(short id, List<Subject> subjects, string email, string password, int role) : base(id, email, password, role)
        {
            _exams = new List<Exam>();
        }

        public int StudentId { get { return _id; } }

        public List<Exam> Exams { get { return _exams; } }

    }
}
