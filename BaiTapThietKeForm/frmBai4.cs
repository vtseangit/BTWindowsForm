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
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int so;

            for (int i = 0; i <= 10; i++)
            {
                so = rand.Next(1, 100);
                lbxDanhSachSo.Items.Add(so);
            }
        }

        private void btnTimSo_Click(object sender, EventArgs e)
        {
            int soCanTim = int.Parse(txtSoCanTim.Text);
            foreach (int so in lbxDanhSachSo.Items)
            {
                if (so == soCanTim)
                {
                    lblKetQuaSauTim.Text = "Tìm thấy";
                    break;
                }
                else
                    lblKetQuaSauTim.Text = "Không tìm thấy";
            }
        }
    }
}
