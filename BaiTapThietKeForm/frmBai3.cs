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
    public partial class frmBai3 : Form
    {
        List <string> list = new List <string> ();
        List<string> listNghia = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnThemTuMoi_Click(object sender, EventArgs e)
        {
            lbxDanhSachTuMoi.Items.Add(txtTuMoi.Text);
            list.Add(txtTuMoi.Text);
            listNghia.Add(txtNhapNghiaCuaTu.Text);
            txtTuMoi.Focus();
            txtTuMoi.Clear();
            txtNhapNghiaCuaTu.Clear();

            lbxDanhSachTuMoi.SelectedIndex = lbxDanhSachTuMoi.Items.Count - 1;
            txtNghiaCuaTu.Text = txtNghiaCuaTu.Text;
        }

        private void lbxDanhSachTuMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = lbxDanhSachTuMoi.SelectedIndex;
            txtNghiaCuaTu.Text = listNghia[stt];
        }
    }
}
