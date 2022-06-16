
namespace UI_DA1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MaHD = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tb_MaHD = new System.Windows.Forms.TextBox();
            this.tb_MaKH = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tb_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.tb_MaHoaDon = new System.Windows.Forms.TextBox();
            this.tb_MaSanPham = new System.Windows.Forms.TextBox();
            this.tb_SoLuong = new System.Windows.Forms.TextBox();
            this.tb_giaGiam = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.áda = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xuất Hóa Đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.XuatHoaDon_MaKH_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(706, 109);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaKH
            // 
            this.MaKH.Location = new System.Drawing.Point(158, 373);
            this.MaKH.MaxLength = 10;
            this.MaKH.Name = "MaKH";
            this.MaKH.Size = new System.Drawing.Size(130, 22);
            this.MaKH.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập mã khách hàng";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 177);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(706, 150);
            this.dataGridView2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hóa Đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chi tiết hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Xuất hóa đơn theo mã khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Xuất hóa đơn theo mã hóa đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nhập mã hóa đơn";
            // 
            // MaHD
            // 
            this.MaHD.Location = new System.Drawing.Point(478, 373);
            this.MaHD.Name = "MaHD";
            this.MaHD.Size = new System.Drawing.Size(129, 22);
            this.MaHD.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 54);
            this.button2.TabIndex = 12;
            this.button2.Text = "Xuất hóa đơn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.XuatHoaDon_MaHD_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 477);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 60);
            this.button3.TabIndex = 13;
            this.button3.Text = "Xuất toàn bộ hóa đơn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.XuatHoaDon_All_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 602);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Chọn năm muốn thống kê";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 631);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 673);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Thống kê";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(195, 602);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Vnd";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(784, 300);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // tb_MaHD
            // 
            this.tb_MaHD.Location = new System.Drawing.Point(973, 64);
            this.tb_MaHD.Name = "tb_MaHD";
            this.tb_MaHD.Size = new System.Drawing.Size(110, 22);
            this.tb_MaHD.TabIndex = 17;
            // 
            // tb_MaKH
            // 
            this.tb_MaKH.Location = new System.Drawing.Point(973, 95);
            this.tb_MaKH.Name = "tb_MaKH";
            this.tb_MaKH.Size = new System.Drawing.Size(110, 22);
            this.tb_MaKH.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(789, 157);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Thêm hóa đơn";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tb_NgayLap
            // 
            this.tb_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tb_NgayLap.Location = new System.Drawing.Point(973, 125);
            this.tb_NgayLap.Name = "tb_NgayLap";
            this.tb_NgayLap.Size = new System.Drawing.Size(110, 22);
            this.tb_NgayLap.TabIndex = 21;
            // 
            // tb_MaHoaDon
            // 
            this.tb_MaHoaDon.Location = new System.Drawing.Point(973, 235);
            this.tb_MaHoaDon.Name = "tb_MaHoaDon";
            this.tb_MaHoaDon.Size = new System.Drawing.Size(110, 22);
            this.tb_MaHoaDon.TabIndex = 22;
            // 
            // tb_MaSanPham
            // 
            this.tb_MaSanPham.Location = new System.Drawing.Point(973, 264);
            this.tb_MaSanPham.Name = "tb_MaSanPham";
            this.tb_MaSanPham.Size = new System.Drawing.Size(110, 22);
            this.tb_MaSanPham.TabIndex = 23;
            // 
            // tb_SoLuong
            // 
            this.tb_SoLuong.Location = new System.Drawing.Point(973, 294);
            this.tb_SoLuong.Name = "tb_SoLuong";
            this.tb_SoLuong.Size = new System.Drawing.Size(110, 22);
            this.tb_SoLuong.TabIndex = 24;
            // 
            // tb_giaGiam
            // 
            this.tb_giaGiam.Location = new System.Drawing.Point(973, 327);
            this.tb_giaGiam.Name = "tb_giaGiam";
            this.tb_giaGiam.Size = new System.Drawing.Size(110, 22);
            this.tb_giaGiam.TabIndex = 25;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(789, 357);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "Thêm chi tiết";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // áda
            // 
            this.áda.AutoSize = true;
            this.áda.Location = new System.Drawing.Point(19, 559);
            this.áda.Name = "áda";
            this.áda.Size = new System.Drawing.Size(208, 17);
            this.áda.TabIndex = 27;
            this.áda.Text = "Thống kê doanh thu theo tháng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(786, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Thêm hóa đơn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(786, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Nhập mã hóa đơn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(786, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Nhập mã khách hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(786, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "Nhập ngày lập";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(786, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Thêm chi tiết hóa đơn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(786, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 17);
            this.label13.TabIndex = 33;
            this.label13.Text = "Nhập mã hóa đơn";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(786, 264);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 17);
            this.label14.TabIndex = 34;
            this.label14.Text = "Nhập mã sản phẩm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(786, 294);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 17);
            this.label15.TabIndex = 35;
            this.label15.Text = "Nhập số lượng";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(787, 327);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 17);
            this.label16.TabIndex = 36;
            this.label16.Text = "Nhập giá giảm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 912);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.áda);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tb_giaGiam);
            this.Controls.Add(this.tb_SoLuong);
            this.Controls.Add(this.tb_MaSanPham);
            this.Controls.Add(this.tb_MaHoaDon);
            this.Controls.Add(this.tb_NgayLap);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tb_MaKH);
            this.Controls.Add(this.tb_MaHD);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MaHD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaKH);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox MaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MaHD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox tb_MaHD;
        private System.Windows.Forms.TextBox tb_MaKH;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker tb_NgayLap;
        private System.Windows.Forms.TextBox tb_MaHoaDon;
        private System.Windows.Forms.TextBox tb_MaSanPham;
        private System.Windows.Forms.TextBox tb_SoLuong;
        private System.Windows.Forms.TextBox tb_giaGiam;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label áda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

