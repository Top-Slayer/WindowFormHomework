using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ອອກລະບບToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ຂມນຜສະໜອງToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplier frm = new frmSupplier();
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
        }

        private void ຂມນປະເພດສນຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductType frm = new frmProductType();
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
        }

        private void ລາຍງານສນຄາໃນຮານToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrptProductViewer frm = new frmrptProductViewer();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
