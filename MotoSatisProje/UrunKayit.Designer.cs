namespace MotoSatisProje
{
	partial class UrunKayit
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtUrunAdi = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAciklama = new System.Windows.Forms.TextBox();
			this.numFiyat = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.numStok = new System.Windows.Forms.NumericUpDown();
			this.cmbToptanci = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.dgwUrunler = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.txtAranacakKelime = new System.Windows.Forms.TextBox();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numFiyat)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numStok)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ürün Adı :  ";
			// 
			// txtUrunAdi
			// 
			this.txtUrunAdi.Location = new System.Drawing.Point(80, 30);
			this.txtUrunAdi.Name = "txtUrunAdi";
			this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
			this.txtUrunAdi.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Açıklama : ";
			// 
			// txtAciklama
			// 
			this.txtAciklama.Location = new System.Drawing.Point(80, 56);
			this.txtAciklama.Multiline = true;
			this.txtAciklama.Name = "txtAciklama";
			this.txtAciklama.Size = new System.Drawing.Size(100, 130);
			this.txtAciklama.TabIndex = 1;
			// 
			// numFiyat
			// 
			this.numFiyat.DecimalPlaces = 2;
			this.numFiyat.Location = new System.Drawing.Point(80, 201);
			this.numFiyat.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.numFiyat.Name = "numFiyat";
			this.numFiyat.Size = new System.Drawing.Size(120, 20);
			this.numFiyat.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 203);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Fiyat ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 241);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Stok";
			// 
			// numStok
			// 
			this.numStok.Location = new System.Drawing.Point(80, 239);
			this.numStok.Name = "numStok";
			this.numStok.Size = new System.Drawing.Size(120, 20);
			this.numStok.TabIndex = 2;
			// 
			// cmbToptanci
			// 
			this.cmbToptanci.FormattingEnabled = true;
			this.cmbToptanci.Location = new System.Drawing.Point(80, 287);
			this.cmbToptanci.Name = "cmbToptanci";
			this.cmbToptanci.Size = new System.Drawing.Size(121, 21);
			this.cmbToptanci.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 290);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Toptancı ";
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(105, 323);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(75, 23);
			this.btnKaydet.TabIndex = 4;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// dgwUrunler
			// 
			this.dgwUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwUrunler.Location = new System.Drawing.Point(259, 56);
			this.dgwUrunler.Name = "dgwUrunler";
			this.dgwUrunler.Size = new System.Drawing.Size(529, 316);
			this.dgwUrunler.TabIndex = 5;
			this.dgwUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUrunler_CellClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(456, 29);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Ara : ";
			// 
			// txtAranacakKelime
			// 
			this.txtAranacakKelime.Location = new System.Drawing.Point(494, 26);
			this.txtAranacakKelime.Name = "txtAranacakKelime";
			this.txtAranacakKelime.Size = new System.Drawing.Size(100, 20);
			this.txtAranacakKelime.TabIndex = 6;
			this.txtAranacakKelime.TextChanged += new System.EventHandler(this.txtAranacakKelime_TextChanged);
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(105, 352);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(75, 23);
			this.btnSil.TabIndex = 8;
			this.btnSil.Text = "Ürünü Sil";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(105, 381);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
			this.btnGuncelle.TabIndex = 9;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// UrunKayit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtAranacakKelime);
			this.Controls.Add(this.dgwUrunler);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.cmbToptanci);
			this.Controls.Add(this.numStok);
			this.Controls.Add(this.numFiyat);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtAciklama);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUrunAdi);
			this.Controls.Add(this.label1);
			this.Name = "UrunKayit";
			this.Text = "UrunKayit";
			this.Load += new System.EventHandler(this.UrunKayit_Load);
			((System.ComponentModel.ISupportInitialize)(this.numFiyat)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numStok)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUrunAdi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAciklama;
		private System.Windows.Forms.NumericUpDown numFiyat;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numStok;
		private System.Windows.Forms.ComboBox cmbToptanci;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.DataGridView dgwUrunler;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtAranacakKelime;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnGuncelle;
	}
}