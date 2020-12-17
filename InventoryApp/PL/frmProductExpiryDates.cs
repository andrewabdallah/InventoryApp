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
    public partial class frmProductExpiryDates : Form
    {
        public frmProductExpiryDates()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}