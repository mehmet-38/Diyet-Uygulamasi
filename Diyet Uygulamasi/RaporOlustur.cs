using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Diyet_Uygulamasi
{
    public class RaporOlustur
    {
        public string hastaAdi;
        public string hastaSoyadi;
        public string hastaHastalik;
        public string hastaDiyet;
        public void raporOlustur()
        {
            string html = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:arial'>";

            //Adding HeaderRow.
            html += "<tr>";
            html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>Adı</th>";
            html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>Soyadı</th>";
            html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>Hastalığı</th>";
            html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>Diyet Türü</th>";
            html += "</tr>";

            //Adding DataRow.
            html += "<tr>";
            html += "<td style='width:120px;border: 1px solid #ccc'>" + hastaAdi + "</td>";
            html += "<td style='width:120px;border: 1px solid #ccc'>" + hastaSoyadi + "</td>";
            html += "<td style='width:120px;border: 1px solid #ccc'>" + hastaHastalik + "</td>";
            html += "<td style='width:120px;border: 1px solid #ccc'>" + hastaDiyet + "</td>";
            html += "</tr>";

            //Table end.
            html += "</table>";

            File.WriteAllText(@"C:\deneme\Rapor.htm", html);
        }

    }
}
