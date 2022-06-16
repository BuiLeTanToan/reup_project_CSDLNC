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
    public partial class DanhSachNhanVien_NhanSU : Form
    {
        SqlConnection connecttion;
        string connect_string = "Data Source=DESKTOP-D1C2UFI;Initial Catalog=CONCUNG;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public DanhSachNhanVien_NhanSU()
        {
            InitializeComponent();
        }

        private void DanhSachNhanVien_NhanSU_Load(object sender, EventArgs e)
        {
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT nv.MaNV as N'Mã nhân viên', nv.TenNV as N'Tên nhân viên', nv.SdtNV as N'Số điện thoại', nv.DiaChiNV as N'Địa chỉ', nv.GioiTinhNV as N'Giới tính', nv.SoCMNDNV as N'Số CMND/CCCD', nv.SoTKNV as N'Số tài khoản', nv.MaCN as N'Mã chi nhánh' FROM NhanVien nv", connecttion);    //cau truy van
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            dataGridView1.DataSource = table;       //va show len gridview
            dataGridView1.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DanhSachNhanVien_NhanSU_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT nv.MaNV as N'Mã nhân viên', nv.TenNV as N'Tên nhân viên', nv.SdtNV as N'Số điện thoại', nv.DiaChiNV as N'Địa chỉ', nv.GioiTinhNV as N'Giới tính', nv.SoCMNDNV as N'Số CMND/CCCD', nv.SoTKNV as N'Số tài khoản', nv.MaCN as N'Mã chi nhánh' FROM NhanVien nv WHERE nv.MaNV = @manv", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@manv", maTraCuu.Text);        //dung parameter de bao mat data
            cmd.ExecuteNonQuery();
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
            maNhanVien.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            maNhanVien.ReadOnly = true;
            tenNhanVien.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            SoDT.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            diaChi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            gioiTinh.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            CMND.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            STK.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            maChiNhanh.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO NhanVien(TenNV, SdtNV, DiaChiNV, GioiTinhNV, SoCMNDNV, SoTKNV, MaCN) VALUES ('" + tenNhanVien.Text + "', '" + SoDT.Text + "', '" + diaChi.Text + "', '" + gioiTinh.Text + "', '" + CMND.Text + "', '" + STK.Text + "', '" + maChiNhanh.Text + "')", connecttion);    //cau truy van
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM NhanVien WHERE MaNV = @manv", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@manv", maNhanVien.Text);
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET TenNV = '" + tenNhanVien.Text + "', SdtNV = '" + SoDT.Text + "', DiaChiNV = '" + diaChi.Text + "', GioiTinhNV = '" + gioiTinh.Text + "', SoCMNDNV = '" + CMND.Text + "', SoTKNV =  '" + STK.Text + "', MaCN = '" + maChiNhanh.Text + "' WHERE MaNV = '" + maNhanVien.Text + "'", connecttion);    //cau truy van
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
        }
    }
}
