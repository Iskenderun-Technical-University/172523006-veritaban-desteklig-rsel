using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtutOtomasyonu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        EtutOtomasyonuEntities db = new EtutOtomasyonuEntities();
        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtadsoyad.Text == "" || txttc.Text == "" || txttel.Text == "" || txtadres.Text == "" || txtders.Text == "" || txtsınıf.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                tblogrencı ogrencı = new tblogrencı();
                ogrencı.adsoyad = txtadsoyad.Text;
                ogrencı.tc = txttc.Text;
                ogrencı.tel = txttel.Text;
                ogrencı.adres = txtadres.Text;
                ogrencı.ders = txtders.Text;
                ogrencı.sınıf = txtsınıf.Text;
                db.tblogrencı.Add(ogrencı);
                db.SaveChanges();
                MessageBox.Show("Öğrenci kaydı başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {
            txttc.MaxLength = 11;
        }

        private void txttel_TextChanged(object sender, EventArgs e)
        {
            txttel.MaxLength = 11;
        }
    }
}
