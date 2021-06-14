using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Uygulamasi
{
    class Seker:HastlaikTur
    {
        Hastalik hastalik = new Hastalik();
        public override void HastalikTuru()
        {
            hastalik.Ad = "Seker";

        }
        public override Hastalik HastalikOlustur()
        {
            return hastalik;
        }
    }
}
