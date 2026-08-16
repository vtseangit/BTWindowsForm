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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnTinhTongLuong_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNhanVien.Text;
            string hoTen = txtHoTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            double heSoLuong = double.Parse(txtHeSoLuong.Text);
            double heSoPhuCap = double.Parse(txtHeSoPhuCap.Text);

            NhanVien nv = new NhanVien(maNV, hoTen, ngaySinh, heSoLuong, heSoPhuCap);
            nv.TongLuong();
            lblThongTinNhanVien.Text = nv.HienThi();
        }
    }
}
