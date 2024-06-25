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
	public partial class ToptanciBilgisiGuncelle : Form
	{
		int _secilenToptanciId;
		public ToptanciBilgisiGuncelle(int secilenToptanciId)
		{
			InitializeComponent();
			_secilenToptanciId = secilenToptanciId;
		}

		private void ToptanciBilgisiGuncelle_Load(object sender, EventArgs e)
		{
			using (SqlConnection sql = SqlBaglanti.Baglan())
			{
				sql.Open();

				string sorgu = "SELECT * FROM Toptancilar WHERE ToptanciId = @toptanciId";

				using (SqlCommand komut = new SqlCommand(sorgu, sql))
				{
					komut.Parameters.AddWithValue("@toptanciId", _secilenToptanciId);

					using (SqlDataReader dr = komut.ExecuteReader())
					{
						if (dr.Read())
						{
							txtFirmaAdi.Text = dr["FirmaAdi"].ToString();
							txtAdres.Text = dr["Adres"].ToString();
							txtMail.Text = dr["Mail"].ToString();
							txtTelefon.Text = dr["Telefon"].ToString();
						}
					}
				}
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtFirmaAdi.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtMail.Text) && !string.IsNullOrEmpty(txtTelefon.Text))
			{
				using (SqlConnection sql = SqlBaglanti.Baglan())
				{
					sql.Open();

					string sorgu = "UPDATE Toptancilar SET FirmaAdi = @firmaAdi , Adres = @adres , Mail = @mail , Telefon = @telefon WHERE ToptanciId = @toptanciId";

					using (SqlCommand komut = new SqlCommand(sorgu, sql))
					{
						komut.Parameters.AddWithValue("@firmaAdi", txtFirmaAdi.Text);
						komut.Parameters.AddWithValue("@adres", txtAdres.Text);
						komut.Parameters.AddWithValue("@mail", txtMail.Text);
						komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
						komut.Parameters.AddWithValue("@toptanciId", _secilenToptanciId);

						komut.ExecuteNonQuery();

						MessageBox.Show("Seçilen toptancı verileri başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();	
					}
				}
			}
			else
			{
				MessageBox.Show("Lütfen gerekli yerleri doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnIptalEt_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
