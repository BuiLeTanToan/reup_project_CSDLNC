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
    public partial class ThongKeLuong_NhanSu : Form
    {
        SqlConnection connecttion;
        string connect_string = "Data Source=DESKTOP-D1C2UFI;Initial Catalog=CONCUNG;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public ThongKeLuong_NhanSu()
        {
            InitializeComponent();
        }

        private void ThongKeLuong_NhanSu_Load(object sender, EventArgs e)
        {
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT nv.MaNV as N'Mã nhân viên', nv.TenNV as N'Tên nhân viên', SUM((dh.TongTienDH * 0.1) + 6000000) as N'Doanh Thu' FROM NhanVien nv, DonHang dh WHERE dh.MaNV = nv.MaNV GROUP BY nv.MaNV, nv.TenNV", connecttion);    //cau truy van
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            dataGridView1.DataSource = table;       //va show len gridview
            dataGridView1.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThongKeLuong_NhanSu_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT nv.MaNV as N'Mã nhân viên', nv.TenNV as N'Tên nhân viên', SUM((dh.TongTienDH * 0.1) + 6000000) as N'Doanh Thu' FROM NhanVien nv, DonHang dh WHERE dh.MaNV = nv.MaNV and dh.MaNV = @manv GROUP BY nv.MaNV, nv.TenNV", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@manv", maNV.Text);
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            dataGridView1.DataSource = table;       //va show len gridview
            dataGridView1.ReadOnly = true;
        }
    }
}
