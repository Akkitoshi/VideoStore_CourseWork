using System.ComponentModel;

namespace VideoStore_Model.ViewModels
{
    public class ProductViewModel
    {
        [DisplayName("Идентификатор продукта")]
        public int Id { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }

        [DisplayName("Тип продукта")]
        public string Type { get; set; }
        [DisplayName("Цена")]
        public int Price { get; set; }
    }
}
