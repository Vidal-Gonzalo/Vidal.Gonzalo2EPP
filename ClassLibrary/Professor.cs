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
        private short _professorId;
        #endregion

        #region Builders
        public Professor(short professorId, string email, string password) : base(email, password)
        {
            _professorId = professorId;
        }

        #endregion

        #region Props
        public short Id { get { return _professorId; } }
        #endregion

        #region Methods

        #endregion
    }
}
