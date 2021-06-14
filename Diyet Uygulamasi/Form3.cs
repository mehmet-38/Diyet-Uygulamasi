using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Diyet_Uygulamasi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            
            
            listView1.Columns.Add("Hasta Ad", 75);
            listView1.Columns.Add("Hasta Soyad", 75);
            listView1.Columns.Add("Hastalığı", 75);
            listView1.Columns.Add("Diyet Yöntemi", 75);
            HastlaikVer hastalik1 = new HastlaikVer(new Obez());
            Hastalik hastalik_1 = hastalik1.HastalikVeri();
            comboBox1.Items.Add(hastalik_1.Ad);

            HastlaikVer hastalik2 = new HastlaikVer(new Colyak());
            Hastalik hastalik_2 = hastalik2.HastalikVeri();
            comboBox1.Items.Add(hastalik_2.Ad);

            HastlaikVer hastalik3 = new HastlaikVer(new Seker());
            Hastalik hastalik_3 = hastalik3.HastalikVeri();
            comboBox1.Items.Add(hastalik_3.Ad);

            DiyetVer diyet1 = new DiyetVer(new Yesillikler());
            Diyet diyet_1 = diyet1.DiyetVeri();
            comboBox2.Items.Add(diyet_1.Cesit);

            DiyetVer diyet2 = new DiyetVer(new GlutenFree());
            Diyet diyet_2 = diyet2.DiyetVeri();
            comboBox2.Items.Add(diyet_2.Cesit);

            DiyetVer diyet3 = new DiyetVer(new Akdeniz());
            Diyet diyet_3 = diyet3.DiyetVeri();
            comboBox2.Items.Add(diyet_3.Cesit);

            DiyetVer diyet4 = new DiyetVer(new DenizUrunleri());
            Diyet diyet_4 = diyet4.DiyetVeri();
            comboBox2.Items.Add(diyet_4.Cesit);


        }
         HastaBilgiler hasta = new HastaBilgiler();
        private void button1_Click(object sender, EventArgs e)
        {
            
            hasta.hastaAdi = textBox1.Text;
            hasta.hastaSoyadi = textBox2.Text;
            hasta.hastaTc = textBox3.Text;
            hasta.hastaHastalik = comboBox1.SelectedItem.ToString();
            MessageBox.Show("Hasta Bilgileri Kaydedilmiştir");
            

            textBox4.Text = textBox1.Text;
            textBox5.Text=comboBox1.SelectedItem.ToString();


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string ad = "", hastalik = "", diyet = "",soyad="";
            ad = textBox4.Text;
            soyad = textBox2.Text;
            hastalik = comboBox1.SelectedItem.ToString();
            diyet = comboBox2.SelectedItem.ToString();

            string[] bilgiler = { ad, soyad,hastalik, diyet };
            ListViewItem lst = new ListViewItem(bilgiler);
            listView1.Items.Add(lst);
           
            
        }
        RaporOlustur rapor = new RaporOlustur();

        private void button3_Click(object sender, EventArgs e)
        {
            
       
        rapor.hastaAdi = listView1.SelectedItems[0].SubItems[0].Text;
        rapor.hastaSoyadi = listView1.SelectedItems[0].SubItems[1].Text;
        rapor.hastaHastalik = listView1.SelectedItems[0].SubItems[2].Text;
        rapor.hastaDiyet = listView1.SelectedItems[0].SubItems[3].Text;
            rapor.raporOlustur();
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
            listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
            listView1.SelectedItems[0].SubItems[2].Text = comboBox1.SelectedItem.ToString();
            listView1.SelectedItems[0].SubItems[3].Text = comboBox2.SelectedItem.ToString();

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
             textBox4.Text= listView1.SelectedItems[0].SubItems[0].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBox2.SelectedItem= listView1.SelectedItems[0].SubItems[2].Text;
        }

        
    }
}
