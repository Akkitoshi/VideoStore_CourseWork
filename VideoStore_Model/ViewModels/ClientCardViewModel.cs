using System.ComponentModel;

namespace VideoStore_Model.ViewModels
{
    public class ClientCardViewModel
    {
        [DisplayName("Идентификатор пользователя")]
        public int Id { get; set; }
        [DisplayName("ФИО")]
        public string FIO { get; set; }
        [DisplayName("Номер паспорта")]
        public string PassportNumber { get; set; }
        [DisplayName("Пени")]
        public int Penalties { get; set; }
        [DisplayName("Обращение")]
        public int Frequency { get; set; }
    }
}
