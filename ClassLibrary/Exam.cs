using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Exam
    {
        private int _userId;
        private string _subject;
        private string _name;
        private DateTime _date;
        private int _calification;

        public Exam(int userId, string subject, string name, DateTime date, int calification)
        {
            _userId = userId;
            _name = name;
            _date = date;
            _calification = calification;
            _subject = subject;
        }

        public Exam(int userId, string subject, string name, DateTime date)
        {
            _userId = userId;
            _subject = subject;
            _name = name;
            _date = date;
            _calification = -1;
        }

        public Exam()
        {
            _userId = 0;
            _subject = "";
            _name = "";
            _date = new DateTime();
            _calification = 0;
        }

        public int UserId { get { return _userId; } }
        public string Subject { get { return _subject; } }
        public string Name { get { return _name; } set { _name = value; } }

        public DateTime Date { get { return _date; } set { _date = value; } }

        public int Calification { get { return _calification; } set { _calification = value; } }
    }
}
