using System;
using System.ComponentModel;

namespace VideoStore_Model.ViewModels
{
    public class ClientContractViewModel
    {
        [DisplayName("Идентификатор договора")]
        public int Id { get; set; }
        [DisplayName("Идентификатор клиента")]
        public int ClientId { get; set; }
        [DisplayName("Идентификатор продавца-консультанта")]
        public int UserId { get; set; }
        [DisplayName("Идентификатор сервиса")]
        public int ServiceId { get; set; }
        [DisplayName("Идентификатор товара")]
        public int ProductId { get; set; }
        [DisplayName("Количество")]
        public int ProductAmount { get; set; }
        [DisplayName("Сумма")]
        public int SummaryPrice { get; set; }
        [DisplayName("Дата заключения")]
        public DateTime DateOfConclusion { get; set; }
        [DisplayName("Окончание срока проката")]
        public DateTime RentalPeriodEnd { get; set; }
        [DisplayName("Дата возврата")]
        public DateTime ReturnDate { get; set; }
    }
}
