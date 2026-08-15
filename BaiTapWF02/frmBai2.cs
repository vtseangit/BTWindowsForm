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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            TinhToan tt = new TinhToan();
            int KetQua = 0;
            if (rdbCong.Checked)
            {
                KetQua = tt.Cong(int.Parse(txtSoThuNhat.Text), int.Parse(txtSoThuHai.Text));
            }
            else if (rdbTru.Checked)
            {
                KetQua = tt.Tru(int.Parse(txtSoThuNhat.Text), int.Parse(txtSoThuHai.Text));
            }
            else if (rdbNhan.Checked)
            {
                KetQua = tt.Nhan(int.Parse(txtSoThuNhat.Text), int.Parse(txtSoThuHai.Text));
            }
            else if (rdbChia.Checked)
            {
                KetQua = tt.Chia(int.Parse(txtSoThuNhat.Text), int.Parse(txtSoThuHai.Text));
            }

            lblKetQua.Text = KetQua.ToString();
        }
    }
}
