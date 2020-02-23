using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace VideoStore_Model
{
    public class Service
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }

        [ForeignKey("ServiceId")]
        public virtual List<ClientContract> ClientContracts { get; set; }
    }
}
