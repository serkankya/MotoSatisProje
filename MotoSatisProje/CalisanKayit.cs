using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoSatisProje
{
	public partial class CalisanKayit : Form
	{
		public CalisanKayit()
		{
			InitializeComponent();
		}

		private void CalisanlariListele()
		{
			using (SqlConnection sql = SqlBaglanti.Baglan())
			{
				sql.Open();

				string sorgu = "SELECT * FROM Calisanlar WHERE Durum = 1";

				using (SqlCommand komut = new SqlCommand(sorgu, sql))
				{
					SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
					DataSet ds = new DataSet();
					dataAdapter.Fill(ds);

					dgwCalisanlar.DataSource = ds.Tables[0];
				}
			}
		}

		private void CalisanlariAra()
		{
			using (SqlConnection sql = SqlBaglanti.Baglan())
			{
				sql.Open();

				string sorgu = "SELECT * FROM Calisanlar WHERE Durum = 1 AND (Ad LIKE @ara OR Soyad LIKE @ara)\r\n";

				using (SqlCommand komut = new SqlCommand(sorgu, sql))
				{
					komut.Parameters.AddWithValue("@ara", '%' + txtAranacakKelime.Text + '%');

					SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
					DataSet ds = new DataSet();
					dataAdapter.Fill(ds);

					dgwCalisanlar.DataSource = ds.Tables[0];
				}
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (_secilenCalisanId > 0)
			{
				CalisanBilgisiGuncelle calisanBilgisiGuncelle = new CalisanBilgisiGuncelle(_secilenCalisanId);
				calisanBilgisiGuncelle.ShowDialog();

				CalisanlariListele();
			}
			else
			{
				MessageBox.Show("Lütfen geçerli bir çalışan seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		int _secilenCalisanId;
		private void dgwCalisanlar_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			_secilenCalisanId = Convert.ToInt32(dgwCalisanlar.CurrentRow.Cells[0].Value);
		}

		private void CalisanKayit_Load(object sender, EventArgs e)
		{
			CalisanlariListele();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtMail.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtTelefon.Text) && !string.IsNullOrEmpty(cmbPozisyon.Text))
			{
				using (SqlConnection sql = SqlBaglanti.Baglan())
				{
					sql.Open();

					string sorgu = "INSERT INTO Calisanlar (Pozisyon,Ad,Soyad,Telefon,Mail) VALUES (@pozisyon,@ad,@soyad,@telefon,@mail)";

					using (SqlCommand komut = new SqlCommand(sorgu, sql))
					{
						komut.Parameters.AddWithValue("@pozisyon", cmbPozisyon.SelectedItem);
						komut.Parameters.AddWithValue("@ad", txtAd.Text);
						komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
						komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
						komut.Parameters.AddWithValue("@mail", txtMail.Text);

						komut.ExecuteNonQuery();

						MessageBox.Show("Çalışan kaydı başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
						CalisanlariListele();
					}
				}
			}
			else
			{
				MessageBox.Show("Lütfen ilgili yerleri doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (_secilenCalisanId > 0)
			{
				DialogResult sonuc = MessageBox.Show("Seçilen çalışanı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (sonuc == DialogResult.Yes)
				{
					using (SqlConnection sql = SqlBaglanti.Baglan())
					{
						sql.Open();

						string sorgu = "UPDATE Calisanlar SET Durum = 0 WHERE CalisanId = @calisanId";

						using (SqlCommand komut = new SqlCommand(sorgu, sql))
						{
							komut.Parameters.AddWithValue("@calisanId", _secilenCalisanId);

							komut.ExecuteNonQuery();
							CalisanlariListele();
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Lütfen geçerli bir çalışan seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtAranacakKelime_TextChanged(object sender, EventArgs e)
		{
			CalisanlariAra();
		}

		private void btnAnaSayfa_Click(object sender, EventArgs e)
		{
			AnaSayfa anaSayfa = new AnaSayfa();
			anaSayfa.Show();
			this.Hide();
		}
	}
}
