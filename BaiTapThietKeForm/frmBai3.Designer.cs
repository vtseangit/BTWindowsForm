namespace BaiTapThietKeForm
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
            this.lblTuMoi = new System.Windows.Forms.Label();
            this.lblNhapNghiaCuaTu = new System.Windows.Forms.Label();
            this.txtTuMoi = new System.Windows.Forms.TextBox();
            this.txtNhapNghiaCuaTu = new System.Windows.Forms.TextBox();
            this.btnThemTuMoi = new System.Windows.Forms.Button();
            this.lblDanhSachTuMoi = new System.Windows.Forms.Label();
            this.lblNghiaCuaTu = new System.Windows.Forms.Label();
            this.lbxDanhSachTuMoi = new System.Windows.Forms.ListBox();
            this.txtNghiaCuaTu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTuMoi
            // 
            this.lblTuMoi.AutoSize = true;
            this.lblTuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTuMoi.Location = new System.Drawing.Point(54, 29);
            this.lblTuMoi.Name = "lblTuMoi";
            this.lblTuMoi.Size = new System.Drawing.Size(45, 13);
            this.lblTuMoi.TabIndex = 0;
            this.lblTuMoi.Text = "Từ mới: ";
            // 
            // lblNhapNghiaCuaTu
            // 
            this.lblNhapNghiaCuaTu.AutoSize = true;
            this.lblNhapNghiaCuaTu.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapNghiaCuaTu.Location = new System.Drawing.Point(22, 57);
            this.lblNhapNghiaCuaTu.Name = "lblNhapNghiaCuaTu";
            this.lblNhapNghiaCuaTu.Size = new System.Drawing.Size(79, 14);
            this.lblNhapNghiaCuaTu.TabIndex = 1;
            this.lblNhapNghiaCuaTu.Text = "Nghĩa của từ: ";
            // 
            // txtTuMoi
            // 
            this.txtTuMoi.Location = new System.Drawing.Point(105, 26);
            this.txtTuMoi.Name = "txtTuMoi";
            this.txtTuMoi.Size = new System.Drawing.Size(131, 20);
            this.txtTuMoi.TabIndex = 0;
            // 
            // txtNhapNghiaCuaTu
            // 
            this.txtNhapNghiaCuaTu.Location = new System.Drawing.Point(105, 54);
            this.txtNhapNghiaCuaTu.Name = "txtNhapNghiaCuaTu";
            this.txtNhapNghiaCuaTu.Size = new System.Drawing.Size(158, 20);
            this.txtNhapNghiaCuaTu.TabIndex = 1;
            // 
            // btnThemTuMoi
            // 
            this.btnThemTuMoi.Location = new System.Drawing.Point(146, 90);
            this.btnThemTuMoi.Name = "btnThemTuMoi";
            this.btnThemTuMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemTuMoi.TabIndex = 2;
            this.btnThemTuMoi.Text = "Thêm từ mới";
            this.btnThemTuMoi.UseVisualStyleBackColor = true;
            this.btnThemTuMoi.Click += new System.EventHandler(this.btnThemTuMoi_Click);
            // 
            // lblDanhSachTuMoi
            // 
            this.lblDanhSachTuMoi.AutoSize = true;
            this.lblDanhSachTuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDanhSachTuMoi.Location = new System.Drawing.Point(102, 141);
            this.lblDanhSachTuMoi.Name = "lblDanhSachTuMoi";
            this.lblDanhSachTuMoi.Size = new System.Drawing.Size(111, 13);
            this.lblDanhSachTuMoi.TabIndex = 5;
            this.lblDanhSachTuMoi.Text = "DANH SÁCH TỪ MỚI";
            // 
            // lblNghiaCuaTu
            // 
            this.lblNghiaCuaTu.AutoSize = true;
            this.lblNghiaCuaTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNghiaCuaTu.Location = new System.Drawing.Point(382, 141);
            this.lblNghiaCuaTu.Name = "lblNghiaCuaTu";
            this.lblNghiaCuaTu.Size = new System.Drawing.Size(86, 13);
            this.lblNghiaCuaTu.TabIndex = 6;
            this.lblNghiaCuaTu.Text = "NGHĨA CỦA TỪ";
            // 
            // lbxDanhSachTuMoi
            // 
            this.lbxDanhSachTuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbxDanhSachTuMoi.FormattingEnabled = true;
            this.lbxDanhSachTuMoi.ItemHeight = 16;
            this.lbxDanhSachTuMoi.Location = new System.Drawing.Point(57, 167);
            this.lbxDanhSachTuMoi.Name = "lbxDanhSachTuMoi";
            this.lbxDanhSachTuMoi.Size = new System.Drawing.Size(212, 116);
            this.lbxDanhSachTuMoi.TabIndex = 7;
            this.lbxDanhSachTuMoi.SelectedIndexChanged += new System.EventHandler(this.lbxDanhSachTuMoi_SelectedIndexChanged);
            // 
            // txtNghiaCuaTu
            // 
            this.txtNghiaCuaTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNghiaCuaTu.Location = new System.Drawing.Point(343, 167);
            this.txtNghiaCuaTu.Multiline = true;
            this.txtNghiaCuaTu.Name = "txtNghiaCuaTu";
            this.txtNghiaCuaTu.ReadOnly = true;
            this.txtNghiaCuaTu.Size = new System.Drawing.Size(185, 116);
            this.txtNghiaCuaTu.TabIndex = 8;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 297);
            this.Controls.Add(this.lbxDanhSachTuMoi);
            this.Controls.Add(this.lblNghiaCuaTu);
            this.Controls.Add(this.lblDanhSachTuMoi);
            this.Controls.Add(this.btnThemTuMoi);
            this.Controls.Add(this.txtNhapNghiaCuaTu);
            this.Controls.Add(this.txtTuMoi);
            this.Controls.Add(this.lblNhapNghiaCuaTu);
            this.Controls.Add(this.lblTuMoi);
            this.Controls.Add(this.txtNghiaCuaTu);
            this.Name = "frmBai3";
            this.Text = "Từ điển Anh - Việt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTuMoi;
        private System.Windows.Forms.Label lblNhapNghiaCuaTu;
        private System.Windows.Forms.TextBox txtTuMoi;
        private System.Windows.Forms.TextBox txtNhapNghiaCuaTu;
        private System.Windows.Forms.Button btnThemTuMoi;
        private System.Windows.Forms.Label lblDanhSachTuMoi;
        private System.Windows.Forms.Label lblNghiaCuaTu;
        private System.Windows.Forms.ListBox lbxDanhSachTuMoi;
        private System.Windows.Forms.TextBox txtNghiaCuaTu;
    }
}