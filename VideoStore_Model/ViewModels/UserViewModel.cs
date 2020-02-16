using System.ComponentModel;

namespace VideoStore_Model.ViewModels
{
    public class UserViewModel
    {
        [DisplayName("Идентификатор продавца")]
        public int Id { get; set; }
        [DisplayName("ФИО")]
        public string FIO { get; set; }
        [DisplayName("Роль")]
        public string Role { get; set; }
        [DisplayName("Должность")]
        public string Position { get; set; }
    }
}
