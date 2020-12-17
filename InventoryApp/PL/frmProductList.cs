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
    public partial class frmProductList : Form
    {
        public frmProductList()
        {
            InitializeComponent();
            this.productsListTableAdapter.Connection.ConnectionString = DAL.DBConnection.DBCon.CeCon.ConnectionString;
            this.productsListTableAdapter.Fill(this.dsProductExpiryDates.ProductsList);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProductList.CurrentRowIndex >= 0)
            {
                Products P = ProductsOP.GetProduct(int.Parse(dgvProductList[dgvProductList.CurrentRowIndex, 0].ToString()));
                frmCheckProduct frm = new frmCheckProduct(P);
                frm.ShowDialog();
            }
        }
    }
}