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
	public partial class UrunBilgisiGuncelle : Form
	{
		int _secilenUrunId;
		public UrunBilgisiGuncelle(int secilenUrunId)
		{
			InitializeComponent();
			_secilenUrunId = secilenUrunId;
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

		private void UrunBilgisiGuncelle_Load(object sender, EventArgs e)
		{
			ToptancilariListele();

			using (SqlConnection sql = SqlBaglanti.Baglan())
			{
				sql.Open();

				string sorgu = "SELECT * FROM Urunler WHERE UrunId = @urunId";

				using (SqlCommand komut = new SqlCommand(sorgu, sql))
				{
					komut.Parameters.AddWithValue("@urunId", _secilenUrunId);

					using (SqlDataReader dr = komut.ExecuteReader())
					{
						if (dr.Read())
						{
							txtUrunAdi.Text = dr["UrunAdi"].ToString();
							txtAciklama.Text = dr["Aciklama"].ToString();
							numFiyat.Value = Convert.ToDecimal(dr["Fiyat"]);
							numStok.Value = Convert.ToInt32(dr["Stok"]);
							cmbToptanci.SelectedValue = dr["ToptanciId"].ToString();
						}
					}
				}
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtAciklama.Text) && !string.IsNullOrEmpty(txtUrunAdi.Text))
			{
				using (SqlConnection sql = SqlBaglanti.Baglan())
				{
					sql.Open();

					string sorgu = "UPDATE Urunler SET ToptanciId = @toptanciId , Fiyat = @fiyat , Aciklama = @aciklama, Stok = @stok , UrunAdi = @urunAd WHERE UrunId = @urunId";

					using (SqlCommand komut = new SqlCommand(sorgu, sql))
					{
						komut.Parameters.AddWithValue("@toptanciId", cmbToptanci.SelectedValue);
						komut.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(numFiyat.Value));
						komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
						komut.Parameters.AddWithValue("@stok", numStok.Value);
						komut.Parameters.AddWithValue("@urunAd", txtUrunAdi.Text);
						komut.Parameters.AddWithValue("@urunId", _secilenUrunId);

						komut.ExecuteNonQuery();
						MessageBox.Show("Ürün bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();
					}
				}
			}
			else
			{
				MessageBox.Show("Lütfen ilgili yerleri doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnIptalEt_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
