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
	public partial class CalisanBilgisiGuncelle : Form
	{
		int _secilenCalisanId;
		public CalisanBilgisiGuncelle(int secilenCalisanId)
		{
			InitializeComponent();
			_secilenCalisanId = secilenCalisanId;
		}

		private void CalisanBilgisiGuncelle_Load(object sender, EventArgs e)
		{
			using (SqlConnection sql = SqlBaglanti.Baglan())
			{
				sql.Open();

				string sorgu = "SELECT * FROM Calisanlar WHERE CalisanId = @calisanId";

				using (SqlCommand komut = new SqlCommand(sorgu, sql))
				{
					komut.Parameters.AddWithValue("@calisanId", _secilenCalisanId);

					using (SqlDataReader dr = komut.ExecuteReader())
					{
						if (dr.Read())
						{
							txtAd.Text = dr["Ad"].ToString();
							txtSoyad.Text = dr["Soyad"].ToString();
							txtMail.Text = dr["Mail"].ToString();
							txtTelefon.Text = dr["Telefon"].ToString();
							cmbPozisyon.Text = dr["Pozisyon"].ToString();
						}
					}
				}
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtMail.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtTelefon.Text) && !string.IsNullOrEmpty(cmbPozisyon.Text))
			{
				using (SqlConnection sql = SqlBaglanti.Baglan())
				{
					sql.Open();

					string sorgu = "UPDATE Calisanlar SET Pozisyon = @pozisyon,Ad=@ad,Soyad=@ad,Telefon=@telefon,Mail=@mail WHERE CalisanId = @calisanId";

					using (SqlCommand komut = new SqlCommand(sorgu, sql))
					{
						komut.Parameters.AddWithValue("@pozisyon", cmbPozisyon.SelectedItem);
						komut.Parameters.AddWithValue("@ad", txtAd.Text);
						komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
						komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
						komut.Parameters.AddWithValue("@mail", txtMail.Text);
						komut.Parameters.AddWithValue("@calisanId", _secilenCalisanId);

						komut.ExecuteNonQuery();

						MessageBox.Show("Çalışan kaydı başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();
					}
				}
			}
			else
			{
				MessageBox.Show("Lütfen ilgili yerleri doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
