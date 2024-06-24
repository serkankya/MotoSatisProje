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
			((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).BeginInit();
			this.SuspendLayout();
			// 
			// dgwMusteriler
			// 
			this.dgwMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwMusteriler.Location = new System.Drawing.Point(12, 129);
			this.dgwMusteriler.Name = "dgwMusteriler";
			this.dgwMusteriler.Size = new System.Drawing.Size(776, 150);
			this.dgwMusteriler.TabIndex = 0;
			this.dgwMusteriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMusteriler_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "Müşteri Bilgisi Giriniz\r\n(Ad,Soyad, Telefon veya Mail)";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtAra
			// 
			this.txtAra.Location = new System.Drawing.Point(187, 32);
			this.txtAra.Name = "txtAra";
			this.txtAra.Size = new System.Drawing.Size(180, 20);
			this.txtAra.TabIndex = 2;
			this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
			// 
			// btnTamamla
			// 
			this.btnTamamla.Location = new System.Drawing.Point(283, 312);
			this.btnTamamla.Name = "btnTamamla";
			this.btnTamamla.Size = new System.Drawing.Size(143, 39);
			this.btnTamamla.TabIndex = 3;
			this.btnTamamla.Text = "Tamamla";
			this.btnTamamla.UseVisualStyleBackColor = true;
			this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(274, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Aşağıdan müşteriyi bulun ve Tamamla butonuna tıklayınız";
			// 
			// btnVerileriGuncelle
			// 
			this.btnVerileriGuncelle.Location = new System.Drawing.Point(283, 357);
			this.btnVerileriGuncelle.Name = "btnVerileriGuncelle";
			this.btnVerileriGuncelle.Size = new System.Drawing.Size(143, 36);
			this.btnVerileriGuncelle.TabIndex = 5;
			this.btnVerileriGuncelle.Text = "Verileri Güncelle";
			this.btnVerileriGuncelle.UseVisualStyleBackColor = true;
			// 
			// frmMusteriBul
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnVerileriGuncelle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnTamamla);
			this.Controls.Add(this.txtAra);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgwMusteriler);
			this.Name = "frmMusteriBul";
			this.Text = "frmMusteriBul";
			((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).EndInit();
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
	}
}