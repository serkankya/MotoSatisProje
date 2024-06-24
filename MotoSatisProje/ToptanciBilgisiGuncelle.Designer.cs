namespace MotoSatisProje
{
	partial class ToptanciBilgisiGuncelle
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
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAdres = new System.Windows.Forms.TextBox();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.txtTelefon = new System.Windows.Forms.TextBox();
			this.txtFirmaAdi = new System.Windows.Forms.TextBox();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnIptalEt = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(144, 147);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Adres";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(144, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Telefon";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(144, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Mail : ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(144, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Firma Adı : ";
			// 
			// txtAdres
			// 
			this.txtAdres.Location = new System.Drawing.Point(209, 144);
			this.txtAdres.Multiline = true;
			this.txtAdres.Name = "txtAdres";
			this.txtAdres.Size = new System.Drawing.Size(100, 129);
			this.txtAdres.TabIndex = 3;
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(209, 118);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(100, 20);
			this.txtMail.TabIndex = 4;
			// 
			// txtTelefon
			// 
			this.txtTelefon.Location = new System.Drawing.Point(209, 89);
			this.txtTelefon.Name = "txtTelefon";
			this.txtTelefon.Size = new System.Drawing.Size(100, 20);
			this.txtTelefon.TabIndex = 5;
			// 
			// txtFirmaAdi
			// 
			this.txtFirmaAdi.Location = new System.Drawing.Point(209, 63);
			this.txtFirmaAdi.Name = "txtFirmaAdi";
			this.txtFirmaAdi.Size = new System.Drawing.Size(100, 20);
			this.txtFirmaAdi.TabIndex = 6;
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(218, 289);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
			this.btnGuncelle.TabIndex = 11;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnIptalEt
			// 
			this.btnIptalEt.Location = new System.Drawing.Point(218, 318);
			this.btnIptalEt.Name = "btnIptalEt";
			this.btnIptalEt.Size = new System.Drawing.Size(75, 23);
			this.btnIptalEt.TabIndex = 11;
			this.btnIptalEt.Text = "İptal Et";
			this.btnIptalEt.UseVisualStyleBackColor = true;
			// 
			// ToptanciBilgisiGuncelle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnIptalEt);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtAdres);
			this.Controls.Add(this.txtMail);
			this.Controls.Add(this.txtTelefon);
			this.Controls.Add(this.txtFirmaAdi);
			this.Name = "ToptanciBilgisiGuncelle";
			this.Text = "ToptanciBilgisiGuncelle";
			this.Load += new System.EventHandler(this.ToptanciBilgisiGuncelle_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAdres;
		private System.Windows.Forms.TextBox txtMail;
		private System.Windows.Forms.TextBox txtTelefon;
		private System.Windows.Forms.TextBox txtFirmaAdi;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnIptalEt;
	}
}