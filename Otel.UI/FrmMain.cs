using Otel.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        List<Musteri> musteris = new List<Musteri>();

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tutunacağı dal bu form demek oluyor.

            FrmOtelGiris frm = new FrmOtelGiris();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ac1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMinibar frm = new FrmMinibar(musteris);
            frm.MdiParent = this;
            frm.Show();
        }

        private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOtelRapor frm = new FrmOtelRapor();
            frm.MdiParent = this;
            frm.Show();

        }


    }
}
