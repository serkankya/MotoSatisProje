namespace MotoSatisProje
{
	partial class SatisYap
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
			this.grpMusteriler = new System.Windows.Forms.GroupBox();
			this.btnMusteriIptal = new System.Windows.Forms.Button();
			this.btnMusteriKayit = new System.Windows.Forms.Button();
			this.txtMusteriAdres = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMusteriMail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtMusteriTelefon = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMusteriAd = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.grpSatislar = new System.Windows.Forms.GroupBox();
			this.btnMusteriBul = new System.Windows.Forms.Button();
			this.btnIptalEt = new System.Windows.Forms.Button();
			this.btnSatisYap = new System.Windows.Forms.Button();
			this.lblToplamTutar = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.numAdet = new System.Windows.Forms.NumericUpDown();
			this.cmbSatisTur = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.cmbCalisanlar = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbUrunler = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.grpMusteriler.SuspendLayout();
			this.grpSatislar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
			this.SuspendLayout();
			// 
			// grpMusteriler
			// 
			this.grpMusteriler.Controls.Add(this.btnMusteriIptal);
			this.grpMusteriler.Controls.Add(this.btnMusteriKayit);
			this.grpMusteriler.Controls.Add(this.txtMusteriAdres);
			this.grpMusteriler.Controls.Add(this.label5);
			this.grpMusteriler.Controls.Add(this.txtMusteriMail);
			this.grpMusteriler.Controls.Add(this.label4);
			this.grpMusteriler.Controls.Add(this.txtMusteriTelefon);
			this.grpMusteriler.Controls.Add(this.label3);
			this.grpMusteriler.Controls.Add(this.txtMusteriSoyad);
			this.grpMusteriler.Controls.Add(this.label2);
			this.grpMusteriler.Controls.Add(this.txtMusteriAd);
			this.grpMusteriler.Controls.Add(this.label1);
			this.grpMusteriler.Location = new System.Drawing.Point(12, 12);
			this.grpMusteriler.Name = "grpMusteriler";
			this.grpMusteriler.Size = new System.Drawing.Size(351, 380);
			this.grpMusteriler.TabIndex = 0;
			this.grpMusteriler.TabStop = false;
			this.grpMusteriler.Text = "Müşteri Bilgileri";
			// 
			// btnMusteriIptal
			// 
			this.btnMusteriIptal.Location = new System.Drawing.Point(155, 339);
			this.btnMusteriIptal.Name = "btnMusteriIptal";
			this.btnMusteriIptal.Size = new System.Drawing.Size(75, 23);
			this.btnMusteriIptal.TabIndex = 6;
			this.btnMusteriIptal.Text = "İptal Et";
			this.btnMusteriIptal.UseVisualStyleBackColor = true;
			// 
			// btnMusteriKayit
			// 
			this.btnMusteriKayit.Location = new System.Drawing.Point(101, 310);
			this.btnMusteriKayit.Name = "btnMusteriKayit";
			this.btnMusteriKayit.Size = new System.Drawing.Size(199, 23);
			this.btnMusteriKayit.TabIndex = 2;
			this.btnMusteriKayit.Text = "Müşteriyi Kaydet";
			this.btnMusteriKayit.UseVisualStyleBackColor = true;
			this.btnMusteriKayit.Click += new System.EventHandler(this.btnMusteriKayit_Click);
			// 
			// txtMusteriAdres
			// 
			this.txtMusteriAdres.Location = new System.Drawing.Point(101, 195);
			this.txtMusteriAdres.Multiline = true;
			this.txtMusteriAdres.Name = "txtMusteriAdres";
			this.txtMusteriAdres.Size = new System.Drawing.Size(199, 100);
			this.txtMusteriAdres.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 198);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Adres : ";
			// 
			// txtMusteriMail
			// 
			this.txtMusteriMail.Location = new System.Drawing.Point(101, 147);
			this.txtMusteriMail.Name = "txtMusteriMail";
			this.txtMusteriMail.Size = new System.Drawing.Size(199, 20);
			this.txtMusteriMail.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Mail : ";
			// 
			// txtMusteriTelefon
			// 
			this.txtMusteriTelefon.Location = new System.Drawing.Point(101, 105);
			this.txtMusteriTelefon.Name = "txtMusteriTelefon";
			this.txtMusteriTelefon.Size = new System.Drawing.Size(199, 20);
			this.txtMusteriTelefon.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Telefon : ";
			// 
			// txtMusteriSoyad
			// 
			this.txtMusteriSoyad.Location = new System.Drawing.Point(101, 65);
			this.txtMusteriSoyad.Name = "txtMusteriSoyad";
			this.txtMusteriSoyad.Size = new System.Drawing.Size(199, 20);
			this.txtMusteriSoyad.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Müşteri Soyadı";
			// 
			// txtMusteriAd
			// 
			this.txtMusteriAd.Location = new System.Drawing.Point(101, 28);
			this.txtMusteriAd.Name = "txtMusteriAd";
			this.txtMusteriAd.Size = new System.Drawing.Size(199, 20);
			this.txtMusteriAd.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Müşteri Adı";
			// 
			// grpSatislar
			// 
			this.grpSatislar.Controls.Add(this.btnMusteriBul);
			this.grpSatislar.Controls.Add(this.btnIptalEt);
			this.grpSatislar.Controls.Add(this.btnSatisYap);
			this.grpSatislar.Controls.Add(this.lblToplamTutar);
			this.grpSatislar.Controls.Add(this.label11);
			this.grpSatislar.Controls.Add(this.numAdet);
			this.grpSatislar.Controls.Add(this.cmbSatisTur);
			this.grpSatislar.Controls.Add(this.label10);
			this.grpSatislar.Controls.Add(this.label9);
			this.grpSatislar.Controls.Add(this.cmbCalisanlar);
			this.grpSatislar.Controls.Add(this.label8);
			this.grpSatislar.Controls.Add(this.label7);
			this.grpSatislar.Controls.Add(this.cmbUrunler);
			this.grpSatislar.Controls.Add(this.label6);
			this.grpSatislar.Location = new System.Drawing.Point(399, 12);
			this.grpSatislar.Name = "grpSatislar";
			this.grpSatislar.Size = new System.Drawing.Size(345, 380);
			this.grpSatislar.TabIndex = 0;
			this.grpSatislar.TabStop = false;
			this.grpSatislar.Text = "Satış Bilgileri";
			// 
			// btnMusteriBul
			// 
			this.btnMusteriBul.Location = new System.Drawing.Point(111, 68);
			this.btnMusteriBul.Name = "btnMusteriBul";
			this.btnMusteriBul.Size = new System.Drawing.Size(120, 23);
			this.btnMusteriBul.TabIndex = 7;
			this.btnMusteriBul.Text = "Müşteri Bul";
			this.btnMusteriBul.UseVisualStyleBackColor = true;
			this.btnMusteriBul.Click += new System.EventHandler(this.btnMusteriBul_Click);
			// 
			// btnIptalEt
			// 
			this.btnIptalEt.Location = new System.Drawing.Point(156, 336);
			this.btnIptalEt.Name = "btnIptalEt";
			this.btnIptalEt.Size = new System.Drawing.Size(75, 23);
			this.btnIptalEt.TabIndex = 6;
			this.btnIptalEt.Text = "İptal Et";
			this.btnIptalEt.UseVisualStyleBackColor = true;
			// 
			// btnSatisYap
			// 
			this.btnSatisYap.Location = new System.Drawing.Point(124, 287);
			this.btnSatisYap.Name = "btnSatisYap";
			this.btnSatisYap.Size = new System.Drawing.Size(131, 23);
			this.btnSatisYap.TabIndex = 5;
			this.btnSatisYap.Text = "Satışı Tamamla";
			this.btnSatisYap.UseVisualStyleBackColor = true;
			this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
			// 
			// lblToplamTutar
			// 
			this.lblToplamTutar.AutoSize = true;
			this.lblToplamTutar.Location = new System.Drawing.Point(109, 260);
			this.lblToplamTutar.Name = "lblToplamTutar";
			this.lblToplamTutar.Size = new System.Drawing.Size(41, 13);
			this.lblToplamTutar.TabIndex = 4;
			this.lblToplamTutar.Text = "label12";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(20, 260);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(79, 13);
			this.label11.TabIndex = 3;
			this.label11.Text = "Toplam Tutar : ";
			// 
			// numAdet
			// 
			this.numAdet.Location = new System.Drawing.Point(112, 195);
			this.numAdet.Name = "numAdet";
			this.numAdet.Size = new System.Drawing.Size(120, 20);
			this.numAdet.TabIndex = 2;
			// 
			// cmbSatisTur
			// 
			this.cmbSatisTur.FormattingEnabled = true;
			this.cmbSatisTur.Items.AddRange(new object[] {
            "Nakit",
            "Banka Kartı",
            "Kredi Kartı",
            "Havale/EFT",
            "Kripto"});
			this.cmbSatisTur.Location = new System.Drawing.Point(111, 150);
			this.cmbSatisTur.Name = "cmbSatisTur";
			this.cmbSatisTur.Size = new System.Drawing.Size(121, 21);
			this.cmbSatisTur.TabIndex = 1;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(20, 198);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 13);
			this.label10.TabIndex = 0;
			this.label10.Text = "Adet : ";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(20, 153);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(64, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "Satış Türü : ";
			// 
			// cmbCalisanlar
			// 
			this.cmbCalisanlar.FormattingEnabled = true;
			this.cmbCalisanlar.Location = new System.Drawing.Point(111, 108);
			this.cmbCalisanlar.Name = "cmbCalisanlar";
			this.cmbCalisanlar.Size = new System.Drawing.Size(121, 21);
			this.cmbCalisanlar.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(20, 111);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Çalışan";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(20, 68);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Müşteri";
			// 
			// cmbUrunler
			// 
			this.cmbUrunler.FormattingEnabled = true;
			this.cmbUrunler.Location = new System.Drawing.Point(111, 28);
			this.cmbUrunler.Name = "cmbUrunler";
			this.cmbUrunler.Size = new System.Drawing.Size(121, 21);
			this.cmbUrunler.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(20, 31);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(30, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Ürün";
			// 
			// SatisYap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.grpSatislar);
			this.Controls.Add(this.grpMusteriler);
			this.Name = "SatisYap";
			this.Text = "SatisYap";
			this.Load += new System.EventHandler(this.SatisYap_Load);
			this.grpMusteriler.ResumeLayout(false);
			this.grpMusteriler.PerformLayout();
			this.grpSatislar.ResumeLayout(false);
			this.grpSatislar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpMusteriler;
		private System.Windows.Forms.GroupBox grpSatislar;
		private System.Windows.Forms.Button btnMusteriKayit;
		private System.Windows.Forms.TextBox txtMusteriAdres;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMusteriMail;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtMusteriTelefon;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMusteriSoyad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMusteriAd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numAdet;
		private System.Windows.Forms.ComboBox cmbSatisTur;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cmbCalisanlar;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbUrunler;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnSatisYap;
		private System.Windows.Forms.Label lblToplamTutar;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnMusteriIptal;
		private System.Windows.Forms.Button btnIptalEt;
		private System.Windows.Forms.Button btnMusteriBul;
	}
}