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
        string connect_string = "Data Source=DESKTOP-D1C2UFI;Initial Catalog=16_DA1_DB;Integrated Security=True";
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

        private void XuatHoaDon_MaHD_Click(object sender, EventArgs e)
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

        private void XuatHoaDon_All_Click(object sender, EventArgs e)
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
    }
}
