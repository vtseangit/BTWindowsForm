namespace BaiTapThietKeForm
{
    partial class frmBai4
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
            this.lbxDanhSachSo = new System.Windows.Forms.ListBox();
            this.lblNhapSoCanTim = new System.Windows.Forms.Label();
            this.txtSoCanTim = new System.Windows.Forms.TextBox();
            this.btnTimSo = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKetQuaSauTim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxDanhSachSo
            // 
            this.lbxDanhSachSo.FormattingEnabled = true;
            this.lbxDanhSachSo.ItemHeight = 16;
            this.lbxDanhSachSo.Location = new System.Drawing.Point(49, 76);
            this.lbxDanhSachSo.Margin = new System.Windows.Forms.Padding(4);
            this.lbxDanhSachSo.Name = "lbxDanhSachSo";
            this.lbxDanhSachSo.Size = new System.Drawing.Size(183, 212);
            this.lbxDanhSachSo.TabIndex = 0;
            // 
            // lblNhapSoCanTim
            // 
            this.lblNhapSoCanTim.AutoSize = true;
            this.lblNhapSoCanTim.Location = new System.Drawing.Point(284, 76);
            this.lblNhapSoCanTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapSoCanTim.Name = "lblNhapSoCanTim";
            this.lblNhapSoCanTim.Size = new System.Drawing.Size(109, 16);
            this.lblNhapSoCanTim.TabIndex = 1;
            this.lblNhapSoCanTim.Text = "Nhập số cần tìm: ";
            // 
            // txtSoCanTim
            // 
            this.txtSoCanTim.Location = new System.Drawing.Point(412, 73);
            this.txtSoCanTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoCanTim.Name = "txtSoCanTim";
            this.txtSoCanTim.Size = new System.Drawing.Size(99, 22);
            this.txtSoCanTim.TabIndex = 2;
            // 
            // btnTimSo
            // 
            this.btnTimSo.Location = new System.Drawing.Point(405, 121);
            this.btnTimSo.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimSo.Name = "btnTimSo";
            this.btnTimSo.Size = new System.Drawing.Size(107, 28);
            this.btnTimSo.TabIndex = 3;
            this.btnTimSo.Text = "Tìm số";
            this.btnTimSo.UseVisualStyleBackColor = true;
            this.btnTimSo.Click += new System.EventHandler(this.btnTimSo_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(315, 192);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(85, 20);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = "Kết quả: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(423, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 5;
            // 
            // lblKetQuaSauTim
            // 
            this.lblKetQuaSauTim.AutoSize = true;
            this.lblKetQuaSauTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQuaSauTim.ForeColor = System.Drawing.Color.Red;
            this.lblKetQuaSauTim.Location = new System.Drawing.Point(412, 192);
            this.lblKetQuaSauTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQuaSauTim.Name = "lblKetQuaSauTim";
            this.lblKetQuaSauTim.Size = new System.Drawing.Size(23, 20);
            this.lblKetQuaSauTim.TabIndex = 6;
            this.lblKetQuaSauTim.Text = "\"\"";
            // 
            // frmBai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 304);
            this.Controls.Add(this.lblKetQuaSauTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnTimSo);
            this.Controls.Add(this.txtSoCanTim);
            this.Controls.Add(this.lblNhapSoCanTim);
            this.Controls.Add(this.lbxDanhSachSo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBai4";
            this.Text = "Tìm số trong danh sách";
            this.Load += new System.EventHandler(this.frmBai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxDanhSachSo;
        private System.Windows.Forms.Label lblNhapSoCanTim;
        private System.Windows.Forms.TextBox txtSoCanTim;
        private System.Windows.Forms.Button btnTimSo;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKetQuaSauTim;
    }
}