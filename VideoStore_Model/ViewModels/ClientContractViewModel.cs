using System;
using System.ComponentModel;

namespace VideoStore_Model.ViewModels
{
    public class ClientContractViewModel
    {

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public int ServiceId { get; set; }
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
