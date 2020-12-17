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
    public partial class frmCheckProduct : Form
    {
        public frmCheckProduct()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProductExpiryDates_Click(object sender, EventArgs e)
        {
            frmProductExpiryDates frm = new frmProductExpiryDates();
            frm.ShowDialog();
        }
    }
}