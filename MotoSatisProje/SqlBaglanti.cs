using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoSatisProje
{
	public static class SqlBaglanti
	{
		private static string BaglantiAdresi = "Data Source=SERKANKAYA;Initial Catalog=MotoSatisDeneme;Integrated Security=True;MultipleActiveResultSets=True";

		public static SqlConnection Baglan()
		{
			return new SqlConnection(BaglantiAdresi);
		}
	}
}
