using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace VideoStore_Model
{
    public class ClientCard
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FIO { get; set; }
        [DataMember]
        public string PassportNumber { get; set; }
        [DataMember]
        public int Penalties { get; set; }
        [DataMember]
        public int Frequency { get; set; }
        [ForeignKey("ClientId")]
        public virtual List<ClientContract> ClientContracts { get; set; }
    }
}
