namespace EtutOtomasyonu
{
    partial class Form5
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
            this.txtsınıf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtders = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.etutotomasyonuDataSet = new EtutOtomasyonu.etutotomasyonuDataSet();
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
            this.dataGridView1.Location = new System.Drawing.Point(26, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 268);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // txtsınıf
            // 
            this.txtsınıf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsınıf.Location = new System.Drawing.Point(429, 174);
            this.txtsınıf.Name = "txtsınıf";
            this.txtsınıf.Size = new System.Drawing.Size(228, 26);
            this.txtsınıf.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(516, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Sınıf";
            // 
            // txtders
            // 
            this.txtders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtders.Location = new System.Drawing.Point(429, 105);
            this.txtders.Name = "txtders";
            this.txtders.Size = new System.Drawing.Size(228, 26);
            this.txtders.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(516, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Ders";
            // 
            // txtadres
            // 
            this.txtadres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadres.Location = new System.Drawing.Point(429, 45);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(228, 26);
            this.txtadres.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(512, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Adres";
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttel.Location = new System.Drawing.Point(155, 174);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(228, 26);
            this.txttel.TabIndex = 32;
            this.txttel.TextChanged += new System.EventHandler(this.txttel_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(202, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Telefon Numarası";
            // 
            // txttc
            // 
            this.txttc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttc.Location = new System.Drawing.Point(155, 109);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(228, 26);
            this.txttc.TabIndex = 30;
            this.txttc.TextChanged += new System.EventHandler(this.txttc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(217, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tc Kimlik No";
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadsoyad.Location = new System.Drawing.Point(155, 45);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(228, 26);
            this.txtadsoyad.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(202, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Öğrenci Ad Soyad";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(292, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 43);
            this.button1.TabIndex = 39;
            this.button1.Text = "Öğrenci Güncelle";
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
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // etutotomasyonuDataSet
            // 
            this.etutotomasyonuDataSet.DataSetName = "etutotomasyonuDataSet";
            this.etutotomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oEklemetblBindingSource
            // 
            this.oEklemetblBindingSource.DataMember = "OEkleme_tbl";
            this.oEklemetblBindingSource.DataSource = this.etutotomasyonuDataSet;
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
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsınıf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtders);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Güncelle";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etutotomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oEklemetblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtsınıf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtders;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
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