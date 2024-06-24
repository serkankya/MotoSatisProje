namespace MotoSatisProje
{
	partial class CalisanKayit
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
			this.txtAd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTelefon = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.dgwCalisanlar = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.txtAranacakKelime = new System.Windows.Forms.TextBox();
			this.cmbPozisyon = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgwCalisanlar)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(107, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ad : ";
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(179, 42);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(100, 20);
			this.txtAd.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(107, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Soyad";
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(179, 68);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(100, 20);
			this.txtSoyad.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(107, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Pozisyon";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(107, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Telefon";
			// 
			// txtTelefon
			// 
			this.txtTelefon.Location = new System.Drawing.Point(179, 122);
			this.txtTelefon.Name = "txtTelefon";
			this.txtTelefon.Size = new System.Drawing.Size(100, 20);
			this.txtTelefon.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(107, 157);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Mail";
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(179, 154);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(100, 20);
			this.txtMail.TabIndex = 1;
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(194, 189);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(75, 23);
			this.btnKaydet.TabIndex = 2;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(194, 218);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
			this.btnGuncelle.TabIndex = 3;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(194, 256);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(75, 23);
			this.btnSil.TabIndex = 4;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// dgwCalisanlar
			// 
			this.dgwCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwCalisanlar.Location = new System.Drawing.Point(343, 42);
			this.dgwCalisanlar.Name = "dgwCalisanlar";
			this.dgwCalisanlar.Size = new System.Drawing.Size(408, 237);
			this.dgwCalisanlar.TabIndex = 5;
			this.dgwCalisanlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCalisanlar_CellClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(453, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Ara";
			// 
			// txtAranacakKelime
			// 
			this.txtAranacakKelime.Location = new System.Drawing.Point(482, 16);
			this.txtAranacakKelime.Name = "txtAranacakKelime";
			this.txtAranacakKelime.Size = new System.Drawing.Size(100, 20);
			this.txtAranacakKelime.TabIndex = 1;
			this.txtAranacakKelime.TextChanged += new System.EventHandler(this.txtAranacakKelime_TextChanged);
			// 
			// cmbPozisyon
			// 
			this.cmbPozisyon.FormattingEnabled = true;
			this.cmbPozisyon.Items.AddRange(new object[] {
            "Müdür",
            "Mağaza Sorumlusu",
            "Satış Sorumlusu",
            "Kasiyer"});
			this.cmbPozisyon.Location = new System.Drawing.Point(179, 94);
			this.cmbPozisyon.Name = "cmbPozisyon";
			this.cmbPozisyon.Size = new System.Drawing.Size(121, 21);
			this.cmbPozisyon.TabIndex = 6;
			// 
			// CalisanKayit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cmbPozisyon);
			this.Controls.Add(this.dgwCalisanlar);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.txtTelefon);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtSoyad);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtAranacakKelime);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.label1);
			this.Name = "CalisanKayit";
			this.Text = "CalisanKayit";
			this.Load += new System.EventHandler(this.CalisanKayit_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwCalisanlar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSoyad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTelefon;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMail;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.DataGridView dgwCalisanlar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtAranacakKelime;
		private System.Windows.Forms.ComboBox cmbPozisyon;
	}
}