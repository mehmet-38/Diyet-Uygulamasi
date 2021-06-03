using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Uygulamasi
{
    class Tedavi
    {
        public void tedaviEt(HastalikBuilder builder)
        {
            builder.SetHastalikAdi();
            builder.SetHastalikTipi();
        }
    }
}
