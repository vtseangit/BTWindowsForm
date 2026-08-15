namespace BaiTapThietKeForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbMauXe = new System.Windows.Forms.GroupBox();
            this.rbTrang = new System.Windows.Forms.RadioButton();
            this.rbDo = new System.Windows.Forms.RadioButton();
            this.rbXanh = new System.Windows.Forms.RadioButton();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lbDonViTinh = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lblTongTienThanhToan = new System.Windows.Forms.Label();
            this.lblDonViTinhTong = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbMauXe.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BaiTapThietKeForm.Properties.Resources.images4;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grbMauXe
            // 
            this.grbMauXe.Controls.Add(this.rbTrang);
            this.grbMauXe.Controls.Add(this.rbDo);
            this.grbMauXe.Controls.Add(this.rbXanh);
            this.grbMauXe.Location = new System.Drawing.Point(392, 15);
            this.grbMauXe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbMauXe.Name = "grbMauXe";
            this.grbMauXe.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbMauXe.Size = new System.Drawing.Size(215, 167);
            this.grbMauXe.TabIndex = 1;
            this.grbMauXe.TabStop = false;
            this.grbMauXe.Text = "Chọn màu xe";
            // 
            // rbTrang
            // 
            this.rbTrang.AutoSize = true;
            this.rbTrang.Location = new System.Drawing.Point(8, 126);
            this.rbTrang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbTrang.Name = "rbTrang";
            this.rbTrang.Size = new System.Drawing.Size(64, 20);
            this.rbTrang.TabIndex = 2;
            this.rbTrang.Text = "Trắng";
            this.rbTrang.UseVisualStyleBackColor = true;
            this.rbTrang.CheckedChanged += new System.EventHandler(this.rbTrang_CheckedChanged);
            // 
            // rbDo
            // 
            this.rbDo.AutoSize = true;
            this.rbDo.Location = new System.Drawing.Point(8, 81);
            this.rbDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDo.Name = "rbDo";
            this.rbDo.Size = new System.Drawing.Size(45, 20);
            this.rbDo.TabIndex = 1;
            this.rbDo.Text = "Đỏ";
            this.rbDo.UseVisualStyleBackColor = true;
            this.rbDo.CheckedChanged += new System.EventHandler(this.rbDo_CheckedChanged);
            // 
            // rbXanh
            // 
            this.rbXanh.AutoSize = true;
            this.rbXanh.Checked = true;
            this.rbXanh.Location = new System.Drawing.Point(8, 38);
            this.rbXanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbXanh.Name = "rbXanh";
            this.rbXanh.Size = new System.Drawing.Size(58, 20);
            this.rbXanh.TabIndex = 0;
            this.rbXanh.TabStop = true;
            this.rbXanh.Text = "Xanh";
            this.rbXanh.UseVisualStyleBackColor = true;
            this.rbXanh.CheckedChanged += new System.EventHandler(this.rbXanh_CheckedChanged);
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDonGia.Location = new System.Drawing.Point(372, 197);
            this.lblDonGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(76, 20);
            this.lblDonGia.TabIndex = 2;
            this.lblDonGia.Text = "Đơn giá: ";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSoLuong.Location = new System.Drawing.Point(372, 231);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(84, 20);
            this.lblSoLuong.TabIndex = 3;
            this.lblSoLuong.Text = "Số lượng: ";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDonGia.Location = new System.Drawing.Point(467, 192);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(132, 26);
            this.txtDonGia.TabIndex = 4;
            this.txtDonGia.Text = "22000";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSoLuong.Location = new System.Drawing.Point(467, 228);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(83, 26);
            this.txtSoLuong.TabIndex = 5;
            this.txtSoLuong.Text = "0";
            // 
            // lbDonViTinh
            // 
            this.lbDonViTinh.AutoSize = true;
            this.lbDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDonViTinh.Location = new System.Drawing.Point(608, 197);
            this.lbDonViTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDonViTinh.Name = "lbDonViTinh";
            this.lbDonViTinh.Size = new System.Drawing.Size(18, 20);
            this.lbDonViTinh.TabIndex = 6;
            this.lbDonViTinh.Text = "$";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTinhTien.Location = new System.Drawing.Point(467, 263);
            this.btnTinhTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(101, 28);
            this.btnTinhTien.TabIndex = 7;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // lblTongTienThanhToan
            // 
            this.lblTongTienThanhToan.AutoSize = true;
            this.lblTongTienThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienThanhToan.Location = new System.Drawing.Point(249, 316);
            this.lblTongTienThanhToan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTienThanhToan.Name = "lblTongTienThanhToan";
            this.lblTongTienThanhToan.Size = new System.Drawing.Size(224, 25);
            this.lblTongTienThanhToan.TabIndex = 8;
            this.lblTongTienThanhToan.Text = "Tổng tiền thanh toán: ";
            // 
            // lblDonViTinhTong
            // 
            this.lblDonViTinhTong.AutoSize = true;
            this.lblDonViTinhTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonViTinhTong.Location = new System.Drawing.Point(607, 316);
            this.lblDonViTinhTong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonViTinhTong.Name = "lblDonViTinhTong";
            this.lblDonViTinhTong.Size = new System.Drawing.Size(24, 25);
            this.lblDonViTinhTong.TabIndex = 9;
            this.lblDonViTinhTong.Text = "$";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(489, 316);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(24, 25);
            this.lblTongTien.TabIndex = 10;
            this.lblTongTien.Text = "0";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(652, 363);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblDonViTinhTong);
            this.Controls.Add(this.lblTongTienThanhToan);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.lbDonViTinh);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.grbMauXe);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBai1";
            this.Text = "Mua bán xe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbMauXe.ResumeLayout(false);
            this.grbMauXe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbMauXe;
        private System.Windows.Forms.RadioButton rbTrang;
        private System.Windows.Forms.RadioButton rbDo;
        private System.Windows.Forms.RadioButton rbXanh;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lbDonViTinh;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lblTongTienThanhToan;
        private System.Windows.Forms.Label lblDonViTinhTong;
        private System.Windows.Forms.Label lblTongTien;
    }
}