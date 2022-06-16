
namespace UI_16_DA2
{
    partial class TinhNang_QuanLy
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
            this.btn_QuanlyDT = new System.Windows.Forms.Button();
            this.btn_QuanlyKM = new System.Windows.Forms.Button();
            this.btn_QuanlyKN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_QuanlyDT
            // 
            this.btn_QuanlyDT.Location = new System.Drawing.Point(167, 103);
            this.btn_QuanlyDT.Name = "btn_QuanlyDT";
            this.btn_QuanlyDT.Size = new System.Drawing.Size(243, 46);
            this.btn_QuanlyDT.TabIndex = 2;
            this.btn_QuanlyDT.Text = "Quản lý doanh thu chi nhánh";
            this.btn_QuanlyDT.UseVisualStyleBackColor = true;
            this.btn_QuanlyDT.Click += new System.EventHandler(this.btn_QuanlyDT_Click);
            // 
            // btn_QuanlyKM
            // 
            this.btn_QuanlyKM.Location = new System.Drawing.Point(167, 166);
            this.btn_QuanlyKM.Name = "btn_QuanlyKM";
            this.btn_QuanlyKM.Size = new System.Drawing.Size(243, 46);
            this.btn_QuanlyKM.TabIndex = 3;
            this.btn_QuanlyKM.Text = "Quản lý khuyến mãi";
            this.btn_QuanlyKM.UseVisualStyleBackColor = true;
            this.btn_QuanlyKM.Click += new System.EventHandler(this.btn_QuanlyKM_Click);
            // 
            // btn_QuanlyKN
            // 
            this.btn_QuanlyKN.Location = new System.Drawing.Point(167, 231);
            this.btn_QuanlyKN.Name = "btn_QuanlyKN";
            this.btn_QuanlyKN.Size = new System.Drawing.Size(243, 46);
            this.btn_QuanlyKN.TabIndex = 4;
            this.btn_QuanlyKN.Text = "Quản lý khiếu nại";
            this.btn_QuanlyKN.UseVisualStyleBackColor = true;
            this.btn_QuanlyKN.Click += new System.EventHandler(this.btn_QuanlyKN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách chức năng";
            // 
            // TinhNang_QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_QuanlyKN);
            this.Controls.Add(this.btn_QuanlyKM);
            this.Controls.Add(this.btn_QuanlyDT);
            this.Name = "TinhNang_QuanLy";
            this.Text = "Phân hệ quản lý";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_QuanlyDT;
        private System.Windows.Forms.Button btn_QuanlyKM;
        private System.Windows.Forms.Button btn_QuanlyKN;
        private System.Windows.Forms.Label label1;
    }
}