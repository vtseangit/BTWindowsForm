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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var form = new frmBai1();
            form.Show();
        }

        private void tsbBai2_Click(object sender, EventArgs e)
        {
            var form = new frmBai2();
            form.Show();
        }

        private void tsbBai3_Click(object sender, EventArgs e)
        {
            var form = new frmBai3();
            form.Show();
        }
    }
}
