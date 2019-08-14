using System;
using System.Collections.Generic;

namespace Talk.DataAccess.Models
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
    }
}
