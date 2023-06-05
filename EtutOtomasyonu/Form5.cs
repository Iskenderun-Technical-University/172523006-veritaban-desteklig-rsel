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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        EtutOtomasyonuEntities db = new EtutOtomasyonuEntities();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'etutotomasyonuDataSet.OEkleme_tbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oEkleme_tblTableAdapter.Fill(this.etutotomasyonuDataSet.OEkleme_tbl);
            dataGridView1.DataSource = db.tblogrencı.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtadsoyad.Text == "" || txttc.Text == "" || txttel.Text == "" || txtadres.Text == "" || txtders.Text == "" || txtsınıf.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var ogrencı = db.tblogrencı.Find(id);
                ogrencı.adsoyad = txtadsoyad.Text;
                ogrencı.tc = txttc.Text;
                ogrencı.tel = txttel.Text;
                ogrencı.adres = txtadres.Text;
                ogrencı.ders = txtders.Text;
                ogrencı.sınıf = txtsınıf.Text;
                db.SaveChanges();
                dataGridView1.DataSource = db.tblogrencı.ToList();
                MessageBox.Show("Öğrenci güncelleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtadsoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txttc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txttel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtders.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtsınıf.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
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
