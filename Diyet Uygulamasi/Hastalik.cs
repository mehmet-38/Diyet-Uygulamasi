using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Uygulamasi
{
    enum HastalikTipi
    {
        Diyet
    }
    //product
    class Hastalik
    {
        public HastalikTipi HastalikTipi { get; set; }
        public string HastalikAdi { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
