using System;
using System.Runtime.Serialization;

namespace VideoStore_Model
{
    public class ClientContract
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int ClientId { get; set; }
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public int ServiceId { get; set; }
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public int ProductAmount { get; set; }
        [DataMember]
        public int SummaryPrice { get; set; }
        [DataMember]
        public DateTime DateOfConclusion { get; set; }
        [DataMember]
        public DateTime RentalPeriodEnd { get; set; }
        [DataMember]
        public DateTime? ReturnDate { get; set; }
        public virtual ClientCard ClientCard { get; set; }
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
        public virtual Service Service { get; set; }
    }
}
