using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore_Model.ViewModels
{
    public class ServicesViewModel
    {
        [DisplayName("Идентификатор сервиса")]
        public int Id { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }
    }
}
