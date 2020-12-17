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
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // picProductImage
            // 
            this.picProductImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.picProductImage.Location = new System.Drawing.Point(0, 0);
            this.picProductImage.Name = "picProductImage";
            this.picProductImage.Size = new System.Drawing.Size(233, 79);
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
            this.lblItemName.Size = new System.Drawing.Size(214, 62);
            this.lblItemName.Text = "Item Name";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(8, 218);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 39);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(122, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 39);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
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
            // frmNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(233, 262);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
    }
}