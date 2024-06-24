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
			this.btnAnaSayfa = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numFiyat)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numStok)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(20, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ürün Adı :  ";
			// 
			// txtUrunAdi
			// 
			this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtUrunAdi.Location = new System.Drawing.Point(99, 55);
			this.txtUrunAdi.Name = "txtUrunAdi";
			this.txtUrunAdi.Size = new System.Drawing.Size(189, 26);
			this.txtUrunAdi.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(20, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Açıklama : ";
			// 
			// txtAciklama
			// 
			this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAciklama.Location = new System.Drawing.Point(99, 87);
			this.txtAciklama.Multiline = true;
			this.txtAciklama.Name = "txtAciklama";
			this.txtAciklama.Size = new System.Drawing.Size(189, 130);
			this.txtAciklama.TabIndex = 1;
			// 
			// numFiyat
			// 
			this.numFiyat.DecimalPlaces = 2;
			this.numFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.numFiyat.Location = new System.Drawing.Point(99, 223);
			this.numFiyat.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.numFiyat.Name = "numFiyat";
			this.numFiyat.Size = new System.Drawing.Size(189, 26);
			this.numFiyat.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(50, 225);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Fiyat : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(51, 259);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "Stok : ";
			// 
			// numStok
			// 
			this.numStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.numStok.Location = new System.Drawing.Point(99, 257);
			this.numStok.Name = "numStok";
			this.numStok.Size = new System.Drawing.Size(189, 26);
			this.numStok.TabIndex = 2;
			// 
			// cmbToptanci
			// 
			this.cmbToptanci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbToptanci.FormattingEnabled = true;
			this.cmbToptanci.Location = new System.Drawing.Point(99, 294);
			this.cmbToptanci.Name = "cmbToptanci";
			this.cmbToptanci.Size = new System.Drawing.Size(189, 28);
			this.cmbToptanci.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(25, 297);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "Toptancı : ";
			// 
			// btnKaydet
			// 
			this.btnKaydet.BackColor = System.Drawing.Color.LawnGreen;
			this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKaydet.Location = new System.Drawing.Point(99, 335);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(189, 33);
			this.btnKaydet.TabIndex = 4;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = false;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// dgwUrunler
			// 
			this.dgwUrunler.BackgroundColor = System.Drawing.Color.DarkGray;
			this.dgwUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwUrunler.GridColor = System.Drawing.SystemColors.ButtonShadow;
			this.dgwUrunler.Location = new System.Drawing.Point(326, 58);
			this.dgwUrunler.Name = "dgwUrunler";
			this.dgwUrunler.Size = new System.Drawing.Size(462, 388);
			this.dgwUrunler.TabIndex = 5;
			this.dgwUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUrunler_CellClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(425, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 20);
			this.label6.TabIndex = 7;
			this.label6.Text = "Ara : ";
			// 
			// txtAranacakKelime
			// 
			this.txtAranacakKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAranacakKelime.Location = new System.Drawing.Point(477, 26);
			this.txtAranacakKelime.Name = "txtAranacakKelime";
			this.txtAranacakKelime.Size = new System.Drawing.Size(222, 26);
			this.txtAranacakKelime.TabIndex = 6;
			this.txtAranacakKelime.TextChanged += new System.EventHandler(this.txtAranacakKelime_TextChanged);
			// 
			// btnSil
			// 
			this.btnSil.BackColor = System.Drawing.Color.OrangeRed;
			this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSil.Location = new System.Drawing.Point(99, 374);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(189, 33);
			this.btnSil.TabIndex = 8;
			this.btnSil.Text = "Ürünü Sil";
			this.btnSil.UseVisualStyleBackColor = false;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.BackColor = System.Drawing.Color.Turquoise;
			this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGuncelle.Location = new System.Drawing.Point(99, 413);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(189, 33);
			this.btnGuncelle.TabIndex = 9;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = false;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnAnaSayfa
			// 
			this.btnAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAnaSayfa.Location = new System.Drawing.Point(20, 8);
			this.btnAnaSayfa.Name = "btnAnaSayfa";
			this.btnAnaSayfa.Size = new System.Drawing.Size(127, 35);
			this.btnAnaSayfa.TabIndex = 10;
			this.btnAnaSayfa.Text = "Ana Sayfaya Dön";
			this.btnAnaSayfa.UseVisualStyleBackColor = true;
			this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
			// 
			// UrunKayit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSalmon;
			this.ClientSize = new System.Drawing.Size(800, 462);
			this.Controls.Add(this.btnAnaSayfa);
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
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "UrunKayit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ürün Kayıt Formu";
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
		private System.Windows.Forms.Button btnAnaSayfa;
	}
}