﻿using System.ComponentModel;

namespace VideoStore_Model.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        [DisplayName("ФИО")]
        public string FIO { get; set; }
        [DisplayName("Роль")]
        public string Role { get; set; }
        [DisplayName("Должность")]
        public string Position { get; set; }
        [DisplayName("Логин")]
        public string Login { get; set; }
        [DisplayName("Пароль")]
        public string Password { get; set; }
    }
}
