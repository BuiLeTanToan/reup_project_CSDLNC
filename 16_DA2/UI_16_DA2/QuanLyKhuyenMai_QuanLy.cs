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
    public partial class QuanLyKhuyenMai_QuanLy : Form
    {
        SqlConnection connecttion;
        string connect_string = @"Data Source=DESKTOP-VM7ED4K\SQLEXPRESS;Initial Catalog=CONCUNG;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public QuanLyKhuyenMai_QuanLy()
        {
            InitializeComponent();
        }
        void LoadDanhSachSanPham()
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            command = connecttion.CreateCommand();
            command.CommandText = "SELECT * FROM KhuyenMai";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_DanhSachKM.DataSource = table;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            SqlCommand command2;
            command2 = connecttion.CreateCommand();
            command2.CommandText = "INSERT INTO KhuyenMai(MgayBatDauKM, NgayKetThucKM, SoTienGiam) values ('" + tb_NgayBD.Text + "', '" + tb_NgayKT.Text + "', '" + Convert.ToInt32(tb_Giam.Text) + "')";
            command2.ExecuteNonQuery();
            MessageBox.Show("Thêm khuyến mãi thành công!");
            LoadDanhSachSanPham();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            SqlCommand command3;
            command3 = connecttion.CreateCommand();
            command3.CommandText = "UPDATE SanPham SET NgayBatDauKM = '" + tb_NgayBD.Text + "', SoTienGiam = '" + Convert.ToInt32(tb_Giam.Text) + "' WHERE MaKhuyenMai = '" + Convert.ToInt32(tb_MaKM.Text) + "'";
            command3.ExecuteNonQuery();
            MessageBox.Show("Cập nhật khuyến mãi thành công!");
            LoadDanhSachSanPham();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            SqlCommand command4;
            command4 = connecttion.CreateCommand();
            command4.CommandText = "DELETE FROM KhuyenMai WHERE MaKhuyenMai = '" + Convert.ToInt32(tb_MaKM.Text) + "'";
            command4.ExecuteNonQuery();
            MessageBox.Show("Xoá khuyến mãi thành công!");
            LoadDanhSachSanPham();
        }
        private void QuanLyKhuyenMai_QuanLy_Load(object sender, EventArgs e)
        {
            connecttion = new SqlConnection(connect_string);
            connecttion.Open();
            LoadDanhSachSanPham();
        }
    }
}
