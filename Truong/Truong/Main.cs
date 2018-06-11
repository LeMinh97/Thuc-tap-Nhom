using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Truong
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHS hs = new FormHS();
            hs.Show();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGV gv = new FormGV();
            gv.Show();
        }

        private void thôngTinGiảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTTDG dg = new FormTTDG();
            dg.Show();
        }
    }
}
