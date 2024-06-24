namespace MotoSatisProje
{
	partial class GirisYap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisYap));
			this.btnGirisYap = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.btnCikis = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGirisYap
			// 
			this.btnGirisYap.BackColor = System.Drawing.Color.LimeGreen;
			this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGirisYap.Location = new System.Drawing.Point(26, 177);
			this.btnGirisYap.Name = "btnGirisYap";
			this.btnGirisYap.Size = new System.Drawing.Size(228, 38);
			this.btnGirisYap.TabIndex = 2;
			this.btnGirisYap.Text = "Giriş Yap";
			this.btnGirisYap.UseVisualStyleBackColor = false;
			this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(76, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "Kullanıcı Adınız";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(110, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "Şifreniz";
			// 
			// txtKullaniciAdi
			// 
			this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtKullaniciAdi.Location = new System.Drawing.Point(26, 63);
			this.txtKullaniciAdi.Name = "txtKullaniciAdi";
			this.txtKullaniciAdi.Size = new System.Drawing.Size(228, 27);
			this.txtKullaniciAdi.TabIndex = 0;
			// 
			// txtSifre
			// 
			this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSifre.Location = new System.Drawing.Point(26, 127);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.PasswordChar = '*';
			this.txtSifre.Size = new System.Drawing.Size(228, 27);
			this.txtSifre.TabIndex = 1;
			// 
			// btnCikis
			// 
			this.btnCikis.BackColor = System.Drawing.Color.IndianRed;
			this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCikis.Location = new System.Drawing.Point(26, 221);
			this.btnCikis.Name = "btnCikis";
			this.btnCikis.Size = new System.Drawing.Size(228, 38);
			this.btnCikis.TabIndex = 3;
			this.btnCikis.Text = "Çıkış Yap";
			this.btnCikis.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(185, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(431, 309);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// GirisYap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSalmon;
			this.ClientSize = new System.Drawing.Size(574, 312);
			this.Controls.Add(this.btnCikis);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.txtKullaniciAdi);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGirisYap);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "GirisYap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Giriş Yapınız";
			this.Load += new System.EventHandler(this.GirisYap_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGirisYap;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtKullaniciAdi;
		private System.Windows.Forms.TextBox txtSifre;
		private System.Windows.Forms.Button btnCikis;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}