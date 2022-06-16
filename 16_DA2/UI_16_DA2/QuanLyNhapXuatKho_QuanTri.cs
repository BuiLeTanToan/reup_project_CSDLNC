using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UI_16_DA2
{
    public partial class QuanLyNhapXuatKho_QuanTri : Form
    {
        SqlConnection connection;
        string str = "Data Source=DESKTOP-JNCQFSF;Initial Catalog=CONCUNG;Integrated Security=True";
        public QuanLyNhapXuatKho_QuanTri()
        {
            InitializeComponent();
        }

        void LichSuNhapHang()
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "SELECT PXNK.MaKho, CT.MaSP, CT.SoLuong, CT.DonGia FROM PhieuNhapXuatKho PXNK JOIN ChiTietPNXK CT ON PXNK.MaPNXK = CT.MaPNXK WHERE PXNK.MaKho='" + Convert.ToInt32(tb_MaKhoNX) + "'AND PXNK.Loai=0";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_NhapHang.DataSource = table;
        }

        void LichSuXuatHang()
        {
            SqlCommand command2;
            SqlDataAdapter adapter2 = new SqlDataAdapter();
            DataTable table2 = new DataTable();
            command2 = connection.CreateCommand();
            command2.CommandText = "SELECT PXNK.MaKho, CT.MaSP, CT.SoLuong, CT.DonGia FROM PhieuNhapXuatKho PXNK JOIN ChiTietPNXK CT ON PXNK.MaPNXK = CT.MaPNXK WHERE PXNK.MaKho='" + Convert.ToInt32(tb_MaKhoNX) + "'AND PXNK.Loai=1";
            adapter2.SelectCommand = command2;
            table2.Clear();
            adapter2.Fill(table2);
            dgv_XuatHang.DataSource = table2;
        }
        private void btn_TheoDoiNX_Click(object sender, EventArgs e)
        {
            LichSuNhapHang();
            LichSuXuatHang();
        }

        private void QuanLyNhapXuatKho_QuanTri_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
        }
    }
}
