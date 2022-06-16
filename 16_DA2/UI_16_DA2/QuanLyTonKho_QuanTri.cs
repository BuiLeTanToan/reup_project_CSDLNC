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
    public partial class QuanLyTonKho_QuanTri : Form
    {
        SqlConnection connection;
        string str = "Data Source=DESKTOP-JNCQFSF;Initial Catalog=CONCUNG;Integrated Security=True";
        public QuanLyTonKho_QuanTri()
        {
            InitializeComponent();
        }

        private void btn_TheoDoiTonKho_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "SELECT K.MaKho, K.TenKho, K.DiaChiKho, CT.MaSp, CT.SoLuong FROM KHO K JOIN ChiTietKho CT ON K.MaKho = CT.MaKho JOIN SanPham SP ON CT.MaSp = SP.MaSp WHERE K.MaKho = '"+Convert.ToInt32(tb_MaKho.Text) +"'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_DSSanPhamTonKho.DataSource = table;
        }

        private void QuanLyTonKho_QuanTri_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
        }
    }
}
