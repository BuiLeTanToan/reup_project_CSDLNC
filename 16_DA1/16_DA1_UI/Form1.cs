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

namespace UI_DA1
{
    public partial class Form1 : Form
    {
        SqlConnection connecttion;
        string connect_string = @"Data Source=DESKTOP-D1C2UFI;Initial Catalog=N16_DA1_DB;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void XuatHoaDon_MaKH_Click(object sender, EventArgs e) //chuc nang xem don hang theo ma khach hang
        {
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDon hd WHERE hd.MaKH = @makh", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@makh", MaKH.Text);        //dung parameter de bao mat data
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            dataGridView1.DataSource = table;       //va show len gridview
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            cmd = new SqlCommand("SELECT * FROM CT_HoaDon chd, HoaDon hd WHERE hd.MaHD = chd.MaHD AND hd.MaKH = @makh", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@makh", MaKH.Text);        //dung parameter de bao mat data
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            dataGridView2.DataSource = table;       //va show len gridview
        }

        private void XuatHoaDon_MaHD_Click(object sender, EventArgs e)      //chuc nang xem don hang theo ma hoa don
        {
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDon hd WHERE hd.MaHD = @mahd", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@mahd", MaHD.Text);        //dung parameter de bao mat data
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            dataGridView1.DataSource = table;       //va show len gridview
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            cmd = new SqlCommand("SELECT * FROM CT_HoaDon chd, HoaDon hd WHERE hd.MaHD = chd.MaHD AND hd.MaHD = @mahd", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@mahd", MaHD.Text);        //dung parameter de bao mat data
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            dataGridView2.DataSource = table;       //va show len gridview
        }

        private void XuatHoaDon_All_Click(object sender, EventArgs e)   //Xuat tat ca hoa don va chi tiet hoa don
        {
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDon hd", connecttion);    //cau truy van
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            dataGridView1.DataSource = table;       //va show len gridview
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            cmd = new SqlCommand("SELECT * FROM CT_HoaDon chd", connecttion);    //cau truy van
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            dataGridView2.DataSource = table;       //va show len gridview
        }

        private void button4_Click(object sender, EventArgs e)      //chuc nang thong ke doanh thu theo thang
        {
            connecttion = new SqlConnection(connect_string);        //mo connection toi sql
            connecttion.Open();
            //cau truy van
            SqlCommand cmd = new SqlCommand("SELECT MONTH(hd.NgayLap) as Tháng, SUM(CAST(hd.TongTien as bigint)) as DoanhThu from HoaDon hd WHERE YEAR(hd.NgayLap) = @year GROUP BY MONTH(hd.NgayLap) ORDER BY MONTH(hd.NgayLap) ASC", connecttion);
            cmd.Parameters.AddWithValue("@year", textBox1.Text);        
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            chart1.Series["Vnd"].XValueMember = "Tháng";        //hien thi du lieu da truy van duoi dang bang thong ke
            chart1.Series["Vnd"].YValueMembers = "DoanhThu";
            chart1.DataSource = table;
            chart1.DataBind();
            dataGridView1.DataSource = table;       //show len gridview
        }

        private void button5_Click(object sender, EventArgs e)      //chuc nang them hoa don
        {
            connecttion = new SqlConnection(connect_string);        //mo connection toi sql
            connecttion.Open();
            //cau truy van
            SqlCommand cmd = new SqlCommand("INSERT INTO HOADON(MaHD, MaKH, NgayLap) VALUES ('" + tb_MaHD.Text + "', '" + tb_MaKH.Text + "', '" + tb_NgayLap.Text + "')", connecttion);
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            //sau buoc nay, neu muon kiem tra xem hoa don da duoc them vao bang HoaDon hay chua,
            //ta co them nhan nut Xem Hoa Don (da thuc hien o chuc nang phia tren)
        }

        private void button6_Click(object sender, EventArgs e)      //chuc nang them chi tiet hoa don
        {
            connecttion = new SqlConnection(connect_string);        //mo connection toi sql
            connecttion.Open();
            //cau truy van
            SqlCommand cmd = new SqlCommand ("INSERT INTO CT_HoaDon(MaHD, MaSP, Soluong, GiaGiam) VALUES ('" + tb_MaHoaDon.Text + "', '" + tb_MaSanPham.Text + "', '" + tb_SoLuong.Text + "', '" + tb_giaGiam.Text + "')", connecttion);
            cmd.ExecuteNonQuery();
            connecttion.Close();     //dong connection
            //sau buoc nay, neu muon kiem tra xem chi tiet hoa don da duoc them vao bang CT_HoaDon hay chua,
            //ta co them nhan nut Xem Hoa Don (da thuc hien o chuc nang phia tren)
        }
    }
}
