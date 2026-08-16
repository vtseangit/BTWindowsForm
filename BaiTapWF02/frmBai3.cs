using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWF02
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnNoiChuoi_Click(object sender, EventArgs e)
        {
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string s;
            PhepTinhB3.NoiChuoi(ho, ten, out s);
            lblHoTen.Text = s;
        }

        private void btnTinhGiaiThua_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNhapN.Text);
            long gt = PhepTinhB3.GiaiThua(n);
            lblGiaiThuaCuaN.Text = gt.ToString();
        }
    }
}
