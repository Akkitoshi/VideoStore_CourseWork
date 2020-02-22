using System.ComponentModel;

namespace VideoStore_Model.ViewModels
{
    public class ClientCardViewModel
    {
       
        public int Id { get; set; }
       
        public string FIO { get; set; }
        public string PassportNumber { get; set; }
        public int Penalties { get; set; }
        public int Frequency { get; set; }
    }
}
