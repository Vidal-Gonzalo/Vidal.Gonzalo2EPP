using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Subject
    {
        private int _id;
        private string _name;
        private int _period;
        private List<Professor> _professors;
        private List<Student> _students;
        private int _correlativeId;

        public Subject(int id, string name, short period, List<Professor> professors, List<Student> students, short correlativeId)
        {
            _id = id;
            _name = name;
            _period = period;
            _professors = professors;
            _students = students;
            _correlativeId = correlativeId;
        }

        public Subject(int id, string name, int period, int correlativeId)
        {
            _id = id;
            _name = name;
            _period = period;
            _correlativeId = correlativeId;
            _professors = new List<Professor>();
            _students = new List<Student>();
        }

        public int Id { get { return _id; } }

        public string Name { get { return _name; } }

        public int Period { get { return _period; } }

        public List<Professor> Professors { get { return _professors; } }
    
        public List<Student> Students { get { return _students; } }
        
        public int CorrelativeId { get { return _correlativeId; } }

        public static bool operator ==(Professor professor, Subject subject)
        {
            bool r = false;
            for(int i = 0; i < subject.Professors.Count; i++)
            {
                if (subject.Professors[i].Id == professor.Id)
                {
                    r = true;
                }
            }
            return r;
        }

        public static bool operator !=(Professor professor, Subject subject)
        {
            return !(professor == subject);
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
