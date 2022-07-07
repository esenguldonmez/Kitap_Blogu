using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class BList
    {
        [Key]
        public int BListID { get; set; }
        public string Title { get; set; }

        public int OkunanSayfaOranı { get; set; } // yüzdelik
        public int Value { get; set; } // okunan
        public int Sayfa { get; set; } //tamamı
       
    }
}
