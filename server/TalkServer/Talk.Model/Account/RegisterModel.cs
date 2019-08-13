using System;
using System.Collections.Generic;
using System.Text;

namespace Talk.Models.Account
{
    public class RegisterModel
    {
        /// <summary>
        /// 帳號
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 密碼
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 暱稱
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 電話
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 電子郵件
        /// </summary>
        public string Email { get; set; }
    }
}
