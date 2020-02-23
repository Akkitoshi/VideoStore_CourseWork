using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace VideoStore_Model
{
    public class User
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FIO { get; set; }
        [DataMember]
        public string Role { get; set; }
        [DataMember]
        public string Position { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }

        [ForeignKey("UserId")]
        public virtual List<ClientContract> ClientContracts { get; set; }
    }
}
