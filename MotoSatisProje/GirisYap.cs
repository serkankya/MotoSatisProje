using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoSatisProje
{
	public partial class GirisYap : Form
	{
		public GirisYap()
		{
			InitializeComponent();
		}

		private void btnGirisYap_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtKullaniciAdi.Text) && !string.IsNullOrEmpty(txtSifre.Text))
			{
				using (SqlConnection sql = SqlBaglanti.Baglan())
				{
					sql.Open();

					string sorgu = "SELECT * FROM YetkiliGiris WHERE KullaniciAdi = @k_adi AND Sifre = @sifre";
					using (SqlCommand komut = new SqlCommand(sorgu, sql))
					{
						komut.Parameters.AddWithValue("@k_adi", txtKullaniciAdi.Text);
						komut.Parameters.AddWithValue("@sifre", txtSifre.Text);

						using (SqlDataReader dr = komut.ExecuteReader())
						{
							if (dr.Read())
							{
								MessageBox.Show("Moto Satış'a hoş geldiniz!", "Hoş Geldiniz", MessageBoxButtons.OK, MessageBoxIcon.Information);
								AnaSayfa anaSayfa = new AnaSayfa();
								anaSayfa.Show();
								this.Hide();
							}
							else
							{
								MessageBox.Show("Hatalı kullanıcı adı veya şifre! Tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void GirisYap_Load(object sender, EventArgs e)
		{
			txtKullaniciAdi.Text = "Tester";
			txtSifre.Text = "tester_74";
		}
	}
}
