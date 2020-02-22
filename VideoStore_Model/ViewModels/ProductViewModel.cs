using System.ComponentModel;

namespace VideoStore_Model.ViewModels
{
    public class ProductViewModel
    {

        public int Id { get; set; }

        public string Name { get; set; }


        public string Type { get; set; }

        public int Price { get; set; }

        public int? CountContracts { get; set; }
    }
}
