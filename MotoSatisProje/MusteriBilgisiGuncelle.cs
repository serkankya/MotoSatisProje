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
	public partial class MusteriBilgisiGuncelle : Form
	{
		int _gelenMusteriId;
		public MusteriBilgisiGuncelle(int musteriId)
		{
			InitializeComponent();
			_gelenMusteriId = musteriId;
		}

		private void MusteriBilgisiGuncelle_Load(object sender, EventArgs e)
		{
			using (SqlConnection sql = SqlBaglanti.Baglan())
			{
				sql.Open();

				string sorgu = "SELECT * FROM Musteriler WHERE MusteriId = @musteriId";

				using (SqlCommand komut = new SqlCommand(sorgu, sql))
				{
					komut.Parameters.AddWithValue("@musteriId", _gelenMusteriId);

					using (SqlDataReader dr = komut.ExecuteReader())
					{
						if (dr.Read())
						{
							txtMusteriAd.Text = dr["Ad"].ToString();
							txtMusteriSoyad.Text = dr["Soyad"].ToString();
							txtMusteriAdres.Text = dr["Adres"].ToString();
							txtMusteriMail.Text = dr["Mail"].ToString();
							txtMusteriTelefon.Text = dr["Telefon"].ToString();
						}
					}
				}
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtMusteriAd.Text) && !string.IsNullOrEmpty(txtMusteriSoyad.Text) && !string.IsNullOrEmpty(txtMusteriAdres.Text) && !string.IsNullOrEmpty(txtMusteriMail.Text) && !string.IsNullOrEmpty(txtMusteriTelefon.Text))
			{
				using (SqlConnection sql = SqlBaglanti.Baglan())
				{
					sql.Open();

					string sorgu = "UPDATE Musteriler SET Ad = @ad , Soyad = @soyad , Telefon = @telefon , Mail = @mail , Adres = @adres WHERE MusteriId = @musteriId";

					using (SqlCommand komut = new SqlCommand(sorgu, sql))
					{
						komut.Parameters.AddWithValue("@ad", txtMusteriAd.Text);
						komut.Parameters.AddWithValue("@soyad", txtMusteriSoyad.Text);
						komut.Parameters.AddWithValue("@mail", txtMusteriMail.Text);
						komut.Parameters.AddWithValue("@adres", txtMusteriAdres.Text);
						komut.Parameters.AddWithValue("@telefon", txtMusteriTelefon.Text);
						komut.Parameters.AddWithValue("@musteriId", _gelenMusteriId);

						komut.ExecuteNonQuery();

						MessageBox.Show("Müşteri bilgileri başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			else
			{
				MessageBox.Show("Lütfen ilgili yerleri doldurunuz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void btnIptal_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
