using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoSatisProje
{
	public partial class ToptanciKayit : Form
	{
		public ToptanciKayit()
		{
			InitializeComponent();
		}

		private void ToptancilariListele()
		{
			using (SqlConnection sql = SqlBaglanti.Baglan())
			{
				sql.Open();

				string sorgu = "SELECT * FROM Toptancilar WHERE Durum = 1";

				using (SqlCommand komut = new SqlCommand(sorgu, sql))
				{
					SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
					DataSet dataSet = new DataSet();
					dataAdapter.Fill(dataSet);

					dgwToptancilar.DataSource = dataSet.Tables[0];
				}
			}
		}

		private void ToptancilariAra()
		{
			using (SqlConnection sql = SqlBaglanti.Baglan())
			{
				sql.Open();

				string sorgu = "SELECT * FROM Toptancilar WHERE FirmaAdi LIKE @firmaAdi AND Durum = 1";

				using (SqlCommand komut = new SqlCommand(sorgu, sql))
				{
					komut.Parameters.AddWithValue("@firmaAdi", '%' + txtAranacakKelime.Text + '%');

					SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
					DataSet dataSet = new DataSet();
					dataAdapter.Fill(dataSet);
					dgwToptancilar.DataSource = dataSet.Tables[0];
				}
			}
		}

		private void ToptanciKayit_Load(object sender, EventArgs e)
		{
			ToptancilariListele();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtFirmaAdi.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtMail.Text) && !string.IsNullOrEmpty(txtTelefon.Text))
			{
				using (SqlConnection sql = SqlBaglanti.Baglan())
				{
					sql.Open();

					string sorgu = "INSERT INTO Toptancilar (FirmaAdi,Adres,Telefon,Mail) VALUES (@FirmaAdi,@Adres,@Telefon,@Mail)";
					using (SqlCommand komut = new SqlCommand(sorgu, sql))
					{
						komut.Parameters.AddWithValue("@FirmaAdi", txtFirmaAdi.Text);
						komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
						komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
						komut.Parameters.AddWithValue("@Mail", txtMail.Text);

						komut.ExecuteNonQuery();

						MessageBox.Show("Yeni toptancı kaydı başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
						ToptancilariListele();
					}
				}
			}
			else
			{
				MessageBox.Show("Lütfen gerekli yerleri doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtAranacakKelime_TextChanged(object sender, EventArgs e)
		{
			ToptancilariAra();
		}

		int _secilenToptanciId;
		private void dgwToptancilar_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			_secilenToptanciId = Convert.ToInt32(dgwToptancilar.CurrentRow.Cells[0].Value);
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (_secilenToptanciId > 0)
			{
				ToptanciBilgisiGuncelle toptanciBilgisiGuncelle = new ToptanciBilgisiGuncelle(_secilenToptanciId);
				toptanciBilgisiGuncelle.ShowDialog();

				ToptancilariListele();
			}
			else
			{
				MessageBox.Show("Lütfen öncelikle bir toptancı seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (_secilenToptanciId > 0)
			{
				DialogResult sonuc = MessageBox.Show("Seçilen toptancı bilgilerini silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (sonuc == DialogResult.Yes)
				{
					using (SqlConnection sql = SqlBaglanti.Baglan())
					{
						sql.Open();

						string sorgu = "UPDATE Toptancilar SET Durum = 0 WHERE ToptanciId = @toptanciId";

						using (SqlCommand komut = new SqlCommand(sorgu, sql))
						{
							komut.Parameters.AddWithValue("@toptanciId", _secilenToptanciId);

							komut.ExecuteNonQuery();

							MessageBox.Show("Seçilen toptancı başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
							ToptancilariListele();
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Lütfen öncelikle bir toptancı seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
