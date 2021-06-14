using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Uygulamasi
{
    class DiyetVer
    {
        private DiyetTur diyetTur;
        
        public DiyetVer(DiyetTur diyetTur)
        {
            this.diyetTur = diyetTur;
        }
        
        public Diyet DiyetVeri()
        {
            this.diyetTur.DiyetTuru();
            return this.diyetTur.DiyetOlustur();
        }

    }
}
