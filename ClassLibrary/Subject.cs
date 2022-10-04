using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Subject
    {
        private short _id;
        private string _name;
        private short _period;
        private List<Professor> _professors;
        private List<Student> _students;
        private short _correlativeId;

        public Subject(short id, string name, short period, List<Professor> professors, List<Student> students, short correlativeId)
        {
            _id = id;
            _name = name;
            _period = period;
            _professors = professors;
            _students = students;
            _correlativeId = correlativeId;
        }

        public Subject(short id, string name, short period, short correlativeId)
        {
            _id = id;
            _name = name;
            _period = period;
            _correlativeId = correlativeId;
            _professors = new List<Professor>();
            _students = new List<Student>();
        }

        public short Id { get { return _id; } }

        public string Name { get { return _name; } }

        public short Period { get { return _period; } }

        public List<Professor> Professors { get { return _professors; } }
    
        public List<Student> Students { get { return _students; } }
        
        public short CorrelativeId { get { return _correlativeId; } }


    }
}
