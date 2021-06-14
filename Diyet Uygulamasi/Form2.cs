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
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
        }

        
       
        private void button1_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            
            form1.diyetisyenAdi = diyetisyenAd.Text;
            form1.diyetisyenSifresi = diyetisyenSifre.Text;
            form1.Show();
           form1.tabControl1.SelectedTab= form1.tabControl1.TabPages["tabPage2"];
            
            this.Hide();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
