namespace MotoSatisProje
{
	partial class CalisanBilgisiGuncelle
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
			this.cmbPozisyon = new System.Windows.Forms.ComboBox();
			this.txtTelefon = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnIptalEt = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmbPozisyon
			// 
			this.cmbPozisyon.FormattingEnabled = true;
			this.cmbPozisyon.Items.AddRange(new object[] {
            "Müdür",
            "Mağaza Sorumlusu",
            "Satış Sorumlusu",
            "Kasiyer"});
			this.cmbPozisyon.Location = new System.Drawing.Point(131, 94);
			this.cmbPozisyon.Name = "cmbPozisyon";
			this.cmbPozisyon.Size = new System.Drawing.Size(121, 21);
			this.cmbPozisyon.TabIndex = 16;
			// 
			// txtTelefon
			// 
			this.txtTelefon.Location = new System.Drawing.Point(131, 122);
			this.txtTelefon.Name = "txtTelefon";
			this.txtTelefon.Size = new System.Drawing.Size(100, 20);
			this.txtTelefon.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(59, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Telefon";
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(131, 68);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(100, 20);
			this.txtSoyad.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(59, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Soyad";
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(131, 154);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(100, 20);
			this.txtMail.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(59, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Pozisyon";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(59, 157);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Mail";
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(131, 42);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(100, 20);
			this.txtAd.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(59, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Ad : ";
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(146, 180);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
			this.btnGuncelle.TabIndex = 17;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnIptalEt
			// 
			this.btnIptalEt.Location = new System.Drawing.Point(146, 209);
			this.btnIptalEt.Name = "btnIptalEt";
			this.btnIptalEt.Size = new System.Drawing.Size(75, 23);
			this.btnIptalEt.TabIndex = 18;
			this.btnIptalEt.Text = "İptal Et";
			this.btnIptalEt.UseVisualStyleBackColor = true;
			// 
			// CalisanBilgisiGuncelle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnIptalEt);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.cmbPozisyon);
			this.Controls.Add(this.txtTelefon);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtSoyad);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.label1);
			this.Name = "CalisanBilgisiGuncelle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CalisanBilgisiGuncelle";
			this.Load += new System.EventHandler(this.CalisanBilgisiGuncelle_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbPozisyon;
		private System.Windows.Forms.TextBox txtTelefon;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSoyad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMail;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnIptalEt;
	}
}