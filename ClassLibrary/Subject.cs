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
        private int _correlativeId;


        public Subject(int id, string name, int period, int correlativeId)
        {
            _id = id;
            _name = name;
            _period = period;
            _correlativeId = correlativeId;
        }

        public Subject(string name, int period, int correlativeId)
        {
            _id = 0;
            _name = name;
            _period = period;
            _correlativeId = correlativeId;
        }

        public int Id { get { return _id; } }

        public string Name { get { return _name; } }

        public int Period { get { return _period; } }

        public int CorrelativeId { get { return _correlativeId; } }

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
