using System;
using Talk.DataAccess.Interfaces;

namespace Talk.DataAccess
{
    public class UserDataAccess : IUserDataAccess
    {
        public bool Verify(string account, string password)
        {
            throw new NotImplementedException();
        }
    }
}
