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
	public partial class MusteriBul : Form
	{
		public MusteriBul()
		{
			InitializeComponent();
		}

		private void txtAra_TextChanged(object sender, EventArgs e)
		{
			using (SqlConnection sql = SqlBaglanti.Baglan())
			{
				sql.Open();

				string sorgu = "SELECT * FROM Musteriler WHERE (Ad LIKE @ara OR Soyad LIKE @ara OR Telefon LIKE @ara OR Mail LIKE @ara)";

				using (SqlCommand komut = new SqlCommand(sorgu, sql))
				{
					komut.Parameters.AddWithValue("@ara", '%' +  txtAra.Text + '%');

					SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
					DataSet ds = new DataSet();
					dataAdapter.Fill(ds);

					dgwMusteriler.DataSource = ds.Tables[0];
				}
			}
		}

		public int _secilenMusteriId;
		private void dgwMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			_secilenMusteriId = Convert.ToInt32(dgwMusteriler.CurrentRow.Cells[0].Value);
		}

		private void btnTamamla_Click(object sender, EventArgs e)
		{
			if(_secilenMusteriId > 0)
			{
				this.Close();
			}
			else
			{
				MessageBox.Show("Lütfen geçerli bir müşteri seçiniz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void btnVerileriGuncelle_Click(object sender, EventArgs e)
		{
			if (_secilenMusteriId > 0)
			{
				MusteriBilgisiGuncelle musteriBilgisiGuncelle = new MusteriBilgisiGuncelle(_secilenMusteriId);
				musteriBilgisiGuncelle.ShowDialog();
			}
			else
			{
				MessageBox.Show("Lütfen geçerli bir müşteri seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
