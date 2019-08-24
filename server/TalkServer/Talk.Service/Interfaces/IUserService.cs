using System;
using System.Collections.Generic;
using System.Text;
using Talk.Models.Account;

namespace Talk.Service.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// 帳號密碼驗證
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool Verify(string account, string password);

        /// <summary>
        /// 註冊使用者
        /// </summary>
        /// <param name="register"></param>
        void Register(RegisterModel register);
    }
}
