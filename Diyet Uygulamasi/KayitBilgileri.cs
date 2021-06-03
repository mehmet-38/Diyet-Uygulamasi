using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Uygulamasi
{
    public class KayitBilgileri
    {
        public ulong TCKimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime KayıtTarihi { get; set; }

        public string KayitBilgisiOlustur()
        {
            string bilgi = "Tc: " + TCKimlikNo.ToString() +
                           "\nAd: " + Ad +
                           "\nSoyad: " + Soyad +
                           "\nKayıt Tarihi: " + KayıtTarihi.ToShortDateString();
            return bilgi;
        }
    }
}
