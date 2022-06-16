namespace UI_16_DA2
{
    partial class QuanLyTonKho_QuanTri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_MaKho = new System.Windows.Forms.TextBox();
            this.btn_TheoDoiTonKho = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_DSSanPhamTonKho = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSanPhamTonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mã kho";
            // 
            // tb_MaKho
            // 
            this.tb_MaKho.Location = new System.Drawing.Point(90, 34);
            this.tb_MaKho.Name = "tb_MaKho";
            this.tb_MaKho.Size = new System.Drawing.Size(100, 20);
            this.tb_MaKho.TabIndex = 2;
            // 
            // btn_TheoDoiTonKho
            // 
            this.btn_TheoDoiTonKho.Location = new System.Drawing.Point(218, 32);
            this.btn_TheoDoiTonKho.Name = "btn_TheoDoiTonKho";
            this.btn_TheoDoiTonKho.Size = new System.Drawing.Size(75, 23);
            this.btn_TheoDoiTonKho.TabIndex = 3;
            this.btn_TheoDoiTonKho.Text = "Theo dõi";
            this.btn_TheoDoiTonKho.UseVisualStyleBackColor = true;
            this.btn_TheoDoiTonKho.Click += new System.EventHandler(this.btn_TheoDoiTonKho_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_DSSanPhamTonKho);
            this.groupBox1.Location = new System.Drawing.Point(16, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 357);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm trong kho";
            // 
            // dgv_DSSanPhamTonKho
            // 
            this.dgv_DSSanPhamTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSanPhamTonKho.Location = new System.Drawing.Point(6, 19);
            this.dgv_DSSanPhamTonKho.Name = "dgv_DSSanPhamTonKho";
            this.dgv_DSSanPhamTonKho.Size = new System.Drawing.Size(760, 332);
            this.dgv_DSSanPhamTonKho.TabIndex = 0;
            // 
            // QuanLyTonKho_QuanTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_TheoDoiTonKho);
            this.Controls.Add(this.tb_MaKho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyTonKho_QuanTri";
            this.Text = "Theo dõi tồn kho";
            this.Load += new System.EventHandler(this.QuanLyTonKho_QuanTri_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSanPhamTonKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_MaKho;
        private System.Windows.Forms.Button btn_TheoDoiTonKho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_DSSanPhamTonKho;
    }
}