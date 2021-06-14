using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Uygulamasi
{
    class Colyak:HastlaikTur
    {
        Hastalik hastalik = new Hastalik();
        public override void HastalikTuru()
        {
            hastalik.Ad = "Colyak";

        }
        public override Hastalik HastalikOlustur()
        {
            return hastalik;
        }
    }
}
