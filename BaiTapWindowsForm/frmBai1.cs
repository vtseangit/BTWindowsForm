using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            hh. MaHang = "HH01";
            hh.TenHang = "Bút bi";
            hh.DVT = "Cái";
            hh.SoLuong = 100;
            hh.DonGia = 5000;

            lblThongTin.Text = "Thông tin hàng hóa: \n" + hh.HienThi();
        }
    }
}
