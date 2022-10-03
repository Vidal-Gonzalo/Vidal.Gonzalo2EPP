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

        public Student(short studentId, string email, string password) : base(email, password)
        {
            _studentId = studentId;
        }

        public short StudentId { get { return _studentId; } }
    }
}
