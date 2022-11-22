using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Admin : User
    {
        #region Fields
        #endregion

        #region Builders
        public Admin(int id, string email, string password, int role) : base(id, email, password, role)
        {
        }
        #endregion

        public Admin()
        {
            _email = "";
            _password = "";
        }

        #region Props
        public new int Id { get { return _id;  } }
        #endregion

        #region Methods
        

        public bool RegisterSubject(List<Subject> subjectList, short id, string name, short period, short correlativeId)
        {
            bool r = false;
            if (subjectList is not null && id > 0 && name != "" && period > 0 && correlativeId > 0)
            {
                Subject newSubject = new(id, name, period, correlativeId);
                subjectList.Add(newSubject);
                r = true;
            }
            return r;
        }

      
        public short GetNewSubjectId(List<Subject> subjectList)
        {
            int max = 0;
            foreach (Subject subject in subjectList)
            {
                if (subject.Id > max)
                    max = subject.Id;
            }

            return (short)(max += 1);
        }
        #endregion
    }
}
