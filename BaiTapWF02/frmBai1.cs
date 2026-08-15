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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnThanhTien_Click(object sender, EventArgs e)
        {
            string maThietBi = txtMaThietBi.Text;
            string tenThietBi = txtTenThietBi.Text;
            string nuocSanXuat = cbbNuocSanXuat.Text;
            int donGia = int.Parse(txtDonGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);

            ThietBi tb = new ThietBi(maThietBi, tenThietBi, nuocSanXuat, donGia, soLuong);
            lblHienTongGia.Text = tb.ThanhTien().ToString();
            lblHienThongTinThietBi.Text = tb.HienThi();
        }
    }
}
