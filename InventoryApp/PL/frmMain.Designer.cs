namespace InventoryApp.PL
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCheckProduct = new System.Windows.Forms.Button();
            this.btnProductList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(5, 218);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 39);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCheckProduct
            // 
            this.btnCheckProduct.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCheckProduct.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheckProduct.ForeColor = System.Drawing.Color.White;
            this.btnCheckProduct.Location = new System.Drawing.Point(117, 173);
            this.btnCheckProduct.Name = "btnCheckProduct";
            this.btnCheckProduct.Size = new System.Drawing.Size(107, 39);
            this.btnCheckProduct.TabIndex = 5;
            this.btnCheckProduct.Text = "Check Product";
            this.btnCheckProduct.Click += new System.EventHandler(this.btnScanProduct_Click);
            // 
            // btnProductList
            // 
            this.btnProductList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(105)))), ((int)(((byte)(60)))));
            this.btnProductList.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnProductList.ForeColor = System.Drawing.Color.White;
            this.btnProductList.Location = new System.Drawing.Point(117, 218);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(107, 39);
            this.btnProductList.TabIndex = 6;
            this.btnProductList.Text = "Product List";
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(55, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 53);
            this.label1.Text = "Inventory Application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "";
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.BackColor = System.Drawing.Color.GreenYellow;
            this.btnNewProduct.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewProduct.ForeColor = System.Drawing.Color.Black;
            this.btnNewProduct.Location = new System.Drawing.Point(5, 173);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(107, 39);
            this.btnNewProduct.TabIndex = 8;
            this.btnNewProduct.Text = "New Product";
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(233, 262);
            this.ControlBox = false;
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.btnCheckProduct);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Menu = this.mainMenu1;
            this.Name = "frmMain";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCheckProduct;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.Button btnNewProduct;
    }
}

