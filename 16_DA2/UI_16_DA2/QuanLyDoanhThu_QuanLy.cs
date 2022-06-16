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
    public partial class QuanLyDoanhThu_QuanLy : Form
    {
        SqlConnection connecttion;
        string connect_string = @"Data Source=DESKTOP-VM7ED4K\SQLEXPRESS;Initial Catalog=CONCUNG;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public QuanLyDoanhThu_QuanLy()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM DonHang dh where dh.MaCN = @maCN", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@maCN", ctdtCN.Text);
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            dataGridView2.DataSource = table;       //va show len gridview
            dataGridView2.ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT cn.MaCN as N'Mã chi nhánh', cn.TenCN as N'Tên chi nhánh', SUM(dh.TongTienDH) as N'Doanh Thu' FROM ChiNhanh cn, DonHang dh WHERE dh.MaCN = cn.MaCN AND cn.MaCN = @maCN GROUP BY cn.MaCN, cn.TenCN", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@maCN", maCN.Text);
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
            ctdtCN.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            maDH.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
        }
    }
}
