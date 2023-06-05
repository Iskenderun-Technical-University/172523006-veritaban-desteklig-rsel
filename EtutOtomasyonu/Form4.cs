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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        EtutOtomasyonuEntities db = new EtutOtomasyonuEntities();
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'etutotomasyonuDataSet.OEkleme_tbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oEkleme_tblTableAdapter.Fill(this.etutotomasyonuDataSet.OEkleme_tbl);
            dataGridView1.DataSource = db.tblogrencı.ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var sil = db.tblogrencı.Find(id);
            db.tblogrencı.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Öğrenci silme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = db.tblogrencı.ToList();
        }
    }
}
