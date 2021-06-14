using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Uygulamasi
{
    class Yesillikler : DiyetTur
    {
        Diyet diyet = new Diyet();
        public override void DiyetTuru()
        {
            diyet.Cesit = "Yesillikler";
        }
        public override Diyet DiyetOlustur()
        {
            return diyet;

        }
    }
}
