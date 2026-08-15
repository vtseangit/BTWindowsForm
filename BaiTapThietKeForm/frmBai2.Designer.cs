namespace BaiTapThietKeForm
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
            this.lblDanhSachHangHoa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChonHang = new System.Windows.Forms.Button();
            this.lbxDanhSachHangHoa = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDonViTinhTong = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongTienThanhToan = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnBoHang = new System.Windows.Forms.Button();
            this.lbxDanhSachDaChon = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDanhSachHangHoa
            // 
            this.lblDanhSachHangHoa.AutoSize = true;
            this.lblDanhSachHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDanhSachHangHoa.Location = new System.Drawing.Point(33, 16);
            this.lblDanhSachHangHoa.Name = "lblDanhSachHangHoa";
            this.lblDanhSachHangHoa.Size = new System.Drawing.Size(113, 13);
            this.lblDanhSachHangHoa.TabIndex = 0;
            this.lblDanhSachHangHoa.Text = "Danh sách hàng hóa: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChonHang);
            this.panel1.Controls.Add(this.lbxDanhSachHangHoa);
            this.panel1.Controls.Add(this.lblDanhSachHangHoa);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 219);
            this.panel1.TabIndex = 1;
            // 
            // btnChonHang
            // 
            this.btnChonHang.Location = new System.Drawing.Point(176, 77);
            this.btnChonHang.Name = "btnChonHang";
            this.btnChonHang.Size = new System.Drawing.Size(90, 23);
            this.btnChonHang.TabIndex = 2;
            this.btnChonHang.Text = "Chọn hàng >";
            this.btnChonHang.UseVisualStyleBackColor = true;
            this.btnChonHang.Click += new System.EventHandler(this.btnChonHang_Click);
            // 
            // lbxDanhSachHangHoa
            // 
            this.lbxDanhSachHangHoa.FormattingEnabled = true;
            this.lbxDanhSachHangHoa.Items.AddRange(new object[] {
            "Chuột",
            "Bàn phím",
            "Máy in",
            "USB Kingmax"});
            this.lbxDanhSachHangHoa.Location = new System.Drawing.Point(16, 43);
            this.lbxDanhSachHangHoa.Name = "lbxDanhSachHangHoa";
            this.lbxDanhSachHangHoa.Size = new System.Drawing.Size(154, 95);
            this.lbxDanhSachHangHoa.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDonViTinhTong);
            this.panel2.Controls.Add(this.lblTongTien);
            this.panel2.Controls.Add(this.lblTongTienThanhToan);
            this.panel2.Controls.Add(this.btnTinhTien);
            this.panel2.Controls.Add(this.btnBoHang);
            this.panel2.Controls.Add(this.lbxDanhSachDaChon);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(277, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 219);
            this.panel2.TabIndex = 3;
            // 
            // lblDonViTinhTong
            // 
            this.lblDonViTinhTong.AutoSize = true;
            this.lblDonViTinhTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonViTinhTong.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblDonViTinhTong.Location = new System.Drawing.Point(265, 183);
            this.lblDonViTinhTong.Name = "lblDonViTinhTong";
            this.lblDonViTinhTong.Size = new System.Drawing.Size(49, 20);
            this.lblDonViTinhTong.TabIndex = 6;
            this.lblDonViTinhTong.Text = "đồng";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTongTien.Location = new System.Drawing.Point(181, 183);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(19, 20);
            this.lblTongTien.TabIndex = 5;
            this.lblTongTien.Text = "0";
            // 
            // lblTongTienThanhToan
            // 
            this.lblTongTienThanhToan.AutoSize = true;
            this.lblTongTienThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienThanhToan.Location = new System.Drawing.Point(3, 183);
            this.lblTongTienThanhToan.Name = "lblTongTienThanhToan";
            this.lblTongTienThanhToan.Size = new System.Drawing.Size(186, 20);
            this.lblTongTienThanhToan.TabIndex = 4;
            this.lblTongTienThanhToan.Text = "Tổng tiền thanh toán: ";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackColor = System.Drawing.Color.Salmon;
            this.btnTinhTien.Location = new System.Drawing.Point(135, 144);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTien.TabIndex = 3;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = false;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnBoHang
            // 
            this.btnBoHang.Location = new System.Drawing.Point(3, 77);
            this.btnBoHang.Name = "btnBoHang";
            this.btnBoHang.Size = new System.Drawing.Size(85, 23);
            this.btnBoHang.TabIndex = 2;
            this.btnBoHang.Text = "< Bỏ hàng";
            this.btnBoHang.UseVisualStyleBackColor = true;
            this.btnBoHang.Click += new System.EventHandler(this.btnBoHang_Click);
            // 
            // lbxDanhSachDaChon
            // 
            this.lbxDanhSachDaChon.FormattingEnabled = true;
            this.lbxDanhSachDaChon.Location = new System.Drawing.Point(94, 43);
            this.lbxDanhSachDaChon.Name = "lbxDanhSachDaChon";
            this.lbxDanhSachDaChon.Size = new System.Drawing.Size(154, 95);
            this.lbxDanhSachDaChon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(102, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các mặt hàng khách mua:";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 234);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBai2";
            this.Text = "Bán hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDanhSachHangHoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChonHang;
        private System.Windows.Forms.ListBox lbxDanhSachHangHoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnBoHang;
        private System.Windows.Forms.ListBox lbxDanhSachDaChon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDonViTinhTong;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTongTienThanhToan;
    }
}