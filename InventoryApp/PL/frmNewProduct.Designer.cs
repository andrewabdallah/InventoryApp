namespace InventoryApp.PL
{
    partial class frmNewProduct
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.picProductImage = new System.Windows.Forms.PictureBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProductExpiryDates = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // picProductImage
            // 
            this.picProductImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.picProductImage.Location = new System.Drawing.Point(0, 0);
            this.picProductImage.Name = "picProductImage";
            this.picProductImage.Size = new System.Drawing.Size(233, 79);
            this.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(8, 102);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(214, 23);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // lblItemName
            // 
            this.lblItemName.Location = new System.Drawing.Point(8, 130);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(214, 41);
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 20);
            this.label2.Text = "Scan Here";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnProductExpiryDates
            // 
            this.btnProductExpiryDates.BackColor = System.Drawing.Color.Crimson;
            this.btnProductExpiryDates.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnProductExpiryDates.ForeColor = System.Drawing.Color.White;
            this.btnProductExpiryDates.Location = new System.Drawing.Point(122, 173);
            this.btnProductExpiryDates.Name = "btnProductExpiryDates";
            this.btnProductExpiryDates.Size = new System.Drawing.Size(100, 39);
            this.btnProductExpiryDates.TabIndex = 9;
            this.btnProductExpiryDates.Text = "Expiry Dates";
            this.btnProductExpiryDates.Click += new System.EventHandler(this.btnProductExpiryDates_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaveProduct.Enabled = false;
            this.btnSaveProduct.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveProduct.ForeColor = System.Drawing.Color.Black;
            this.btnSaveProduct.Location = new System.Drawing.Point(8, 173);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(100, 39);
            this.btnSaveProduct.TabIndex = 13;
            this.btnSaveProduct.Text = "Save";
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // frmNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(233, 262);
            this.ControlBox = false;
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.btnProductExpiryDates);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.picProductImage);
            this.Menu = this.mainMenu1;
            this.Name = "frmNewProduct";
            this.Text = "New Product";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picProductImage;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProductExpiryDates;
        private System.Windows.Forms.Button btnSaveProduct;
    }
}