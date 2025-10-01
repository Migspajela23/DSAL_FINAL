using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class MAINFORM : Form
    {
        public MAINFORM()
        {
            InitializeComponent();
        }

        private void MAINFORM_Load(object sender, EventArgs e)
        {

        }

        private void cashier1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LESSON_1 newMDIChild = new LESSON_1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void cashier2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LESSON2 newMDIChild = new LESSON2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void cashier3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LESSON3cs newMDIChild = new LESSON3cs();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LAB2 newMDIChild = new LAB2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void payrollApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PAYROLL newMDIChild = new PAYROLL();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void orderApplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EXAMPLE6 newMDIChild = new EXAMPLE6();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
