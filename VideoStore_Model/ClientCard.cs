using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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
