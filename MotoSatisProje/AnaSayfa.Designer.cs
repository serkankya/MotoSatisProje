namespace MotoSatisProje
{
	partial class AnaSayfa
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
			this.btnUrunKayit = new System.Windows.Forms.Button();
			this.btnCalisanKayit = new System.Windows.Forms.Button();
			this.btnToptanciKayit = new System.Windows.Forms.Button();
			this.btnSatisYap = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnUrunKayit
			// 
			this.btnUrunKayit.Location = new System.Drawing.Point(251, 30);
			this.btnUrunKayit.Name = "btnUrunKayit";
			this.btnUrunKayit.Size = new System.Drawing.Size(278, 73);
			this.btnUrunKayit.TabIndex = 0;
			this.btnUrunKayit.Text = "Ürün Kaydı";
			this.btnUrunKayit.UseVisualStyleBackColor = true;
			this.btnUrunKayit.Click += new System.EventHandler(this.btnUrunKayit_Click);
			// 
			// btnCalisanKayit
			// 
			this.btnCalisanKayit.Location = new System.Drawing.Point(251, 120);
			this.btnCalisanKayit.Name = "btnCalisanKayit";
			this.btnCalisanKayit.Size = new System.Drawing.Size(278, 73);
			this.btnCalisanKayit.TabIndex = 0;
			this.btnCalisanKayit.Text = "Çalışan Kaydı";
			this.btnCalisanKayit.UseVisualStyleBackColor = true;
			this.btnCalisanKayit.Click += new System.EventHandler(this.btnCalisanKayit_Click);
			// 
			// btnToptanciKayit
			// 
			this.btnToptanciKayit.Location = new System.Drawing.Point(251, 209);
			this.btnToptanciKayit.Name = "btnToptanciKayit";
			this.btnToptanciKayit.Size = new System.Drawing.Size(278, 73);
			this.btnToptanciKayit.TabIndex = 0;
			this.btnToptanciKayit.Text = "Toptancı Kaydı";
			this.btnToptanciKayit.UseVisualStyleBackColor = true;
			this.btnToptanciKayit.Click += new System.EventHandler(this.btnToptanciKaydi_Click);
			// 
			// btnSatisYap
			// 
			this.btnSatisYap.Location = new System.Drawing.Point(251, 299);
			this.btnSatisYap.Name = "btnSatisYap";
			this.btnSatisYap.Size = new System.Drawing.Size(278, 65);
			this.btnSatisYap.TabIndex = 0;
			this.btnSatisYap.Text = "Satış Yap";
			this.btnSatisYap.UseVisualStyleBackColor = true;
			this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
			// 
			// AnaSayfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSatisYap);
			this.Controls.Add(this.btnToptanciKayit);
			this.Controls.Add(this.btnCalisanKayit);
			this.Controls.Add(this.btnUrunKayit);
			this.Name = "AnaSayfa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AnaSayfa";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnUrunKayit;
		private System.Windows.Forms.Button btnCalisanKayit;
		private System.Windows.Forms.Button btnToptanciKayit;
		private System.Windows.Forms.Button btnSatisYap;
	}
}