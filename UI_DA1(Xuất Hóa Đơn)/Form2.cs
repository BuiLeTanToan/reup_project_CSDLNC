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
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlDataAdapter adp;
        SqlCommand cb;

        DataSet ds;
        DataTable dt;
        DataRow dr;

        String year;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.year = textBox1.Text;
            conn = new SqlConnection();
            conn.ConnectionString =
              "Data Source=LAPTOP-QF22927O;" +
              "Initial Catalog=retail_management;" +
              "User id=sa;" +
              "Password=1;";

            adp = new SqlDataAdapter();
            ds = new DataSet();

            adp.SelectCommand = new SqlCommand("SELECT MONTH(ngay_lap) as Thang, SUM(tong_tien) as Doanh_thu " +
                "from hoa_don WHERE YEAR(ngay_lap)= "+ this.year +
                "GROUP BY MONTH(ngay_lap) " +
                "ORDER BY MONTH(ngay_lap) ASC", conn);

            adp.Fill(ds, "data");

            chart1.Series["Vnd"].XValueMember = "Thang";
            chart1.Series["Vnd"].YValueMembers = "Doanh_thu";
            chart1.DataSource = ds.Tables["data"];
            chart1.DataBind();
            dataGridView1.DataSource = ds.Tables["data"];
            
        }
    }
}
