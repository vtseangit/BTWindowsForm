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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void bàiSố1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmBai1 = new frmBai1();
            frmBai1.Show();
        }

        private void bàiSố2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmBai2 = new frmBai2();
            frmBai2.Show();
        }

        private void bàiSố3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmBai3 = new frmBai3();
            frmBai3.Show();
        }
    }
}
