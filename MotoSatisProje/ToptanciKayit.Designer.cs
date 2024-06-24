namespace MotoSatisProje
{
	partial class ToptanciKayit
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
			this.dgwToptancilar = new System.Windows.Forms.DataGridView();
			this.txtFirmaAdi = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTelefon = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.txtAdres = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.txtAranacakKelime = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgwToptancilar)).BeginInit();
			this.SuspendLayout();
			// 
			// dgwToptancilar
			// 
			this.dgwToptancilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwToptancilar.Location = new System.Drawing.Point(249, 51);
			this.dgwToptancilar.Name = "dgwToptancilar";
			this.dgwToptancilar.Size = new System.Drawing.Size(539, 337);
			this.dgwToptancilar.TabIndex = 0;
			this.dgwToptancilar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwToptancilar_CellClick);
			// 
			// txtFirmaAdi
			// 
			this.txtFirmaAdi.Location = new System.Drawing.Point(87, 78);
			this.txtFirmaAdi.Name = "txtFirmaAdi";
			this.txtFirmaAdi.Size = new System.Drawing.Size(100, 20);
			this.txtFirmaAdi.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Firma Adı : ";
			// 
			// txtTelefon
			// 
			this.txtTelefon.Location = new System.Drawing.Point(87, 104);
			this.txtTelefon.Name = "txtTelefon";
			this.txtTelefon.Size = new System.Drawing.Size(100, 20);
			this.txtTelefon.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Telefon";
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(87, 133);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(100, 20);
			this.txtMail.TabIndex = 1;
			// 
			// txtAdres
			// 
			this.txtAdres.Location = new System.Drawing.Point(87, 159);
			this.txtAdres.Multiline = true;
			this.txtAdres.Name = "txtAdres";
			this.txtAdres.Size = new System.Drawing.Size(100, 129);
			this.txtAdres.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mail : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 162);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Adres";
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(99, 303);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(75, 23);
			this.btnKaydet.TabIndex = 3;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(99, 332);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
			this.btnGuncelle.TabIndex = 4;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(99, 361);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(75, 23);
			this.btnSil.TabIndex = 4;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// txtAranacakKelime
			// 
			this.txtAranacakKelime.Location = new System.Drawing.Point(474, 25);
			this.txtAranacakKelime.Name = "txtAranacakKelime";
			this.txtAranacakKelime.Size = new System.Drawing.Size(100, 20);
			this.txtAranacakKelime.TabIndex = 1;
			this.txtAranacakKelime.TextChanged += new System.EventHandler(this.txtAranacakKelime_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(436, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Ara : ";
			// 
			// ToptanciKayit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtAdres);
			this.Controls.Add(this.txtMail);
			this.Controls.Add(this.txtTelefon);
			this.Controls.Add(this.txtAranacakKelime);
			this.Controls.Add(this.txtFirmaAdi);
			this.Controls.Add(this.dgwToptancilar);
			this.Name = "ToptanciKayit";
			this.Text = "ToptanciKayit";
			this.Load += new System.EventHandler(this.ToptanciKayit_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwToptancilar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwToptancilar;
		private System.Windows.Forms.TextBox txtFirmaAdi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTelefon;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMail;
		private System.Windows.Forms.TextBox txtAdres;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.TextBox txtAranacakKelime;
		private System.Windows.Forms.Label label5;
	}
}