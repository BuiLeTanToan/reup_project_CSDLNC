
namespace UI_16_DA2
{
    partial class QuanLyKhuyenMai_QuanLy
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
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.tb_Giam = new System.Windows.Forms.TextBox();
            this.tb_NgayKT = new System.Windows.Forms.TextBox();
            this.tb_NgayBD = new System.Windows.Forms.TextBox();
            this.tb_MaKM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachKM = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKM)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(313, 365);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(93, 46);
            this.btn_Xoa.TabIndex = 28;
            this.btn_Xoa.Text = "Xóa khuyến mãi";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(191, 365);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(93, 46);
            this.btn_CapNhat.TabIndex = 27;
            this.btn_CapNhat.Text = "Cập nhật khuyến mãi";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(69, 365);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(93, 46);
            this.btn_Them.TabIndex = 26;
            this.btn_Them.Text = "Thêm khuyến mãi";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // tb_Giam
            // 
            this.tb_Giam.Location = new System.Drawing.Point(179, 321);
            this.tb_Giam.Name = "tb_Giam";
            this.tb_Giam.Size = new System.Drawing.Size(121, 20);
            this.tb_Giam.TabIndex = 24;
            // 
            // tb_NgayKT
            // 
            this.tb_NgayKT.Location = new System.Drawing.Point(179, 286);
            this.tb_NgayKT.Name = "tb_NgayKT";
            this.tb_NgayKT.Size = new System.Drawing.Size(121, 20);
            this.tb_NgayKT.TabIndex = 23;
            // 
            // tb_NgayBD
            // 
            this.tb_NgayBD.Location = new System.Drawing.Point(179, 246);
            this.tb_NgayBD.Name = "tb_NgayBD";
            this.tb_NgayBD.Size = new System.Drawing.Size(121, 20);
            this.tb_NgayBD.TabIndex = 22;
            // 
            // tb_MaKM
            // 
            this.tb_MaKM.Location = new System.Drawing.Point(179, 208);
            this.tb_MaKM.Name = "tb_MaKM";
            this.tb_MaKM.Size = new System.Drawing.Size(121, 20);
            this.tb_MaKM.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Số tiền giảm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã khuyến mãi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_DanhSachKM);
            this.groupBox1.Location = new System.Drawing.Point(69, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 158);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khuyến mãi";
            // 
            // dgv_DanhSachKM
            // 
            this.dgv_DanhSachKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachKM.Location = new System.Drawing.Point(6, 19);
            this.dgv_DanhSachKM.Name = "dgv_DanhSachKM";
            this.dgv_DanhSachKM.Size = new System.Drawing.Size(518, 121);
            this.dgv_DanhSachKM.TabIndex = 0;
            // 
            // QuanLyKhuyenMai_QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 453);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.tb_Giam);
            this.Controls.Add(this.tb_NgayKT);
            this.Controls.Add(this.tb_NgayBD);
            this.Controls.Add(this.tb_MaKM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyKhuyenMai_QuanLy";
            this.Text = "QuanLyKhuyenMai_QuanLy";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox tb_Giam;
        private System.Windows.Forms.TextBox tb_NgayKT;
        private System.Windows.Forms.TextBox tb_NgayBD;
        private System.Windows.Forms.TextBox tb_MaKM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_DanhSachKM;
    }
}