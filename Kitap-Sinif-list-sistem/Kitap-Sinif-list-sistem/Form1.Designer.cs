namespace Kitap_Sinif_list_sistem
{
    partial class Form1
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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.chkCilt = new System.Windows.Forms.CheckBox();
            this.dtpBasimTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblSayfaSayisi = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.lblBasimTarihi = new System.Windows.Forms.Label();
            this.grbKitapBilgileri = new System.Windows.Forms.GroupBox();
            this.dgvKitap = new System.Windows.Forms.DataGridView();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.lblTur = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.grbKitapBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Silver;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = global::Kitap_Sinif_list_sistem.Properties.Resources._3sil;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.Location = new System.Drawing.Point(369, 111);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 69);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Silver;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Image = global::Kitap_Sinif_list_sistem.Properties.Resources._1_ekle;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncelle.Location = new System.Drawing.Point(467, 111);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(80, 69);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Silver;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.Image = global::Kitap_Sinif_list_sistem.Properties.Resources._2v_ekle;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEkle.Location = new System.Drawing.Point(273, 111);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 69);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(71, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 16);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id:";
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapAdi.ForeColor = System.Drawing.Color.Black;
            this.lblKitapAdi.Location = new System.Drawing.Point(26, 59);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(73, 16);
            this.lblKitapAdi.TabIndex = 4;
            this.lblKitapAdi.Text = "Kitap Adı:";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazar.ForeColor = System.Drawing.Color.Black;
            this.lblYazar.Location = new System.Drawing.Point(47, 89);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(51, 16);
            this.lblYazar.TabIndex = 5;
            this.lblYazar.Text = "Yazar:";
            // 
            // chkCilt
            // 
            this.chkCilt.AutoSize = true;
            this.chkCilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkCilt.Location = new System.Drawing.Point(376, 30);
            this.chkCilt.Name = "chkCilt";
            this.chkCilt.Size = new System.Drawing.Size(48, 20);
            this.chkCilt.TabIndex = 7;
            this.chkCilt.Text = "Cilt";
            this.chkCilt.UseVisualStyleBackColor = true;
            // 
            // dtpBasimTarihi
            // 
            this.dtpBasimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBasimTarihi.Location = new System.Drawing.Point(376, 54);
            this.dtpBasimTarihi.Name = "dtpBasimTarihi";
            this.dtpBasimTarihi.Size = new System.Drawing.Size(171, 22);
            this.dtpBasimTarihi.TabIndex = 8;
            // 
            // lblSayfaSayisi
            // 
            this.lblSayfaSayisi.AutoSize = true;
            this.lblSayfaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayfaSayisi.ForeColor = System.Drawing.Color.Black;
            this.lblSayfaSayisi.Location = new System.Drawing.Point(6, 116);
            this.lblSayfaSayisi.Name = "lblSayfaSayisi";
            this.lblSayfaSayisi.Size = new System.Drawing.Size(98, 16);
            this.lblSayfaSayisi.TabIndex = 9;
            this.lblSayfaSayisi.Text = "Sayfa Sayısı:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(102, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 21);
            this.txtId.TabIndex = 10;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(102, 53);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(121, 21);
            this.txtKitapAdi.TabIndex = 11;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(102, 84);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(121, 21);
            this.txtYazar.TabIndex = 12;
            // 
            // lblBasimTarihi
            // 
            this.lblBasimTarihi.AutoSize = true;
            this.lblBasimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBasimTarihi.Location = new System.Drawing.Point(278, 58);
            this.lblBasimTarihi.Name = "lblBasimTarihi";
            this.lblBasimTarihi.Size = new System.Drawing.Size(98, 16);
            this.lblBasimTarihi.TabIndex = 14;
            this.lblBasimTarihi.Text = "Basım Tarihi:";
            // 
            // grbKitapBilgileri
            // 
            this.grbKitapBilgileri.BackColor = System.Drawing.Color.Silver;
            this.grbKitapBilgileri.Controls.Add(this.cmbTur);
            this.grbKitapBilgileri.Controls.Add(this.lblTur);
            this.grbKitapBilgileri.Controls.Add(this.txtSayfaSayisi);
            this.grbKitapBilgileri.Controls.Add(this.btnEkle);
            this.grbKitapBilgileri.Controls.Add(this.lblBasimTarihi);
            this.grbKitapBilgileri.Controls.Add(this.btnGuncelle);
            this.grbKitapBilgileri.Controls.Add(this.btnSil);
            this.grbKitapBilgileri.Controls.Add(this.txtYazar);
            this.grbKitapBilgileri.Controls.Add(this.lblId);
            this.grbKitapBilgileri.Controls.Add(this.txtKitapAdi);
            this.grbKitapBilgileri.Controls.Add(this.lblKitapAdi);
            this.grbKitapBilgileri.Controls.Add(this.txtId);
            this.grbKitapBilgileri.Controls.Add(this.lblYazar);
            this.grbKitapBilgileri.Controls.Add(this.lblSayfaSayisi);
            this.grbKitapBilgileri.Controls.Add(this.dtpBasimTarihi);
            this.grbKitapBilgileri.Controls.Add(this.chkCilt);
            this.grbKitapBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKitapBilgileri.ForeColor = System.Drawing.Color.Black;
            this.grbKitapBilgileri.Location = new System.Drawing.Point(12, 3);
            this.grbKitapBilgileri.Name = "grbKitapBilgileri";
            this.grbKitapBilgileri.Size = new System.Drawing.Size(776, 217);
            this.grbKitapBilgileri.TabIndex = 15;
            this.grbKitapBilgileri.TabStop = false;
            this.grbKitapBilgileri.Text = "Kitap Bilgileri";
            // 
            // dgvKitap
            // 
            this.dgvKitap.AllowUserToAddRows = false;
            this.dgvKitap.AllowUserToDeleteRows = false;
            this.dgvKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKitap.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitap.Location = new System.Drawing.Point(12, 235);
            this.dgvKitap.Name = "dgvKitap";
            this.dgvKitap.ReadOnly = true;
            this.dgvKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitap.Size = new System.Drawing.Size(776, 203);
            this.dgvKitap.TabIndex = 16;
            this.dgvKitap.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKitap_CellEnter);
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(103, 111);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(120, 21);
            this.txtSayfaSayisi.TabIndex = 15;
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTur.ForeColor = System.Drawing.Color.Black;
            this.lblTur.Location = new System.Drawing.Point(62, 151);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(34, 16);
            this.lblTur.TabIndex = 16;
            this.lblTur.Text = "Tür:";
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Kurgu",
            "Bilim kurgu",
            "Polisiye",
            "Roman",
            "Aksiyon",
            "Macera",
            "Fantastik",
            "Gerilim",
            "Gizem",
            "Destan",
            "Animasyon",
            "Komedi",
            "Belgesel",
            "Dram",
            "Sürükleyici"});
            this.cmbTur.Location = new System.Drawing.Point(102, 144);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(121, 23);
            this.cmbTur.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKitap);
            this.Controls.Add(this.grbKitapBilgileri);
            this.Name = "Form1";
            this.Text = "Kitap Bilgileri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbKitapBilgileri.ResumeLayout(false);
            this.grbKitapBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.CheckBox chkCilt;
        private System.Windows.Forms.DateTimePicker dtpBasimTarihi;
        private System.Windows.Forms.Label lblSayfaSayisi;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label lblBasimTarihi;
        private System.Windows.Forms.GroupBox grbKitapBilgileri;
        private System.Windows.Forms.DataGridView dgvKitap;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Label lblTur;
    }
}

