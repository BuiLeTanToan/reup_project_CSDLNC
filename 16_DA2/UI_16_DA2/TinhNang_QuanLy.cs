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
    public partial class TinhNang_QuanLy : Form
    {
        public TinhNang_QuanLy()
        {
            InitializeComponent();
        }

        private void btn_QuanlyDT_Click(object sender, EventArgs e)
        {
            QuanLyDoanhThu_QuanLy buff = new QuanLyDoanhThu_QuanLy();
            buff.Show();
        }
       
        private void btn_QuanlyKM_Click(object sender, EventArgs e)
        {
            QuanLyKhuyenMai_QuanLy buff = new QuanLyKhuyenMai_QuanLy();
            buff.Show();
        }

        private void btn_QuanlyKN_Click(object sender, EventArgs e)
        {

        }
    }
}
