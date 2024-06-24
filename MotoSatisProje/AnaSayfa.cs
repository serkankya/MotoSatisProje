using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoSatisProje
{
	public partial class AnaSayfa : Form
	{
		public AnaSayfa()
		{
			InitializeComponent();
		}

		private void btnToptanciKaydi_Click(object sender, EventArgs e)
		{
			ToptanciKayit toptanciKayit = new ToptanciKayit();
			toptanciKayit.Show();
			this.Hide();
		}

		private void btnUrunKayit_Click(object sender, EventArgs e)
		{
			UrunKayit urunKayit = new UrunKayit();
			urunKayit.Show();
			this.Hide();
		}

		private void btnCalisanKayit_Click(object sender, EventArgs e)
		{
			CalisanKayit calisanKayit = new CalisanKayit();
			calisanKayit.Show();
			this.Hide();
		}

		private void btnSatisYap_Click(object sender, EventArgs e)
		{
			SatisYap satisYap = new SatisYap();
			satisYap.Show();
			this.Hide();
		}
	}
}
