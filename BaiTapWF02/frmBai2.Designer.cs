namespace BaiTapWF02
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
            this.lblSoThuNhat = new System.Windows.Forms.Label();
            this.lblSoThuHai = new System.Windows.Forms.Label();
            this.txtSoThuNhat = new System.Windows.Forms.TextBox();
            this.txtSoThuHai = new System.Windows.Forms.TextBox();
            this.grbChonPhepToan = new System.Windows.Forms.GroupBox();
            this.rdbChia = new System.Windows.Forms.RadioButton();
            this.rdbNhan = new System.Windows.Forms.RadioButton();
            this.rdbTru = new System.Windows.Forms.RadioButton();
            this.rdbCong = new System.Windows.Forms.RadioButton();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.lblKetQuaLa = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.grbChonPhepToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoThuNhat
            // 
            this.lblSoThuNhat.AutoSize = true;
            this.lblSoThuNhat.Location = new System.Drawing.Point(92, 42);
            this.lblSoThuNhat.Name = "lblSoThuNhat";
            this.lblSoThuNhat.Size = new System.Drawing.Size(78, 16);
            this.lblSoThuNhat.TabIndex = 0;
            this.lblSoThuNhat.Text = "Số thứ nhất: ";
            // 
            // lblSoThuHai
            // 
            this.lblSoThuHai.AutoSize = true;
            this.lblSoThuHai.Location = new System.Drawing.Point(92, 73);
            this.lblSoThuHai.Name = "lblSoThuHai";
            this.lblSoThuHai.Size = new System.Drawing.Size(71, 16);
            this.lblSoThuHai.TabIndex = 1;
            this.lblSoThuHai.Text = "Số thứ hai: ";
            // 
            // txtSoThuNhat
            // 
            this.txtSoThuNhat.Location = new System.Drawing.Point(177, 35);
            this.txtSoThuNhat.Name = "txtSoThuNhat";
            this.txtSoThuNhat.Size = new System.Drawing.Size(113, 22);
            this.txtSoThuNhat.TabIndex = 2;
            // 
            // txtSoThuHai
            // 
            this.txtSoThuHai.Location = new System.Drawing.Point(177, 70);
            this.txtSoThuHai.Name = "txtSoThuHai";
            this.txtSoThuHai.Size = new System.Drawing.Size(113, 22);
            this.txtSoThuHai.TabIndex = 3;
            // 
            // grbChonPhepToan
            // 
            this.grbChonPhepToan.Controls.Add(this.rdbChia);
            this.grbChonPhepToan.Controls.Add(this.rdbNhan);
            this.grbChonPhepToan.Controls.Add(this.rdbTru);
            this.grbChonPhepToan.Controls.Add(this.rdbCong);
            this.grbChonPhepToan.Location = new System.Drawing.Point(177, 117);
            this.grbChonPhepToan.Name = "grbChonPhepToan";
            this.grbChonPhepToan.Size = new System.Drawing.Size(162, 148);
            this.grbChonPhepToan.TabIndex = 4;
            this.grbChonPhepToan.TabStop = false;
            this.grbChonPhepToan.Text = "Chọn phép toán: ";
            // 
            // rdbChia
            // 
            this.rdbChia.AutoSize = true;
            this.rdbChia.Location = new System.Drawing.Point(10, 109);
            this.rdbChia.Name = "rdbChia";
            this.rdbChia.Size = new System.Drawing.Size(55, 20);
            this.rdbChia.TabIndex = 3;
            this.rdbChia.TabStop = true;
            this.rdbChia.Text = "Chia";
            this.rdbChia.UseVisualStyleBackColor = true;
            // 
            // rdbNhan
            // 
            this.rdbNhan.AutoSize = true;
            this.rdbNhan.Location = new System.Drawing.Point(10, 83);
            this.rdbNhan.Name = "rdbNhan";
            this.rdbNhan.Size = new System.Drawing.Size(60, 20);
            this.rdbNhan.TabIndex = 2;
            this.rdbNhan.TabStop = true;
            this.rdbNhan.Text = "Nhân";
            this.rdbNhan.UseVisualStyleBackColor = true;
            // 
            // rdbTru
            // 
            this.rdbTru.AutoSize = true;
            this.rdbTru.Location = new System.Drawing.Point(10, 57);
            this.rdbTru.Name = "rdbTru";
            this.rdbTru.Size = new System.Drawing.Size(48, 20);
            this.rdbTru.TabIndex = 1;
            this.rdbTru.TabStop = true;
            this.rdbTru.Text = "Trừ";
            this.rdbTru.UseVisualStyleBackColor = true;
            // 
            // rdbCong
            // 
            this.rdbCong.AutoSize = true;
            this.rdbCong.Checked = true;
            this.rdbCong.Location = new System.Drawing.Point(10, 31);
            this.rdbCong.Name = "rdbCong";
            this.rdbCong.Size = new System.Drawing.Size(60, 20);
            this.rdbCong.TabIndex = 0;
            this.rdbCong.TabStop = true;
            this.rdbCong.Text = "Cộng";
            this.rdbCong.UseVisualStyleBackColor = true;
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.Location = new System.Drawing.Point(177, 281);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(125, 34);
            this.btnXemKetQua.TabIndex = 5;
            this.btnXemKetQua.Text = "Xem kết quả";
            this.btnXemKetQua.UseVisualStyleBackColor = true;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // lblKetQuaLa
            // 
            this.lblKetQuaLa.AutoSize = true;
            this.lblKetQuaLa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblKetQuaLa.Location = new System.Drawing.Point(141, 346);
            this.lblKetQuaLa.Name = "lblKetQuaLa";
            this.lblKetQuaLa.Size = new System.Drawing.Size(94, 20);
            this.lblKetQuaLa.TabIndex = 6;
            this.lblKetQuaLa.Text = "Kết quả là: ";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblKetQua.Location = new System.Drawing.Point(241, 346);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(21, 20);
            this.lblKetQua.TabIndex = 7;
            this.lblKetQua.Text = "\"\"";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 399);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblKetQuaLa);
            this.Controls.Add(this.btnXemKetQua);
            this.Controls.Add(this.grbChonPhepToan);
            this.Controls.Add(this.txtSoThuHai);
            this.Controls.Add(this.txtSoThuNhat);
            this.Controls.Add(this.lblSoThuHai);
            this.Controls.Add(this.lblSoThuNhat);
            this.Name = "frmBai2";
            this.Text = "Bài 2";
            this.grbChonPhepToan.ResumeLayout(false);
            this.grbChonPhepToan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoThuNhat;
        private System.Windows.Forms.Label lblSoThuHai;
        private System.Windows.Forms.TextBox txtSoThuNhat;
        private System.Windows.Forms.TextBox txtSoThuHai;
        private System.Windows.Forms.GroupBox grbChonPhepToan;
        private System.Windows.Forms.RadioButton rdbChia;
        private System.Windows.Forms.RadioButton rdbNhan;
        private System.Windows.Forms.RadioButton rdbTru;
        private System.Windows.Forms.RadioButton rdbCong;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.Label lblKetQuaLa;
        private System.Windows.Forms.Label lblKetQua;
    }
}