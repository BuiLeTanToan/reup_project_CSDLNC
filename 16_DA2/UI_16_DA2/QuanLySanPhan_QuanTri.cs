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
    public partial class QuanLySanPhan_QuanTri : Form
    {
        SqlConnection connection;
        string str = "Data Source=DESKTOP-JNCQFSF;Initial Catalog=CONCUNG;Integrated Security=True";

        public QuanLySanPhan_QuanTri()
        {
            InitializeComponent();
        }

        void LoadDanhSachSanPham()
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM SanPham";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_DanhSachSP.DataSource = table;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SqlCommand command2;
            command2= connection.CreateCommand();
            command2.CommandText = "INSERT INTO SanPham(TenSP, GiaSP, MoTaSP, LoaiSP) values ('" + tb_TenSP.Text + "', '" + Convert.ToInt32(tb_GiaSP.Text) + "', '" + tb_MoTaSP.Text + "', '" + tb_LoaiSP.Text + "')";
            command2.ExecuteNonQuery();
            MessageBox.Show("Thêm sản phẩm thành công!");
            LoadDanhSachSanPham();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            SqlCommand command3;
            command3 = connection.CreateCommand();
            command3.CommandText = "UPDATE SanPham SET TenSP = '" + tb_TenSP.Text + "', GiaSP = '" + Convert.ToInt32(tb_GiaSP.Text) + "', MoTaSP = '" + tb_MoTaSP.Text + "', LoaiSP = '" + tb_LoaiSP.Text + "' WHERE MaSP = '" + Convert.ToInt32(tb_MaSP.Text) + "'";
            command3.ExecuteNonQuery();
            MessageBox.Show("Cập nhật sản phẩm thành công!");
            LoadDanhSachSanPham();
        }
            
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            SqlCommand command4;
            command4 = connection.CreateCommand();
            command4.CommandText = "DELETE FROM SanPham WHERE MaSP = '"+Convert.ToInt32(tb_MaSP.Text) +"'";
            command4.ExecuteNonQuery();
            MessageBox.Show("Xoá sản phẩm thành công!");
            LoadDanhSachSanPham();
        }

        private void QuanLySanPhan_QuanTri_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadDanhSachSanPham();
        }
    }
}
