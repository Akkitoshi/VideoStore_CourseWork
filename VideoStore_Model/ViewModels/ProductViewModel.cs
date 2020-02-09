using System.ComponentModel;

namespace VideoStore_Model.ViewModels
{
    public class ProductViewModel
    {
        
        public int Id { get; set; }
        [DisplayName("Тип продукта")]
        public string Type { get; set; }
        [DisplayName("Цена")]
        public int Price { get; set; }
        public int ClientContractId { get; set; }
    }
}
