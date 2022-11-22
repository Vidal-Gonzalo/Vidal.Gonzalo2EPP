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
    }
}
