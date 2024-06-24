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
			this.btnAnaSayfa = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwToptancilar)).BeginInit();
			this.SuspendLayout();
			// 
			// dgwToptancilar
			// 
			this.dgwToptancilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwToptancilar.Location = new System.Drawing.Point(346, 46);
			this.dgwToptancilar.Name = "dgwToptancilar";
			this.dgwToptancilar.Size = new System.Drawing.Size(442, 361);
			this.dgwToptancilar.TabIndex = 0;
			this.dgwToptancilar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwToptancilar_CellClick);
			// 
			// txtFirmaAdi
			// 
			this.txtFirmaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtFirmaAdi.Location = new System.Drawing.Point(97, 46);
			this.txtFirmaAdi.Name = "txtFirmaAdi";
			this.txtFirmaAdi.Size = new System.Drawing.Size(227, 26);
			this.txtFirmaAdi.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(15, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Firma Adı : ";
			// 
			// txtTelefon
			// 
			this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtTelefon.Location = new System.Drawing.Point(97, 78);
			this.txtTelefon.Name = "txtTelefon";
			this.txtTelefon.Size = new System.Drawing.Size(227, 26);
			this.txtTelefon.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(26, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Telefon : ";
			// 
			// txtMail
			// 
			this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMail.Location = new System.Drawing.Point(97, 109);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(227, 26);
			this.txtMail.TabIndex = 1;
			// 
			// txtAdres
			// 
			this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAdres.Location = new System.Drawing.Point(97, 141);
			this.txtAdres.Multiline = true;
			this.txtAdres.Name = "txtAdres";
			this.txtAdres.Size = new System.Drawing.Size(227, 143);
			this.txtAdres.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(51, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mail : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(37, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Adres : ";
			// 
			// btnKaydet
			// 
			this.btnKaydet.BackColor = System.Drawing.Color.LimeGreen;
			this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKaydet.Location = new System.Drawing.Point(97, 290);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(227, 35);
			this.btnKaydet.TabIndex = 3;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = false;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.BackColor = System.Drawing.Color.Turquoise;
			this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGuncelle.Location = new System.Drawing.Point(97, 331);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(227, 35);
			this.btnGuncelle.TabIndex = 4;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = false;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnSil
			// 
			this.btnSil.BackColor = System.Drawing.Color.OrangeRed;
			this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSil.Location = new System.Drawing.Point(97, 372);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(227, 35);
			this.btnSil.TabIndex = 4;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = false;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// txtAranacakKelime
			// 
			this.txtAranacakKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAranacakKelime.Location = new System.Drawing.Point(469, 14);
			this.txtAranacakKelime.Name = "txtAranacakKelime";
			this.txtAranacakKelime.Size = new System.Drawing.Size(225, 26);
			this.txtAranacakKelime.TabIndex = 1;
			this.txtAranacakKelime.TextChanged += new System.EventHandler(this.txtAranacakKelime_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(428, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "Ara : ";
			// 
			// btnAnaSayfa
			// 
			this.btnAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAnaSayfa.Location = new System.Drawing.Point(12, 12);
			this.btnAnaSayfa.Name = "btnAnaSayfa";
			this.btnAnaSayfa.Size = new System.Drawing.Size(144, 28);
			this.btnAnaSayfa.TabIndex = 5;
			this.btnAnaSayfa.Text = "Ana Sayfaya Dön";
			this.btnAnaSayfa.UseVisualStyleBackColor = true;
			this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
			// 
			// ToptanciKayit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSalmon;
			this.ClientSize = new System.Drawing.Size(800, 423);
			this.Controls.Add(this.txtAranacakKelime);
			this.Controls.Add(this.txtAdres);
			this.Controls.Add(this.txtMail);
			this.Controls.Add(this.txtTelefon);
			this.Controls.Add(this.txtFirmaAdi);
			this.Controls.Add(this.btnAnaSayfa);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgwToptancilar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ToptanciKayit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Toptancı Kayıt Formu";
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
		private System.Windows.Forms.Button btnAnaSayfa;
	}
}