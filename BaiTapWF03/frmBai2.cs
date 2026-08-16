using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWF03
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        int n = 0;

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            n = int.Parse(txtNhapN.Text);

            if (rdbTinhTong.Checked)
            {
                TinhToan.TinhTong(n);
                lblKetQua.Text = $"Tổng từ 1 đến {n} là: {TinhToan.TinhTong(n)}";
            }

            else if (rdbTinhGiaiThua.Checked)
            {
                TinhToan.TinhGiaiThua(n);
                lblKetQua.Text = $"Giai thừa của {n} là: {TinhToan.TinhGiaiThua(n)}";
            }
        }
    }
}
