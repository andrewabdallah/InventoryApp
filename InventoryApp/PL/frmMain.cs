using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryApp.PL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnScanProduct_Click(object sender, EventArgs e)
        {
            frmCheckProduct frm = new frmCheckProduct();
            frm.ShowDialog();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            frmNewProduct frm = new frmNewProduct();
            frm.ShowDialog();
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            frmProductList frm = new frmProductList();
            frm.ShowDialog();
        }
    }
}