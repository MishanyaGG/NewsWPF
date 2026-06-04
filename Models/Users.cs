using System;
using System.Collections.Generic;
using System.Text;

namespace NewsWPF.Models
{
    public class Users
    {
        public string Login { get; private set; }
        public string Password{ get; private set; }

        public Users (string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
