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
    public partial class frmNewProduct : Form
    {
        public frmNewProduct()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DAL.API.OpenFoodFactsAPI API = new InventoryApp.DAL.API.OpenFoodFactsAPI();
                API.GetProductDetails(txtBarcode.Text);
            }
        }
    }
}