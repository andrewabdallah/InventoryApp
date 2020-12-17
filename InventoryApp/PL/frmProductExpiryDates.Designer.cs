namespace InventoryApp.PL
{
    partial class frmProductExpiryDates
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
            this.lblItemName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvProductExpiryDates = new System.Windows.Forms.DataGrid();
            this.dtppExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddExpiryDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.Location = new System.Drawing.Point(8, 5);
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
            this.btnBack.Size = new System.Drawing.Size(214, 39);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvProductExpiryDates
            // 
            this.dgvProductExpiryDates.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvProductExpiryDates.Location = new System.Drawing.Point(8, 106);
            this.dgvProductExpiryDates.Name = "dgvProductExpiryDates";
            this.dgvProductExpiryDates.Size = new System.Drawing.Size(214, 106);
            this.dgvProductExpiryDates.TabIndex = 8;
            // 
            // dtppExpiryDate
            // 
            this.dtppExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtppExpiryDate.Location = new System.Drawing.Point(8, 76);
            this.dtppExpiryDate.Name = "dtppExpiryDate";
            this.dtppExpiryDate.Size = new System.Drawing.Size(133, 24);
            this.dtppExpiryDate.TabIndex = 9;
            // 
            // btnAddExpiryDate
            // 
            this.btnAddExpiryDate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddExpiryDate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddExpiryDate.ForeColor = System.Drawing.Color.White;
            this.btnAddExpiryDate.Location = new System.Drawing.Point(147, 76);
            this.btnAddExpiryDate.Name = "btnAddExpiryDate";
            this.btnAddExpiryDate.Size = new System.Drawing.Size(75, 24);
            this.btnAddExpiryDate.TabIndex = 10;
            this.btnAddExpiryDate.Text = "Add";
            // 
            // frmProductExpiryDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(233, 262);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddExpiryDate);
            this.Controls.Add(this.dtppExpiryDate);
            this.Controls.Add(this.dgvProductExpiryDates);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblItemName);
            this.Menu = this.mainMenu1;
            this.Name = "frmProductExpiryDates";
            this.Text = "Product Expiry Dates";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGrid dgvProductExpiryDates;
        private System.Windows.Forms.DateTimePicker dtppExpiryDate;
        private System.Windows.Forms.Button btnAddExpiryDate;
    }
}