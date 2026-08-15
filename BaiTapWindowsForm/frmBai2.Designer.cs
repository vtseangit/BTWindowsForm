namespace BaiTapWindowsForm
{
    partial class frmBai2
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
            this.lblTenHang = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.cbbTenHang = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.grbHinhThucThanhToan = new System.Windows.Forms.GroupBox();
            this.rdbTienMat = new System.Windows.Forms.RadioButton();
            this.rdbChuyenKhoan = new System.Windows.Forms.RadioButton();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lblSoTienThanhToan = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.grbHinhThucThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTenHang.Location = new System.Drawing.Point(39, 27);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(73, 18);
            this.lblTenHang.TabIndex = 0;
            this.lblTenHang.Text = "Tên hàng:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDonGia.Location = new System.Drawing.Point(50, 60);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(63, 18);
            this.lblDonGia.TabIndex = 1;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSoLuong.Location = new System.Drawing.Point(43, 91);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(71, 18);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // cbbTenHang
            // 
            this.cbbTenHang.FormattingEnabled = true;
            this.cbbTenHang.Items.AddRange(new object[] {
            "Chuột",
            "Máy in",
            "Bàn phím"});
            this.cbbTenHang.Location = new System.Drawing.Point(118, 26);
            this.cbbTenHang.Name = "cbbTenHang";
            this.cbbTenHang.Size = new System.Drawing.Size(173, 24);
            this.cbbTenHang.TabIndex = 3;
            this.cbbTenHang.SelectedIndexChanged += new System.EventHandler(this.cbbTenHang_SelectedIndexChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(118, 60);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(133, 22);
            this.txtDonGia.TabIndex = 4;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(118, 91);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(75, 22);
            this.txtSoLuong.TabIndex = 5;
            // 
            // grbHinhThucThanhToan
            // 
            this.grbHinhThucThanhToan.Controls.Add(this.rdbTienMat);
            this.grbHinhThucThanhToan.Controls.Add(this.rdbChuyenKhoan);
            this.grbHinhThucThanhToan.Location = new System.Drawing.Point(118, 130);
            this.grbHinhThucThanhToan.Name = "grbHinhThucThanhToan";
            this.grbHinhThucThanhToan.Size = new System.Drawing.Size(200, 96);
            this.grbHinhThucThanhToan.TabIndex = 6;
            this.grbHinhThucThanhToan.TabStop = false;
            this.grbHinhThucThanhToan.Text = "Hình thức thanh toán:";
            // 
            // rdbTienMat
            // 
            this.rdbTienMat.AutoSize = true;
            this.rdbTienMat.Checked = true;
            this.rdbTienMat.Location = new System.Drawing.Point(21, 61);
            this.rdbTienMat.Name = "rdbTienMat";
            this.rdbTienMat.Size = new System.Drawing.Size(80, 20);
            this.rdbTienMat.TabIndex = 1;
            this.rdbTienMat.TabStop = true;
            this.rdbTienMat.Text = "Tiền mặt";
            this.rdbTienMat.UseVisualStyleBackColor = true;
            // 
            // rdbChuyenKhoan
            // 
            this.rdbChuyenKhoan.AutoSize = true;
            this.rdbChuyenKhoan.Location = new System.Drawing.Point(21, 31);
            this.rdbChuyenKhoan.Name = "rdbChuyenKhoan";
            this.rdbChuyenKhoan.Size = new System.Drawing.Size(113, 20);
            this.rdbChuyenKhoan.TabIndex = 0;
            this.rdbChuyenKhoan.TabStop = true;
            this.rdbChuyenKhoan.Text = "Chuyển khoản";
            this.rdbChuyenKhoan.UseVisualStyleBackColor = true;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnTinhTien.Location = new System.Drawing.Point(130, 232);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(109, 28);
            this.btnTinhTien.TabIndex = 7;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // lblSoTienThanhToan
            // 
            this.lblSoTienThanhToan.AutoSize = true;
            this.lblSoTienThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblSoTienThanhToan.Location = new System.Drawing.Point(12, 287);
            this.lblSoTienThanhToan.Name = "lblSoTienThanhToan";
            this.lblSoTienThanhToan.Size = new System.Drawing.Size(171, 24);
            this.lblSoTienThanhToan.TabIndex = 8;
            this.lblSoTienThanhToan.Text = "Số tiền thanh toán: ";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblSoTien.Location = new System.Drawing.Point(180, 287);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(24, 24);
            this.lblSoTien.TabIndex = 9;
            this.lblSoTien.Text = "\"\"";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 320);
            this.Controls.Add(this.lblSoTien);
            this.Controls.Add(this.lblSoTienThanhToan);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.grbHinhThucThanhToan);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.cbbTenHang);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblTenHang);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.grbHinhThucThanhToan.ResumeLayout(false);
            this.grbHinhThucThanhToan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.ComboBox cbbTenHang;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.GroupBox grbHinhThucThanhToan;
        private System.Windows.Forms.RadioButton rdbTienMat;
        private System.Windows.Forms.RadioButton rdbChuyenKhoan;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lblSoTienThanhToan;
        private System.Windows.Forms.Label lblSoTien;
    }
}