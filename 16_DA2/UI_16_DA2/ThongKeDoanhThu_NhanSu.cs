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
    public partial class ThongKeDoanhThu_NhanSu : Form
    {
        SqlConnection connecttion;
        string connect_string = "Data Source=DESKTOP-D1C2UFI;Initial Catalog=CONCUNG;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public ThongKeDoanhThu_NhanSu()
        {
            InitializeComponent();
        }

        private void ThongKeDoanhThu_NhanSu_Load(object sender, EventArgs e)
        {
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT nv.MaNV as N'Mã nhân viên', nv.TenNV as N'Tên nhân viên', SUM(dh.TongTienDH) as N'Doanh Thu' FROM NhanVien nv, DonHang dh WHERE dh.MaNV = nv.MaNV GROUP BY nv.MaNV, nv.TenNV", connecttion);    //cau truy van
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            dataGridView1.DataSource = table;       //va show len gridview
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            ctdtNV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT nv.MaNV as N'Mã nhân viên', nv.TenNV as N'Tên nhân viên', SUM(dh.TongTienDH) as N'Doanh Thu' FROM NhanVien nv, DonHang dh WHERE dh.MaNV = nv.MaNV AND nv.MaNV = @maNV GROUP BY nv.MaNV, nv.TenNV", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@maNV", maNV.Text);
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            dataGridView1.DataSource = table;       //va show len gridview
            dataGridView1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM DonHang dh where dh.MaNV = @maNV", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@maNV", ctdtNV.Text);
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            dataGridView2.DataSource = table;       //va show len gridview
            dataGridView2.ReadOnly = true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            maDH.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietDonHang ct where ct.MaDH = @madh", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@madh", maDH.Text);
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            dataGridView3.DataSource = table;       //va show len gridview
            dataGridView3.ReadOnly = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThu_NhanSu_Load(sender, e);
        }
    }
}
