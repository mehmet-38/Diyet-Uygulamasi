using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Uygulamasi
{
    class ObezConcreteBuilder : HastalikBuilder
    {
        public ObezConcreteBuilder()
        {
            hastalik = new Hastalik();
        }
        public override void SetHastalikAdi() => hastalik.HastalikAdi = "Obez";
        public override void SetHastalikTipi() => hastalik.HastalikTipi = HastalikTipi.Diyet;
    }

    class SekerConcreteBuilder : HastalikBuilder
    {
    public SekerConcreteBuilder()
        {
            hastalik = new Hastalik();
        }
        public override void SetHastalikAdi() => hastalik.HastalikAdi = "Seker";
        public override void SetHastalikTipi() => hastalik.HastalikTipi = HastalikTipi.Diyet;

    }

    class ColyakConcreteBuilder : HastalikBuilder
    {
    public ColyakConcreteBuilder()
        {
            hastalik = new Hastalik();
        }
        public override void SetHastalikAdi() => hastalik.HastalikAdi = "Colyak";
        public override void SetHastalikTipi() => hastalik.HastalikTipi = HastalikTipi.Diyet;

    }
}
