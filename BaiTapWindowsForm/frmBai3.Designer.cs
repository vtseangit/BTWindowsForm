namespace BaiTapWindowsForm
{
    partial class frmBai3
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
            this.lblSoA = new System.Windows.Forms.Label();
            this.lblSoB = new System.Windows.Forms.Label();
            this.lblSoN = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.grbChonPhepTinh = new System.Windows.Forms.GroupBox();
            this.rdbTinhTongDenN = new System.Windows.Forms.RadioButton();
            this.rdbTinhTongAB = new System.Windows.Forms.RadioButton();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblSoKetQua = new System.Windows.Forms.Label();
            this.grbChonPhepTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoA
            // 
            this.lblSoA.AutoSize = true;
            this.lblSoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSoA.Location = new System.Drawing.Point(82, 46);
            this.lblSoA.Name = "lblSoA";
            this.lblSoA.Size = new System.Drawing.Size(38, 20);
            this.lblSoA.TabIndex = 0;
            this.lblSoA.Text = "a = ";
            // 
            // lblSoB
            // 
            this.lblSoB.AutoSize = true;
            this.lblSoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSoB.Location = new System.Drawing.Point(82, 85);
            this.lblSoB.Name = "lblSoB";
            this.lblSoB.Size = new System.Drawing.Size(38, 20);
            this.lblSoB.TabIndex = 1;
            this.lblSoB.Text = "b = ";
            // 
            // lblSoN
            // 
            this.lblSoN.AutoSize = true;
            this.lblSoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSoN.Location = new System.Drawing.Point(82, 123);
            this.lblSoN.Name = "lblSoN";
            this.lblSoN.Size = new System.Drawing.Size(38, 20);
            this.lblSoN.TabIndex = 2;
            this.lblSoN.Text = "n = ";
            // 
            // txtSoA
            // 
            this.txtSoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSoA.Location = new System.Drawing.Point(126, 43);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(114, 26);
            this.txtSoA.TabIndex = 3;
            // 
            // txtSoB
            // 
            this.txtSoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSoB.Location = new System.Drawing.Point(126, 82);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(114, 26);
            this.txtSoB.TabIndex = 4;
            // 
            // txtSoN
            // 
            this.txtSoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSoN.Location = new System.Drawing.Point(126, 120);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(114, 26);
            this.txtSoN.TabIndex = 5;
            // 
            // grbChonPhepTinh
            // 
            this.grbChonPhepTinh.Controls.Add(this.rdbTinhTongDenN);
            this.grbChonPhepTinh.Controls.Add(this.rdbTinhTongAB);
            this.grbChonPhepTinh.Location = new System.Drawing.Point(86, 184);
            this.grbChonPhepTinh.Name = "grbChonPhepTinh";
            this.grbChonPhepTinh.Size = new System.Drawing.Size(200, 111);
            this.grbChonPhepTinh.TabIndex = 6;
            this.grbChonPhepTinh.TabStop = false;
            this.grbChonPhepTinh.Text = "Chọn phép tính:";
            // 
            // rdbTinhTongDenN
            // 
            this.rdbTinhTongDenN.AutoSize = true;
            this.rdbTinhTongDenN.Location = new System.Drawing.Point(27, 74);
            this.rdbTinhTongDenN.Name = "rdbTinhTongDenN";
            this.rdbTinhTongDenN.Size = new System.Drawing.Size(142, 20);
            this.rdbTinhTongDenN.TabIndex = 1;
            this.rdbTinhTongDenN.TabStop = true;
            this.rdbTinhTongDenN.Text = "Tính tổng từ 1 đến n";
            this.rdbTinhTongDenN.UseVisualStyleBackColor = true;
            // 
            // rdbTinhTongAB
            // 
            this.rdbTinhTongAB.AutoSize = true;
            this.rdbTinhTongAB.Checked = true;
            this.rdbTinhTongAB.Location = new System.Drawing.Point(27, 35);
            this.rdbTinhTongAB.Name = "rdbTinhTongAB";
            this.rdbTinhTongAB.Size = new System.Drawing.Size(115, 20);
            this.rdbTinhTongAB.TabIndex = 0;
            this.rdbTinhTongAB.TabStop = true;
            this.rdbTinhTongAB.Text = "Tính tổng a + b";
            this.rdbTinhTongAB.UseVisualStyleBackColor = true;
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXemKetQua.Location = new System.Drawing.Point(113, 310);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(117, 33);
            this.btnXemKetQua.TabIndex = 7;
            this.btnXemKetQua.Text = "Xem kết quả";
            this.btnXemKetQua.UseVisualStyleBackColor = true;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblKetQua.Location = new System.Drawing.Point(22, 382);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(98, 24);
            this.lblKetQua.TabIndex = 8;
            this.lblKetQua.Text = "Kết quả là:";
            // 
            // lblSoKetQua
            // 
            this.lblSoKetQua.AutoSize = true;
            this.lblSoKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblSoKetQua.Location = new System.Drawing.Point(132, 382);
            this.lblSoKetQua.Name = "lblSoKetQua";
            this.lblSoKetQua.Size = new System.Drawing.Size(24, 24);
            this.lblSoKetQua.TabIndex = 9;
            this.lblSoKetQua.Text = "\"\"";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.lblSoKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnXemKetQua);
            this.Controls.Add(this.grbChonPhepTinh);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.lblSoN);
            this.Controls.Add(this.lblSoB);
            this.Controls.Add(this.lblSoA);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.grbChonPhepTinh.ResumeLayout(false);
            this.grbChonPhepTinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoA;
        private System.Windows.Forms.Label lblSoB;
        private System.Windows.Forms.Label lblSoN;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.GroupBox grbChonPhepTinh;
        private System.Windows.Forms.RadioButton rdbTinhTongDenN;
        private System.Windows.Forms.RadioButton rdbTinhTongAB;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblSoKetQua;
    }
}