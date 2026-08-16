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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        clsBai3 cs = new clsBai3();

        private void btnTachChuoi_Click(object sender, EventArgs e)
        {
            string hoTen = txtNhapHoTen.Text;
            cs.TachChuoi(hoTen, out string s1, out string s2);
            lblHienThiHo.Text = s1;
            lblHienThiTen.Text = s2;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNhapN1.Text);
            int n2 = int.Parse(txtNhapN2.Text);
            cs.ThuTu(n1, n2);
            lblKetQua.Text = cs.ThuTu(n1, n2) ? "True" : "False";
        }
    }
}
