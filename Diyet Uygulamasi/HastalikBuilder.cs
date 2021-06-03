using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Uygulamasi
{
    //Builder Class
    abstract class HastalikBuilder
    {
        protected Hastalik hastalik;
        public Hastalik Hastalik
        {
            get
            {
                return hastalik;
            }
        }
        abstract public void SetHastalikTipi();
        abstract public void SetHastalikAdi();
    }
}
