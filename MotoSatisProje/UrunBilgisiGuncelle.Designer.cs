namespace MotoSatisProje
{
	partial class UrunBilgisiGuncelle
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
			this.cmbToptanci = new System.Windows.Forms.ComboBox();
			this.numStok = new System.Windows.Forms.NumericUpDown();
			this.numFiyat = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAciklama = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUrunAdi = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnIptalEt = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numStok)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numFiyat)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbToptanci
			// 
			this.cmbToptanci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbToptanci.FormattingEnabled = true;
			this.cmbToptanci.Location = new System.Drawing.Point(111, 301);
			this.cmbToptanci.Name = "cmbToptanci";
			this.cmbToptanci.Size = new System.Drawing.Size(270, 28);
			this.cmbToptanci.TabIndex = 13;
			// 
			// numStok
			// 
			this.numStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.numStok.Location = new System.Drawing.Point(111, 258);
			this.numStok.Name = "numStok";
			this.numStok.Size = new System.Drawing.Size(270, 26);
			this.numStok.TabIndex = 11;
			// 
			// numFiyat
			// 
			this.numFiyat.DecimalPlaces = 2;
			this.numFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.numFiyat.Location = new System.Drawing.Point(111, 212);
			this.numFiyat.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.numFiyat.Name = "numFiyat";
			this.numFiyat.Size = new System.Drawing.Size(270, 26);
			this.numFiyat.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(36, 304);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Toptancı : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(62, 260);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Stok : ";
			// 
			// txtAciklama
			// 
			this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAciklama.Location = new System.Drawing.Point(111, 63);
			this.txtAciklama.Multiline = true;
			this.txtAciklama.Name = "txtAciklama";
			this.txtAciklama.Size = new System.Drawing.Size(270, 130);
			this.txtAciklama.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(60, 214);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Fiyat : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(30, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Açıklama : ";
			// 
			// txtUrunAdi
			// 
			this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtUrunAdi.Location = new System.Drawing.Point(111, 22);
			this.txtUrunAdi.Name = "txtUrunAdi";
			this.txtUrunAdi.Size = new System.Drawing.Size(270, 26);
			this.txtUrunAdi.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(31, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Ürün Adı :  ";
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.BackColor = System.Drawing.Color.LimeGreen;
			this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGuncelle.Location = new System.Drawing.Point(111, 344);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(270, 34);
			this.btnGuncelle.TabIndex = 14;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = false;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnIptalEt
			// 
			this.btnIptalEt.BackColor = System.Drawing.Color.OrangeRed;
			this.btnIptalEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnIptalEt.Location = new System.Drawing.Point(111, 384);
			this.btnIptalEt.Name = "btnIptalEt";
			this.btnIptalEt.Size = new System.Drawing.Size(270, 34);
			this.btnIptalEt.TabIndex = 15;
			this.btnIptalEt.Text = "İptal Et";
			this.btnIptalEt.UseVisualStyleBackColor = false;
			this.btnIptalEt.Click += new System.EventHandler(this.btnIptalEt_Click);
			// 
			// UrunBilgisiGuncelle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SandyBrown;
			this.ClientSize = new System.Drawing.Size(438, 450);
			this.Controls.Add(this.btnIptalEt);
			this.Controls.Add(this.btnGuncelle);
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
			this.Name = "UrunBilgisiGuncelle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ürün Bilgisi Güncelle";
			this.Load += new System.EventHandler(this.UrunBilgisiGuncelle_Load);
			((System.ComponentModel.ISupportInitialize)(this.numStok)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numFiyat)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbToptanci;
		private System.Windows.Forms.NumericUpDown numStok;
		private System.Windows.Forms.NumericUpDown numFiyat;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAciklama;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUrunAdi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnIptalEt;
	}
}