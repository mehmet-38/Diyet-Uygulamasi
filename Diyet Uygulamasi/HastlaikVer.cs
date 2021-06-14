using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Uygulamasi
{
    class HastlaikVer
    {
        private HastlaikTur hastalikTur;
        
        public HastlaikVer(HastlaikTur hastalikTur)
        {
            this.hastalikTur = hastalikTur;
        }
        
        public Hastalik HastalikVeri()
        {
            this.hastalikTur.HastalikTuru();
            return this.hastalikTur.HastalikOlustur();
        }
    }
}
