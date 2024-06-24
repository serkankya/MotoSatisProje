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
			this.cmbToptanci.FormattingEnabled = true;
			this.cmbToptanci.Location = new System.Drawing.Point(86, 279);
			this.cmbToptanci.Name = "cmbToptanci";
			this.cmbToptanci.Size = new System.Drawing.Size(121, 21);
			this.cmbToptanci.TabIndex = 13;
			// 
			// numStok
			// 
			this.numStok.Location = new System.Drawing.Point(86, 231);
			this.numStok.Name = "numStok";
			this.numStok.Size = new System.Drawing.Size(120, 20);
			this.numStok.TabIndex = 11;
			// 
			// numFiyat
			// 
			this.numFiyat.DecimalPlaces = 2;
			this.numFiyat.Location = new System.Drawing.Point(86, 193);
			this.numFiyat.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.numFiyat.Name = "numFiyat";
			this.numFiyat.Size = new System.Drawing.Size(120, 20);
			this.numFiyat.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 282);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Toptancı ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 233);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Stok";
			// 
			// txtAciklama
			// 
			this.txtAciklama.Location = new System.Drawing.Point(86, 48);
			this.txtAciklama.Multiline = true;
			this.txtAciklama.Name = "txtAciklama";
			this.txtAciklama.Size = new System.Drawing.Size(100, 130);
			this.txtAciklama.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 195);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Fiyat ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Açıklama : ";
			// 
			// txtUrunAdi
			// 
			this.txtUrunAdi.Location = new System.Drawing.Point(86, 22);
			this.txtUrunAdi.Name = "txtUrunAdi";
			this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
			this.txtUrunAdi.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Ürün Adı :  ";
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(111, 306);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
			this.btnGuncelle.TabIndex = 14;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnIptalEt
			// 
			this.btnIptalEt.Location = new System.Drawing.Point(111, 335);
			this.btnIptalEt.Name = "btnIptalEt";
			this.btnIptalEt.Size = new System.Drawing.Size(75, 23);
			this.btnIptalEt.TabIndex = 15;
			this.btnIptalEt.Text = "İptal Et";
			this.btnIptalEt.UseVisualStyleBackColor = true;
			// 
			// UrunBilgisiGuncelle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
			this.Name = "UrunBilgisiGuncelle";
			this.Text = "UrunBilgisiGuncelle";
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