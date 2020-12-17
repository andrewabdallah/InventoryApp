using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InventoryApp.DAL.Entities;
using InventoryApp.BLL;
using InventoryApp.DAL.API.OpenFoodFacts;
using InventoryApp.DAL.Operations;

namespace InventoryApp.PL
{
    public partial class frmCheckProduct : Form
    {
        Products P = null;
        public frmCheckProduct()
        {
            InitializeComponent();
        }
        public frmCheckProduct(Products P)
        {
            InitializeComponent();
            this.P = P;
            lblItemName.Text = P.PRODUCT_NAME;
            picProductImage.Image = P.PRODUCT_IMAGE;
            picProductImage.AdjustPictureBox();
            lblExpiryDate.Text = ProductExpiryDatesBLL.GetNearestProductExpiryDate(P.PRODUCT_ID).ToString();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                P = ProductsBLL.CheckProductCodeExistance(txtBarcode.Text);
                if (P == null)
                {
                    DialogResult Res = MessageBox.Show("This Product is not Exists, do you want to Create it? (Y/N)", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (Res == DialogResult.Yes)
                    {
                        frmNewProduct frm = new frmNewProduct(txtBarcode.Text);
                        frm.ShowDialog();
                    }
                }
                else
                {
                    lblItemName.Text = P.PRODUCT_NAME;
                    picProductImage.Image = P.PRODUCT_IMAGE;
                    picProductImage.AdjustPictureBox();
                    lblExpiryDate.Text = ProductExpiryDatesBLL.GetNearestProductExpiryDate(P.PRODUCT_ID).ToString();
                }
            }
        }
    }
}