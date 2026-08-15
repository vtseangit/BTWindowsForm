using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            var item = lbxDanhSachHangHoa.SelectedItem;
            lbxDanhSachDaChon.Items.Add(item);
        }

        private void btnBoHang_Click(object sender, EventArgs e)
        {
            lbxDanhSachDaChon.Items.Remove(lbxDanhSachDaChon.SelectedItem);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soTien = 0;
            foreach(string hang in lbxDanhSachDaChon.Items)
            {
                switch(hang)
                {
                    case "Chuột":
                        soTien+= 100000;
                        break;
                    case "Bàn phím":
                        soTien += 150000;
                        break;
                    case "Máy in":
                        soTien += 2000000;
                        break;
                    case "USB Kingmax":
                        soTien += 200000;
                        break;
                    default:
                        break;
                }
                lblTongTien .Text = soTien.ToString();
            }
        }
    }
}
