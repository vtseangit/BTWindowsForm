namespace BaiTapWF03
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
            this.lblNhapN = new System.Windows.Forms.Label();
            this.txtNhapN = new System.Windows.Forms.TextBox();
            this.grbChonCongViec = new System.Windows.Forms.GroupBox();
            this.rdbTinhGiaiThua = new System.Windows.Forms.RadioButton();
            this.rdbTinhTong = new System.Windows.Forms.RadioButton();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.grbChonCongViec.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNhapN
            // 
            this.lblNhapN.AutoSize = true;
            this.lblNhapN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNhapN.Location = new System.Drawing.Point(30, 30);
            this.lblNhapN.Name = "lblNhapN";
            this.lblNhapN.Size = new System.Drawing.Size(210, 18);
            this.lblNhapN.TabIndex = 0;
            this.lblNhapN.Text = "Nhập một số nguyên dương n: ";
            // 
            // txtNhapN
            // 
            this.txtNhapN.Location = new System.Drawing.Point(247, 30);
            this.txtNhapN.Name = "txtNhapN";
            this.txtNhapN.Size = new System.Drawing.Size(100, 22);
            this.txtNhapN.TabIndex = 1;
            // 
            // grbChonCongViec
            // 
            this.grbChonCongViec.Controls.Add(this.rdbTinhGiaiThua);
            this.grbChonCongViec.Controls.Add(this.rdbTinhTong);
            this.grbChonCongViec.Location = new System.Drawing.Point(175, 70);
            this.grbChonCongViec.Name = "grbChonCongViec";
            this.grbChonCongViec.Size = new System.Drawing.Size(172, 86);
            this.grbChonCongViec.TabIndex = 2;
            this.grbChonCongViec.TabStop = false;
            this.grbChonCongViec.Text = "Chọn công việc:";
            // 
            // rdbTinhGiaiThua
            // 
            this.rdbTinhGiaiThua.AutoSize = true;
            this.rdbTinhGiaiThua.Location = new System.Drawing.Point(15, 47);
            this.rdbTinhGiaiThua.Name = "rdbTinhGiaiThua";
            this.rdbTinhGiaiThua.Size = new System.Drawing.Size(138, 20);
            this.rdbTinhGiaiThua.TabIndex = 1;
            this.rdbTinhGiaiThua.Text = "Tính giai thừa n (n!)";
            this.rdbTinhGiaiThua.UseVisualStyleBackColor = true;
            // 
            // rdbTinhTong
            // 
            this.rdbTinhTong.AutoSize = true;
            this.rdbTinhTong.Checked = true;
            this.rdbTinhTong.Location = new System.Drawing.Point(15, 21);
            this.rdbTinhTong.Name = "rdbTinhTong";
            this.rdbTinhTong.Size = new System.Drawing.Size(129, 20);
            this.rdbTinhTong.TabIndex = 0;
            this.rdbTinhTong.TabStop = true;
            this.rdbTinhTong.Text = "Tính tổng 1 đến n";
            this.rdbTinhTong.UseVisualStyleBackColor = true;
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.Location = new System.Drawing.Point(175, 176);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(110, 30);
            this.btnXemKetQua.TabIndex = 3;
            this.btnXemKetQua.Text = "Xem kết quả";
            this.btnXemKetQua.UseVisualStyleBackColor = true;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblKetQua.Location = new System.Drawing.Point(100, 220);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(18, 18);
            this.lblKetQua.TabIndex = 5;
            this.lblKetQua.Text = "\"\"";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 258);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnXemKetQua);
            this.Controls.Add(this.grbChonCongViec);
            this.Controls.Add(this.txtNhapN);
            this.Controls.Add(this.lblNhapN);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.grbChonCongViec.ResumeLayout(false);
            this.grbChonCongViec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapN;
        private System.Windows.Forms.TextBox txtNhapN;
        private System.Windows.Forms.GroupBox grbChonCongViec;
        private System.Windows.Forms.RadioButton rdbTinhGiaiThua;
        private System.Windows.Forms.RadioButton rdbTinhTong;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.Label lblKetQua;
    }
}