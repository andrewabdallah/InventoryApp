namespace InventoryApp.PL
{
    partial class frmProductList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btnBack = new System.Windows.Forms.Button();
            this.productsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvProductList = new System.Windows.Forms.DataGrid();
            this.dsProductExpiryDates = new InventoryApp.DAL.Datasets.dsProductExpiryDates();
            this.productsListTableAdapter = new InventoryApp.DAL.Datasets.dsProductExpiryDatesTableAdapters.ProductsListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productsListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductExpiryDates)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(8, 218);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(214, 39);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // productsListBindingSource
            // 
            this.productsListBindingSource.AllowNew = false;
            this.productsListBindingSource.DataMember = "ProductsList";
            this.productsListBindingSource.DataSource = this.dsProductExpiryDates;
            // 
            // dgvProductList
            // 
            this.dgvProductList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvProductList.DataSource = this.productsListBindingSource;
            this.dgvProductList.Location = new System.Drawing.Point(8, 3);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.Size = new System.Drawing.Size(214, 209);
            this.dgvProductList.TabIndex = 8;
            this.dgvProductList.DoubleClick += new System.EventHandler(this.dgvProductList_DoubleClick);
            // 
            // dsProductExpiryDates
            // 
            this.dsProductExpiryDates.DataSetName = "dsProductExpiryDates";
            this.dsProductExpiryDates.Prefix = "";
            this.dsProductExpiryDates.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsListTableAdapter
            // 
            this.productsListTableAdapter.ClearBeforeFill = true;
            // 
            // frmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(233, 262);
            this.ControlBox = false;
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.btnBack);
            this.Menu = this.mainMenu1;
            this.Name = "frmProductList";
            this.Text = "Product List";
            ((System.ComponentModel.ISupportInitialize)(this.productsListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductExpiryDates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGrid dgvProductList;
        private System.Windows.Forms.BindingSource productsListBindingSource;
        private InventoryApp.DAL.Datasets.dsProductExpiryDates dsProductExpiryDates;
        private InventoryApp.DAL.Datasets.dsProductExpiryDatesTableAdapters.ProductsListTableAdapter productsListTableAdapter;
    }
}