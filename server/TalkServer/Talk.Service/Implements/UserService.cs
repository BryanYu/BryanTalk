using System;
using System.Collections.Generic;
using System.Text;
using Talk.Models.Account;
using Talk.Service.Interfaces;

namespace Talk.Service.Implements
{
    public class UserService : IUserService
    {
        public UserService()
        {
            

        }

        /// <summary>
        /// 帳號密碼驗證
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Verify(string account, string password)
        {
            return true;
        }

        /// <summary>
        /// 註冊使用者
        /// </summary>
        /// <param name="register"></param>
        public void Register(RegisterModel register)
        {
            
        }
    }
}
