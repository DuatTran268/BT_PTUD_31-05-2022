using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usingADO.NET
{
	public partial class frmQLSV : Form
	{
		private string ConnectionString;
		private List<SinhVien> DanhSachSV;
		private List<Lop> DanhSachLop;
		private string searchText = "Nhập tìm kiếm";

		public frmQLSV()
		{
			InitializeComponent();
		}

		#region sự kiện khi hiển thị form
		private void frmQLSV_Load(object sender, EventArgs e)
		{
			DanhSachLop = new List<Lop>();
			DanhSachSV = new List<SinhVien>();
			ConnectionString = ConfigurationManager.ConnectionStrings["BT_QuanLySinhVien"].ConnectionString;
			DocDanhSachSV();
			DocDanhSachLop();
			TextSearchDefault();
			LoadListView(DanhSachSV);
		}

		// doc danh sach lop tu database
		private void DocDanhSachLop()
		{
			var connnection = new SqlConnection(ConnectionString);
			var cmd = connnection.CreateCommand();
			cmd.CommandText = "SELECT * FROM Lop";
			var adapter = new SqlDataAdapter(cmd);
			var table = new DataTable("Lop");
			connnection.Open();
			adapter.Fill(table);
			connnection.Close();
			foreach (DataRow row in table.Rows)
			{
				DanhSachLop.Add(new Lop(row));
			}

			// hiển thị danh sách lớp trên combobox lớp
			cboClass.DisplayMember = "TenLop";
			cboClass.ValueMember = "ID";
			cboClass.DataSource = DanhSachLop;
		}

		// doc danh sach sinh vien tu database
		private void DocDanhSachSV()
		{
			//SqlConnection connection = new SqlConnection(ConnectionString);
			//SqlCommand cmd = connection.CreateCommand();

			var connection = new SqlConnection(ConnectionString);
			var cmd = connection.CreateCommand();
			cmd.CommandText = "SELECT * FROM SinhVien";
			var adapter = new SqlDataAdapter(cmd);
			var table = new DataTable("SinhVien");

			// mở kết nối cơ sở dữ liệu
			connection.Open();
			adapter.Fill(table);
			connection.Close();

			// hiển thị danh sách sinh viên trên listview
			foreach (DataRow row in table.Rows)
			{
				DanhSachSV.Add(new SinhVien(row));
			}

		}
		private void LoadListView(List<SinhVien> danhSachSV)
		{
			lvDSSinhVien.Items.Clear();
			foreach (var sv in danhSachSV)
			{
				ThemSinhVienVaoLV(sv);
			}

		}


		// thiết lập giá trị và thêm sự kiện cho text box tìm kiếm
		private void TxtSearchGotFocus(object sender, EventArgs e)
		{
			txtSearch.Text = "";
		}
		private void TxtSearchLostFocus(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(txtSearch.Text))
			{
				txtSearch.Text = searchText;
				btnReset.PerformClick();
			}
		}
		private void TextSearchDefault()
		{
			txtSearch.Text = searchText;
			txtSearch.GotFocus += TxtSearchGotFocus;
			txtSearch.LostFocus += TxtSearchLostFocus;
		}

		private SinhVien GetSinhVien()
		{
			var sv = new SinhVien();
			if (!string.IsNullOrWhiteSpace(txtFullNameSV.Text))
			{
				sv.HoTen = txtFullNameSV.Text;
				sv.ID = string.IsNullOrWhiteSpace(txtID.Text)
					? -1 : int.Parse(txtID.Text);
				sv.IdLop = Convert.ToInt32(cboClass.SelectedValue);
			}
			return sv;
		}

		
		#endregion


		#region Các sự kiện xử lý (button)
		private void btnReset_Click(object sender, EventArgs e)
		{
			DanhSachSV = new List<SinhVien>();
			this.txtID.Text = "";
			this.txtFullNameSV.Text = "";
		}
		private void btnReload_Click(object sender, EventArgs e)
		{
			// sau mỗi lần reset ko bị lặp lại danh sách sinh viên
			DanhSachSV = new List<SinhVien>();
			DocDanhSachSV();
			LoadListView(DanhSachSV);
		}

		private void ThemSinhVienVaoLV(SinhVien sv)
		{
			// cách 1
			//ListViewItem lvitem = new ListViewItem(sv.ID.ToString());
			//lvitem.SubItems.Add(sv.HoTen);
			//lvitem.SubItems.Add(layTenLopSV(sv.IdLop).ToString());
			//lvDSSinhVien.Items.Add(lvitem);
		
			// cách 2
			string[] row = { sv.ID.ToString(), sv.HoTen, layTenLopSV(sv.IdLop).ToString() };
			var item = new ListViewItem(row);
			lvDSSinhVien.Items.Add(item);

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var sinhvien = GetSinhVien();
			if (sinhvien != null)
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
				return;
			}
			var connection = new SqlConnection(ConnectionString);
			var cmd = connection.CreateCommand();
			if (sinhvien.ID < 0)
			{
				cmd.CommandText = "EXEC InsertStudent @HoTen, @Lop";
			}
			else
			{
				// ton tai id roi thi thuc hien update
				cmd.CommandText = "UPDATE SinhVien SET Ten = @HoTen, MaLop = @Lop WHERE Id = @Id";
			}
			cmd.Parameters.AddWithValue("@HoTen", sinhvien.HoTen);
			cmd.Parameters.AddWithValue("@Lop", sinhvien.IdLop);
			cmd.Parameters.AddWithValue("@Id", sinhvien.ID);

			// mo ket noi csdl
			connection.Open();
			var result = cmd.ExecuteNonQuery();
			if (result > 0)
			{
				btnReset.PerformClick();
			}
			connection.Close();
		}
		private void lvDSSinhVien_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvDSSinhVien.SelectedItems.Count > 0)
			{
				var id = int.Parse(lvDSSinhVien.SelectedItems[0].Text);
				var sinhvien = DanhSachSV.FirstOrDefault(sv => sv.ID == id);
				ThongTinThietLap(sinhvien);
			}
		}
		private void ThongTinThietLap(SinhVien sv)
		{
			txtFullNameSV.Text = sv.HoTen;
			txtID.Text = sv.ID.ToString();
			cboClass.SelectedValue = sv.IdLop;
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			if (!String.IsNullOrWhiteSpace(txtSearch.Text))
			{
                var resultList = DanhSachSV.Where(sv => sv.HoTen.IndexOf(txtSearch.Text, StringComparison.InvariantCultureIgnoreCase) > 1).ToList();
				LoadListView(resultList);
			}
			else
			{
				LoadListView(DanhSachSV);
			}
		}
		private string layTenLopSV(int maLop)
		{

			Lop found = DanhSachLop.Find(l => l.ID == maLop);
			if (found != null)
			{
				return found.TenLop;
			}
			return "";
		}

		#endregion
		

	}
}
