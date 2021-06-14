using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Uygulamasi
{
    class GlutenFree:DiyetTur
    {
        Diyet diyet = new Diyet();
        public override void DiyetTuru()
        {
            diyet.Cesit = "Gluten Free";
        }
        public override Diyet DiyetOlustur()
        {
            return diyet;

        }
    }
}
