namespace BaiTapWF03
{
    partial class frmBai1
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
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHeSoLuong = new System.Windows.Forms.Label();
            this.lblHeSoPhuCap = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.txtHeSoPhuCap = new System.Windows.Forms.TextBox();
            this.btnTinhTongLuong = new System.Windows.Forms.Button();
            this.lblTongLuongCuaNhanVien = new System.Windows.Forms.Label();
            this.lblThongTinNhanVien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Location = new System.Drawing.Point(49, 71);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(92, 16);
            this.lblMaNhanVien.TabIndex = 0;
            this.lblMaNhanVien.Text = "Mã nhân viên: ";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(89, 101);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(52, 16);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên: ";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(68, 131);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(73, 16);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh: ";
            // 
            // lblHeSoLuong
            // 
            this.lblHeSoLuong.AutoSize = true;
            this.lblHeSoLuong.Location = new System.Drawing.Point(56, 162);
            this.lblHeSoLuong.Name = "lblHeSoLuong";
            this.lblHeSoLuong.Size = new System.Drawing.Size(85, 16);
            this.lblHeSoLuong.TabIndex = 3;
            this.lblHeSoLuong.Text = "Hệ số lương: ";
            // 
            // lblHeSoPhuCap
            // 
            this.lblHeSoPhuCap.AutoSize = true;
            this.lblHeSoPhuCap.Location = new System.Drawing.Point(41, 194);
            this.lblHeSoPhuCap.Name = "lblHeSoPhuCap";
            this.lblHeSoPhuCap.Size = new System.Drawing.Size(100, 16);
            this.lblHeSoPhuCap.TabIndex = 4;
            this.lblHeSoPhuCap.Text = "Hệ số phụ cấp: ";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(147, 131);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(147, 65);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(117, 22);
            this.txtMaNhanVien.TabIndex = 6;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(147, 98);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 22);
            this.txtHoTen.TabIndex = 7;
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Location = new System.Drawing.Point(147, 159);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Size = new System.Drawing.Size(166, 22);
            this.txtHeSoLuong.TabIndex = 8;
            // 
            // txtHeSoPhuCap
            // 
            this.txtHeSoPhuCap.Location = new System.Drawing.Point(147, 190);
            this.txtHeSoPhuCap.Name = "txtHeSoPhuCap";
            this.txtHeSoPhuCap.Size = new System.Drawing.Size(166, 22);
            this.txtHeSoPhuCap.TabIndex = 9;
            // 
            // btnTinhTongLuong
            // 
            this.btnTinhTongLuong.BackColor = System.Drawing.Color.Honeydew;
            this.btnTinhTongLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTongLuong.ForeColor = System.Drawing.Color.Red;
            this.btnTinhTongLuong.Location = new System.Drawing.Point(147, 249);
            this.btnTinhTongLuong.Name = "btnTinhTongLuong";
            this.btnTinhTongLuong.Size = new System.Drawing.Size(146, 35);
            this.btnTinhTongLuong.TabIndex = 10;
            this.btnTinhTongLuong.Text = "Tính tổng lương";
            this.btnTinhTongLuong.UseVisualStyleBackColor = false;
            this.btnTinhTongLuong.Click += new System.EventHandler(this.btnTinhTongLuong_Click);
            // 
            // lblTongLuongCuaNhanVien
            // 
            this.lblTongLuongCuaNhanVien.AutoSize = true;
            this.lblTongLuongCuaNhanVien.BackColor = System.Drawing.Color.Khaki;
            this.lblTongLuongCuaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTongLuongCuaNhanVien.Location = new System.Drawing.Point(48, 318);
            this.lblTongLuongCuaNhanVien.Name = "lblTongLuongCuaNhanVien";
            this.lblTongLuongCuaNhanVien.Size = new System.Drawing.Size(209, 20);
            this.lblTongLuongCuaNhanVien.TabIndex = 11;
            this.lblTongLuongCuaNhanVien.Text = "Tổng lương của nhân viên: ";
            // 
            // lblThongTinNhanVien
            // 
            this.lblThongTinNhanVien.AutoSize = true;
            this.lblThongTinNhanVien.Location = new System.Drawing.Point(12, 354);
            this.lblThongTinNhanVien.Name = "lblThongTinNhanVien";
            this.lblThongTinNhanVien.Size = new System.Drawing.Size(17, 16);
            this.lblThongTinNhanVien.TabIndex = 12;
            this.lblThongTinNhanVien.Text = "\"\"";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.lblThongTinNhanVien);
            this.Controls.Add(this.lblTongLuongCuaNhanVien);
            this.Controls.Add(this.btnTinhTongLuong);
            this.Controls.Add(this.txtHeSoPhuCap);
            this.Controls.Add(this.txtHeSoLuong);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblHeSoPhuCap);
            this.Controls.Add(this.lblHeSoLuong);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaNhanVien);
            this.Name = "frmBai1";
            this.Text = "Tính tổng lương";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHeSoLuong;
        private System.Windows.Forms.Label lblHeSoPhuCap;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.TextBox txtHeSoPhuCap;
        private System.Windows.Forms.Button btnTinhTongLuong;
        private System.Windows.Forms.Label lblTongLuongCuaNhanVien;
        private System.Windows.Forms.Label lblThongTinNhanVien;
    }
}