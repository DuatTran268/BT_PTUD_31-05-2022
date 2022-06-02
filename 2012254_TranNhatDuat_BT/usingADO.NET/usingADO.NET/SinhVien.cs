using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingADO.NET
{
	public class SinhVien
	{

		public int ID { get; set; }
		public string HoTen { get; set; }
		public int IdLop { get; set; }

		public SinhVien(int id, string hoten, int idlop)
		{
			this.ID = id;
			this.HoTen = hoten;
			this.IdLop = idlop;
		}

		public SinhVien(DataRow row)
		{
			ID = Convert.ToInt32(row["ID"]);
			HoTen = row["HoTen"].ToString();
			IdLop = Convert.ToInt32(row["MaLop"]);
		}

		public SinhVien()
		{
		}
	}
}
