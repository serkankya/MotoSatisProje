namespace MotoSatisProje
{
	partial class MusteriBul
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
			this.dgwMusteriler = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAra = new System.Windows.Forms.TextBox();
			this.btnTamamla = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnVerileriGuncelle = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgwMusteriler
			// 
			this.dgwMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwMusteriler.Location = new System.Drawing.Point(12, 103);
			this.dgwMusteriler.Name = "dgwMusteriler";
			this.dgwMusteriler.Size = new System.Drawing.Size(552, 150);
			this.dgwMusteriler.TabIndex = 0;
			this.dgwMusteriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMusteriler_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(11, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 40);
			this.label1.TabIndex = 1;
			this.label1.Text = "Müşteri Bilgisi Giriniz\r\n(Ad,Soyad, Telefon veya Mail)";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtAra
			// 
			this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAra.Location = new System.Drawing.Point(234, 23);
			this.txtAra.Name = "txtAra";
			this.txtAra.Size = new System.Drawing.Size(290, 26);
			this.txtAra.TabIndex = 0;
			this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
			// 
			// btnTamamla
			// 
			this.btnTamamla.BackColor = System.Drawing.Color.LimeGreen;
			this.btnTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnTamamla.Location = new System.Drawing.Point(187, 259);
			this.btnTamamla.Name = "btnTamamla";
			this.btnTamamla.Size = new System.Drawing.Size(198, 38);
			this.btnTamamla.TabIndex = 0;
			this.btnTamamla.Text = "Tamamla";
			this.btnTamamla.UseVisualStyleBackColor = false;
			this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(64, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(408, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Aşağıdan müşteriyi bulun ve Tamamla butonuna tıklayınız";
			// 
			// btnVerileriGuncelle
			// 
			this.btnVerileriGuncelle.BackColor = System.Drawing.Color.Turquoise;
			this.btnVerileriGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnVerileriGuncelle.Location = new System.Drawing.Point(187, 303);
			this.btnVerileriGuncelle.Name = "btnVerileriGuncelle";
			this.btnVerileriGuncelle.Size = new System.Drawing.Size(198, 39);
			this.btnVerileriGuncelle.TabIndex = 1;
			this.btnVerileriGuncelle.Text = "Verileri Güncelle";
			this.btnVerileriGuncelle.UseVisualStyleBackColor = false;
			this.btnVerileriGuncelle.Click += new System.EventHandler(this.btnVerileriGuncelle_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtAra);
			this.groupBox1.Location = new System.Drawing.Point(12, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(552, 63);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			// 
			// MusteriBul
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SandyBrown;
			this.ClientSize = new System.Drawing.Size(574, 356);
			this.Controls.Add(this.btnVerileriGuncelle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnTamamla);
			this.Controls.Add(this.dgwMusteriler);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MusteriBul";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Müşteri Bul";
			((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwMusteriler;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAra;
		private System.Windows.Forms.Button btnTamamla;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnVerileriGuncelle;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}