using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_16_DA2
{
    public partial class TinhNang_NhanSu : Form
    {
        public TinhNang_NhanSu()
        {
            InitializeComponent();
        }
        public string temp; //Biến này dùng để lấy tên đăng nhập khi quản lý nhân sự đăng nhập thành công
        private void TinhNang_NhanSu_Load(object sender, EventArgs e)
        {
            tenQuanLy.Text = temp;
            tenQuanLy.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DanhSachNhanVien_NhanSU f = new DanhSachNhanVien_NhanSU();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThu_NhanSu f1 = new ThongKeDoanhThu_NhanSu();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThongKeLuong_NhanSu f2 = new ThongKeLuong_NhanSu();
            f2.Show();
        }
    }
}
