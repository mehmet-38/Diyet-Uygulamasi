﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Uygulamasi
{
    class DenizUrunleri : DiyetTur
    {
        Diyet diyet = new Diyet();
        public override void DiyetTuru()
        {
            diyet.Cesit = "Deniz Urunleri";
        }
        public override Diyet DiyetOlustur()
        {
            return diyet;

        }
    }
}
