using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diyet_Uygulamasi
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
             
            InitializeComponent();
            
        }

        

        public Form2 form2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            if (adminAd.Text =="admin"&& adminSifre.Text=="12345")
            {
                form2.Show();
                this.Hide();
            }
        }
       public string diyetisyenAdi;
        public string diyetisyenSifresi;
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            if (diyetisyenAdi==diyetisyenGirisAd.Text && diyetisyenSifresi==diyetisyenGirisSifre.Text)
            {
                form3.Show();
                this.Hide();
            }
        }

        
    }
}
