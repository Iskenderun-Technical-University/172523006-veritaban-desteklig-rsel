namespace EtutOtomasyonu
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.etutotomasyonuDataSet = new EtutOtomasyonu.etutotomasyonuDataSet();
            this.etutotomasyonuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oEklemetblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oEkleme_tblTableAdapter = new EtutOtomasyonu.etutotomasyonuDataSetTableAdapters.OEkleme_tblTableAdapter();
            this.ogrenciidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tckimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etutotomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etutotomasyonuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oEklemetblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciidDataGridViewTextBoxColumn,
            this.ogrenciadiDataGridViewTextBoxColumn,
            this.tckimlikDataGridViewTextBoxColumn,
            this.telefonnoDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.dersidDataGridViewTextBoxColumn,
            this.sinifidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oEklemetblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 251);
            this.dataGridView1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(322, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 43);
            this.button1.TabIndex = 26;
            this.button1.Text = "Öğrenci Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EtutOtomasyonu.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // etutotomasyonuDataSet
            // 
            this.etutotomasyonuDataSet.DataSetName = "etutotomasyonuDataSet";
            this.etutotomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etutotomasyonuDataSetBindingSource
            // 
            this.etutotomasyonuDataSetBindingSource.DataSource = this.etutotomasyonuDataSet;
            this.etutotomasyonuDataSetBindingSource.Position = 0;
            // 
            // oEklemetblBindingSource
            // 
            this.oEklemetblBindingSource.DataMember = "OEkleme_tbl";
            this.oEklemetblBindingSource.DataSource = this.etutotomasyonuDataSetBindingSource;
            // 
            // oEkleme_tblTableAdapter
            // 
            this.oEkleme_tblTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciidDataGridViewTextBoxColumn
            // 
            this.ogrenciidDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_id";
            this.ogrenciidDataGridViewTextBoxColumn.HeaderText = "ogrenci_id";
            this.ogrenciidDataGridViewTextBoxColumn.Name = "ogrenciidDataGridViewTextBoxColumn";
            // 
            // ogrenciadiDataGridViewTextBoxColumn
            // 
            this.ogrenciadiDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_adi";
            this.ogrenciadiDataGridViewTextBoxColumn.HeaderText = "ogrenci_adi";
            this.ogrenciadiDataGridViewTextBoxColumn.Name = "ogrenciadiDataGridViewTextBoxColumn";
            // 
            // tckimlikDataGridViewTextBoxColumn
            // 
            this.tckimlikDataGridViewTextBoxColumn.DataPropertyName = "tc_kimlik";
            this.tckimlikDataGridViewTextBoxColumn.HeaderText = "tc_kimlik";
            this.tckimlikDataGridViewTextBoxColumn.Name = "tckimlikDataGridViewTextBoxColumn";
            // 
            // telefonnoDataGridViewTextBoxColumn
            // 
            this.telefonnoDataGridViewTextBoxColumn.DataPropertyName = "telefon_no";
            this.telefonnoDataGridViewTextBoxColumn.HeaderText = "telefon_no";
            this.telefonnoDataGridViewTextBoxColumn.Name = "telefonnoDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // dersidDataGridViewTextBoxColumn
            // 
            this.dersidDataGridViewTextBoxColumn.DataPropertyName = "ders_id";
            this.dersidDataGridViewTextBoxColumn.HeaderText = "ders_id";
            this.dersidDataGridViewTextBoxColumn.Name = "dersidDataGridViewTextBoxColumn";
            // 
            // sinifidDataGridViewTextBoxColumn
            // 
            this.sinifidDataGridViewTextBoxColumn.DataPropertyName = "sinif_id";
            this.sinifidDataGridViewTextBoxColumn.HeaderText = "sinif_id";
            this.sinifidDataGridViewTextBoxColumn.Name = "sinifidDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Sil";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etutotomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etutotomasyonuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oEklemetblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource etutotomasyonuDataSetBindingSource;
        private etutotomasyonuDataSet etutotomasyonuDataSet;
        private System.Windows.Forms.BindingSource oEklemetblBindingSource;
        private etutotomasyonuDataSetTableAdapters.OEkleme_tblTableAdapter oEkleme_tblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tckimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifidDataGridViewTextBoxColumn;
    }
}