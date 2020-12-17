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

namespace InventoryApp.PL
{
    public partial class frmProductExpiryDates : Form
    {
        Products P;
        public frmProductExpiryDates()
        {
            InitializeComponent();
        }

        public frmProductExpiryDates(Products P)
        {
            InitializeComponent();
            this.P = P;
            lblItemName.Text = P.PRODUCT_NAME;
            this.pRODUCT_EXPIRY_DATESTableAdapter.Connection.ConnectionString = DAL.DBConnection.DBCon.CeCon.ConnectionString;
            this.pRODUCT_EXPIRY_DATESTableAdapter.Fill(this.dsProductExpiryDates.PRODUCT_EXPIRY_DATES, (int)P.PRODUCT_ID);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddExpiryDate_Click(object sender, EventArgs e)
        {
            ProductExpiryDates PExp = new ProductExpiryDates();
            PExp.PRODUCT_ID = P.PRODUCT_ID;
            PExp.PRODUCT_EXPIRY_DATE = dtppExpiryDate.Value.Date;
            ProductExpiryDatesOP.InsertProductExpiryDate(PExp);
            this.pRODUCT_EXPIRY_DATESTableAdapter.Fill(this.dsProductExpiryDates.PRODUCT_EXPIRY_DATES, (int)P.PRODUCT_ID);
        }
    }
}