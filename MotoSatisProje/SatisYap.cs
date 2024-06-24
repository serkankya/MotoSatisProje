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
	public partial class SatisYap : Form
	{
		public SatisYap()
		{
			InitializeComponent();
		}

		private void UrunleriListele()
		{
			using (SqlConnection sql = SqlBaglanti.Baglan())
			{
				sql.Open();

				string sorgu = "SELECT * FROM Urunler WHERE Durum = 1";

				using (SqlCommand komut = new SqlCommand(sorgu, sql))
				{
					using (SqlDataReader dr = komut.ExecuteReader())
					{
						DataTable dt = new DataTable();
						dt.Load(dr);

						cmbUrunler.DataSource = dt;

						cmbUrunler.ValueMember = "UrunId";
						cmbUrunler.DisplayMember = "UrunAd";
					}
				}
			}
		}

		private void CalisanlariListele()
		{
			using (SqlConnection sql = SqlBaglanti.Baglan())
			{
				sql.Open();

				string sorgu = "SELECT CalisanId, Ad, Soyad FROM Calisanlar WHERE Durum = 1";

				using (SqlCommand komut = new SqlCommand(sorgu, sql))
				{
					using (SqlDataReader dr = komut.ExecuteReader())
					{
						DataTable dt = new DataTable();
						dt.Load(dr);

						dt.Columns.Add("AdSoyad", typeof(string), "Ad + ' ' + Soyad"); //yeni bir sütun oluşturup ad soyad bilgisini tutuyoruz

						cmbCalisanlar.DataSource = dt;
						cmbCalisanlar.ValueMember = "CalisanId";
						cmbCalisanlar.DisplayMember = "AdSoyad";
					}
				}
			}
		}


		decimal toplamTutar;
		private void FiyatHesapla()
		{
			using (SqlConnection sql = SqlBaglanti.Baglan())
			{
				sql.Open();

				string sorgu = "SELECT Fiyat FROM Urunler WHERE Durum = 1";

				using (SqlCommand komut = new SqlCommand(sorgu, sql))
				{
					using (SqlDataReader dr = komut.ExecuteReader())
					{
						if(dr.Read())
						{
							decimal urunFiyati = Convert.ToDecimal(dr["Fiyat"]);

							toplamTutar = urunFiyati * numAdet.Value;
						}
					}
				}
			}
		}

		private bool StokDusur()
		{
			using (SqlConnection sql = SqlBaglanti.Baglan())
			{
				sql.Open();
				string sorgu = @"
            IF (SELECT Stok FROM Urunler WHERE UrunId = @urunId) >= @adet
            BEGIN
                UPDATE Urunler SET Stok = Stok - @adet WHERE UrunId = @urunId
            END
            ELSE
            BEGIN
                SELECT -1 AS StokYetersiz
            END";

				using (SqlCommand komut = new SqlCommand(sorgu, sql))
				{
					komut.Parameters.AddWithValue("@adet", numAdet.Value);
					komut.Parameters.AddWithValue("@urunId", cmbUrunler.SelectedValue);

					using (SqlDataReader dr = komut.ExecuteReader())
					{
						if (dr.Read() && dr["StokYetersiz"] != DBNull.Value)
						{
							MessageBox.Show("Stokta yeteri kadar ürün bulunmamakta!", "Stok Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return false;
						}
						else
						{
							return true;
						}
					}
				}
			}
		}


		private void btnSatisYap_Click(object sender, EventArgs e)
		{
			if(StokDusur() == true)
			{
				FiyatHesapla();
				lblToplamTutar.Text = toplamTutar.ToString() + " TL";

				using (SqlConnection sql = SqlBaglanti.Baglan())
				{
					sql.Open();

					string sorgu = "INSERT INTO Satislar (UrunId,MusteriId,CalisanId,SatisTur,Adet) VALUES (@urunId,@musteriId,@calisanId,@satisTur,@adet)";

					using (SqlCommand komut = new SqlCommand(sorgu, sql))
					{
						komut.Parameters.AddWithValue("@urunId",cmbUrunler.SelectedValue);
						komut.Parameters.AddWithValue("@musteriId", _gelenMusteriId);
						komut.Parameters.AddWithValue("@calisanId", cmbCalisanlar.SelectedValue);
						komut.Parameters.AddWithValue("@satisTur", cmbSatisTur.SelectedItem);
						komut.Parameters.AddWithValue("@adet", numAdet.Value);

						komut.ExecuteNonQuery();
						MessageBox.Show("Satış işlemi başarıyla gerçekleştirildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					}
				}
			}
		}

		private void btnMusteriKayit_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtMusteriAd.Text) && !string.IsNullOrEmpty(txtMusteriSoyad.Text) && !string.IsNullOrEmpty(txtMusteriAdres.Text) && !string.IsNullOrEmpty(txtMusteriMail.Text) && !string.IsNullOrEmpty(txtMusteriTelefon.Text))
			{
				using (SqlConnection sql = SqlBaglanti.Baglan())
				{
					sql.Open();

					string sorgu = "INSERT INTO Musteriler (Ad,Soyad,Telefon,Mail,Adres) VALUES (@ad,@soyad,@telefon,@mail,@adres)";

					using (SqlCommand komut = new SqlCommand(sorgu, sql))
					{
						komut.Parameters.AddWithValue("@ad", txtMusteriAd.Text);
						komut.Parameters.AddWithValue("@soyad", txtMusteriSoyad.Text);
						komut.Parameters.AddWithValue("@telefon", txtMusteriTelefon.Text);
						komut.Parameters.AddWithValue("@mail", txtMusteriMail.Text);
						komut.Parameters.AddWithValue("@adres", txtMusteriAdres.Text);

						komut.ExecuteNonQuery();

						MessageBox.Show("Müşteri kaydı başarıyla oluşturuldu.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					}
				}
			}
			else
			{
				MessageBox.Show("Lütfen ilgili yerleri doldurunuz!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		int _gelenMusteriId;
		private void btnMusteriBul_Click(object sender, EventArgs e)
		{
			MusteriBul musteriBul = new MusteriBul();
			musteriBul.ShowDialog();
			_gelenMusteriId = musteriBul._secilenMusteriId;
		}

		private void SatisYap_Load(object sender, EventArgs e)
		{
			UrunleriListele();
			CalisanlariListele();
		}
	}
}
