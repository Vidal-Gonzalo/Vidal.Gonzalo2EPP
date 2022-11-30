using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Professor : User
    {
        #region Fields
        #endregion

        #region Builders
        public Professor()
        {
            _id = 0;
            _email = "";
            _password = "";
            _role = 0;
        }
        public Professor(int id, string email, string password, int role) : base(id, email, password, role)
        {
        }

        #endregion

        #region Props
        public new int Id { get { return _id; } }
        #endregion

        #region Methods

        #endregion

        public static bool operator ==(Professor professor, SubjectInCourse subject)
        {
            bool r = false;
            if(professor is not null && subject is not null)
            {
                for(int i = 0; i < subject.Professors.Count; i++)
                {
                    if (subject.Professors[i].Email == professor.Email)
                    {

                        r = true;
                    }
                }
            }
            return r;
        }

        public static bool operator !=(Professor professor, SubjectInCourse subject)
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
