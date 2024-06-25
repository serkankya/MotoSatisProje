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
	public partial class UrunKayit : Form
	{
		public UrunKayit()
		{
			InitializeComponent();
		}

		void ToptancilariListele()
		{
			using (SqlConnection sql = SqlBaglanti.Baglan())
			{
				sql.Open();

				string sorgu = "SELECT * FROM Toptancilar WHERE Durum = 1";

				using (SqlCommand komut = new SqlCommand(sorgu, sql))
				{
					using (SqlDataReader dr = komut.ExecuteReader())
					{
						DataTable dt = new DataTable();
						dt.Load(dr);

						cmbToptanci.DataSource = dt;

						cmbToptanci.ValueMember = "ToptanciId";
						cmbToptanci.DisplayMember = "FirmaAdi";
					}
				}
			}
		}

		void UrunleriListele()
		{
			using (SqlConnection sql = SqlBaglanti.Baglan())
			{
				sql.Open();

				string sorgu = "SELECT * FROM Urunler WHERE Durum = 1";
				 
				using (SqlCommand komut = new SqlCommand(sorgu, sql))
				{
					SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
					DataSet ds = new DataSet();
					dataAdapter.Fill(ds);

					dgwUrunler.DataSource = ds.Tables[0];
				}
			}
		}

		void UrunleriAra()
		{
			using (SqlConnection sql = SqlBaglanti.Baglan())
			{
				sql.Open();

				string sorgu = "SELECT * FROM Urunler WHERE UrunAdi LIKE @urunAd AND Durum = 1";

				using (SqlCommand komut = new SqlCommand(sorgu, sql))
				{
					komut.Parameters.AddWithValue("@urunAd", '%' + txtAranacakKelime.Text + '%');

					SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
					DataSet dataSet = new DataSet();
					dataAdapter.Fill(dataSet);
					dgwUrunler.DataSource = dataSet.Tables[0];
				}
			}
		}

		private void UrunKayit_Load(object sender, EventArgs e)
		{
			ToptancilariListele();
			UrunleriListele();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtAciklama.Text) && !string.IsNullOrEmpty(txtUrunAdi.Text))
			{
				using (SqlConnection sql = SqlBaglanti.Baglan())
				{
					sql.Open();

					string sorgu = "INSERT INTO Urunler (ToptanciId,Fiyat,Aciklama,Stok,UrunAdi) VALUES (@toptanciId,@fiyat,@aciklama,@stok,@urunAd)";

					using (SqlCommand komut = new SqlCommand(sorgu, sql))
					{
						komut.Parameters.AddWithValue("@toptanciId", cmbToptanci.SelectedValue);
						komut.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(numFiyat.Value));
						komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
						komut.Parameters.AddWithValue("@stok", numStok.Value);
						komut.Parameters.AddWithValue("@urunAd", txtUrunAdi.Text);

						komut.ExecuteNonQuery();
						MessageBox.Show("Yeni ürün bilgileri başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
						UrunleriListele();
					}
				}
			}
			else
			{
				MessageBox.Show("Lütfen ilgili yerleri doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtAranacakKelime_TextChanged(object sender, EventArgs e)
		{
			UrunleriAra();
		}

		int _secilenUrunId;
		private void dgwUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			_secilenUrunId = Convert.ToInt32(dgwUrunler.CurrentRow.Cells[0].Value);
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (_secilenUrunId > 0)
			{
				UrunBilgisiGuncelle urunBilgisiGuncelle = new UrunBilgisiGuncelle(_secilenUrunId);
				urunBilgisiGuncelle.ShowDialog();

				UrunleriListele();
			}
			else
			{
				MessageBox.Show("Lütfen öncelikle bir ürün seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (_secilenUrunId > 0)
			{
				DialogResult sonuc = MessageBox.Show("Seçilen ürün bilgilerini silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (sonuc == DialogResult.Yes)
				{
					using (SqlConnection sql = SqlBaglanti.Baglan())
					{
						sql.Open();

						string sorgu = "UPDATE Urunler SET Durum = 0 WHERE UrunId = @urunId";

						using (SqlCommand komut = new SqlCommand(sorgu, sql))
						{
							komut.Parameters.AddWithValue("@urunId", _secilenUrunId);

							komut.ExecuteNonQuery();

							MessageBox.Show("Seçilen ürün başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
							UrunleriListele();
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Lütfen öncelikle bir ürün seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnAnaSayfa_Click(object sender, EventArgs e)
		{
			AnaSayfa anaSayfa = new AnaSayfa();
			anaSayfa.Show();
			this.Hide();
		}
	}
}
