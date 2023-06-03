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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EtutOtomasyonuEntities db = new EtutOtomasyonuEntities();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tblgiriş giriş = db.tblgiriş.Where(x => x.kullanıcıadı == txtkullaniciadi.Text && x.şifre == txtsifre.Text).SingleOrDefault();
            if (giriş != null)
            {
                Form2 frm = new Form2();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Yanlış Bilgi.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
