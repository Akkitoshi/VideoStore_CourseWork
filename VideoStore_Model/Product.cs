﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace VideoStore_Model
{
    public class Product
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public int? CountContracts { get; set; }

        [ForeignKey("ProductId")]
        public virtual List<ClientContract> ClientContracts { get; set; }
    }
}
