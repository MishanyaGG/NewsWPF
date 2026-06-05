using System;
using System.Collections.Generic;
using System.Text;

namespace NewsWPF.Models
{
    public class Users
    {
        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; private set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password{ get; private set; }

        /// <summary>
        /// Роль пользователя (1 - админ, всё остальное - обычный пользователь)
        /// </summary>
        public int Role { get; private set; }


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <param name="role">Роль пользователя (1 - админ, всё остальное - обычный пользователь)</param>
        public Users (string login, string password, int role)
        {
            Login = login;
            Password = password;
            Role = role;
        }
    }
}
