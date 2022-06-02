using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingADO.NET
{
	public class Lop
	{
		public int ID { get; set; }
		public string TenLop { get; set; }

		public Lop(int id, string tenlop)
		{
			this.ID = id;
			this.TenLop = tenlop;
		}

		public Lop(DataRow row)
		{
			ID = Convert.ToInt32(row["ID"]);
			TenLop = row["TenLop"].ToString();
		}

	}
}
