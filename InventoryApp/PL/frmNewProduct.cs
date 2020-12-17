using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InventoryApp.DAL.Entities;
using InventoryApp.DAL.Operations;
using InventoryApp.BLL;
using InventoryApp.DAL.API.OpenFoodFacts;

namespace InventoryApp.PL
{
    public partial class frmNewProduct : Form
    {
        Products P = null;

        public frmNewProduct()
        {
            InitializeComponent();
        }

        public frmNewProduct(string Barcode)
        {
            InitializeComponent();
            txtBarcode.Text = Barcode;
            txtBarcode_KeyDown(txtBarcode, new KeyEventArgs(Keys.Enter));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    P = ProductsBLL.CheckProductCodeExistance(txtBarcode.Text);
                    if (P == null)
                    {
                        btnSaveProduct.Enabled = true;
                        P = OpenFoodFactsAPI.GetProductDetails(txtBarcode.Text);
                        if (P != null)
                        {
                            lblItemName.Text = P.PRODUCT_NAME;
                            picProductImage.Image = P.PRODUCT_IMAGE;
                            picProductImage.AdjustPictureBox();
                        }
                        else
                        {
                            MessageBox.Show("Product Not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        btnSaveProduct.Enabled = false;
                        lblItemName.Text = P.PRODUCT_NAME;
                        picProductImage.Image = P.PRODUCT_IMAGE;
                        picProductImage.AdjustPictureBox();
                        DialogResult Res = MessageBox.Show("This Product is already Exists, do you want to add new expiry date for it? (Y/N)", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (Res == DialogResult.Yes)
                        {
                            btnProductExpiryDates_Click(btnProductExpiryDates, null);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btnProductExpiryDates_Click(object sender, EventArgs e)
        {
            if (P != null)
            {
                frmProductExpiryDates frm = new frmProductExpiryDates(P);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Scan item first", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            ProductsOP.InsertProduct(ref P);
            MessageBox.Show("Product saved", "Info");

        }
    }
}