using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.UI.Common
{
    public  class Musteri
    {
        public string TC { get; set; }
        public string NameSurname { get; set; }
        public string  PhoneNumber { get; set; }
        public string DateOfBirth { get; set; }
        public int KalacakGunSayisi { get; set; }
        public Oda OdaBilgisi { get; set; }
        public Minibar MinibarBilgisi { get; set; }






        public override string ToString()
        {
            return NameSurname + " ";
        }


    }
}
