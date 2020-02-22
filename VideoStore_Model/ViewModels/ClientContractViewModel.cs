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

        public int ProductAmount { get; set; }

        public int SummaryPrice { get; set; }

        public DateTime DateOfConclusion { get; set; }

        public DateTime RentalPeriodEnd { get; set; }

        public DateTime? ReturnDate { get; set; }
    }
}
