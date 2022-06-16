namespace UI_16_DA2
{
    partial class QuanLyNhapXuatKho_QuanTri
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
            this.btn_TheoDoiNX = new System.Windows.Forms.Button();
            this.tb_MaKhoNX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_NhapHang = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_XuatHang = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhapHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XuatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TheoDoiNX
            // 
            this.btn_TheoDoiNX.Location = new System.Drawing.Point(217, 20);
            this.btn_TheoDoiNX.Name = "btn_TheoDoiNX";
            this.btn_TheoDoiNX.Size = new System.Drawing.Size(75, 23);
            this.btn_TheoDoiNX.TabIndex = 6;
            this.btn_TheoDoiNX.Text = "Theo dõi";
            this.btn_TheoDoiNX.UseVisualStyleBackColor = true;
            this.btn_TheoDoiNX.Click += new System.EventHandler(this.btn_TheoDoiNX_Click);
            // 
            // tb_MaKhoNX
            // 
            this.tb_MaKhoNX.Location = new System.Drawing.Point(89, 22);
            this.tb_MaKhoNX.Name = "tb_MaKhoNX";
            this.tb_MaKhoNX.Size = new System.Drawing.Size(100, 20);
            this.tb_MaKhoNX.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập mã kho";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_NhapHang);
            this.groupBox1.Location = new System.Drawing.Point(15, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 379);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lịch sử nhập hàng";
            // 
            // dgv_NhapHang
            // 
            this.dgv_NhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhapHang.Location = new System.Drawing.Point(6, 19);
            this.dgv_NhapHang.Name = "dgv_NhapHang";
            this.dgv_NhapHang.Size = new System.Drawing.Size(358, 354);
            this.dgv_NhapHang.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_XuatHang);
            this.groupBox2.Location = new System.Drawing.Point(409, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 379);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lịch sử xuất hàng";
            // 
            // dgv_XuatHang
            // 
            this.dgv_XuatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_XuatHang.Location = new System.Drawing.Point(6, 19);
            this.dgv_XuatHang.Name = "dgv_XuatHang";
            this.dgv_XuatHang.Size = new System.Drawing.Size(358, 354);
            this.dgv_XuatHang.TabIndex = 1;
            // 
            // QuanLyNhapXuatKho_QuanTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_TheoDoiNX);
            this.Controls.Add(this.tb_MaKhoNX);
            this.Controls.Add(this.label2);
            this.Name = "QuanLyNhapXuatKho_QuanTri";
            this.Text = "QuanLyNhapXuatKho_QuanTri";
            this.Load += new System.EventHandler(this.QuanLyNhapXuatKho_QuanTri_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhapHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XuatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TheoDoiNX;
        private System.Windows.Forms.TextBox tb_MaKhoNX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_NhapHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_XuatHang;
    }
}