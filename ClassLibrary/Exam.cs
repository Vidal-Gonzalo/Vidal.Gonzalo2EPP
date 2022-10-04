using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Exam
    {
        private string _name;
        private string _date;
        private int _calification;

        public Exam(string name, string date, int calification)
        {
            _name = name;
            _date = date;
            _calification = calification;
        }

        public Exam(string name, string date)
        {
            _name = name;
            _date = date;
            _calification = -1;
        }

        public Exam()
        {
            _name = "";
            _date = "";
            _calification = 0;
        }


        public string Name { get { return _name; } set { _name = value; } }

        public string Date { get { return _date; } set { _date = value; } }

        public int Calification { get { return _calification; } set { _calification = value; } }
    }
}
