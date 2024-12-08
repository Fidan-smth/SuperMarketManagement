namespace SuperMarketManagement
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.ManageProdpanel = new System.Windows.Forms.Panel();
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ProductDGV = new System.Windows.Forms.DataGridView();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.SelectCategory = new System.Windows.Forms.ComboBox();
            this.ProdCategory_label = new System.Windows.Forms.Label();
            this.ProdID = new System.Windows.Forms.TextBox();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.ProdQuantity = new System.Windows.Forms.TextBox();
            this.ProdPrice_label = new System.Windows.Forms.Label();
            this.ProdQuantity_label = new System.Windows.Forms.Label();
            this.ProdName_label = new System.Windows.Forms.Label();
            this.ProdId_label = new System.Windows.Forms.Label();
            this.ManageProd_label = new System.Windows.Forms.Label();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Categoriesbutton = new System.Windows.Forms.Button();
            this.Sellerbutton = new System.Windows.Forms.Button();
            this.Logout_label = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ManageProdpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageProdpanel
            // 
            this.ManageProdpanel.BackColor = System.Drawing.Color.ForestGreen;
            this.ManageProdpanel.Controls.Add(this.Refreshbutton);
            this.ManageProdpanel.Controls.Add(this.comboBox2);
            this.ManageProdpanel.Controls.Add(this.ProductDGV);
            this.ManageProdpanel.Controls.Add(this.Deletebutton);
            this.ManageProdpanel.Controls.Add(this.Editbutton);
            this.ManageProdpanel.Controls.Add(this.Addbutton);
            this.ManageProdpanel.Controls.Add(this.SelectCategory);
            this.ManageProdpanel.Controls.Add(this.ProdCategory_label);
            this.ManageProdpanel.Controls.Add(this.ProdID);
            this.ManageProdpanel.Controls.Add(this.ProdPrice);
            this.ManageProdpanel.Controls.Add(this.ProdName);
            this.ManageProdpanel.Controls.Add(this.ProdQuantity);
            this.ManageProdpanel.Controls.Add(this.ProdPrice_label);
            this.ManageProdpanel.Controls.Add(this.ProdQuantity_label);
            this.ManageProdpanel.Controls.Add(this.ProdName_label);
            this.ManageProdpanel.Controls.Add(this.ProdId_label);
            this.ManageProdpanel.Controls.Add(this.ManageProd_label);
            this.ManageProdpanel.Location = new System.Drawing.Point(205, 46);
            this.ManageProdpanel.Name = "ManageProdpanel";
            this.ManageProdpanel.Size = new System.Drawing.Size(880, 625);
            this.ManageProdpanel.TabIndex = 2;
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.BackColor = System.Drawing.Color.White;
            this.Refreshbutton.FlatAppearance.BorderSize = 0;
            this.Refreshbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refreshbutton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refreshbutton.ForeColor = System.Drawing.Color.ForestGreen;
            this.Refreshbutton.Location = new System.Drawing.Point(711, 73);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(127, 33);
            this.Refreshbutton.TabIndex = 18;
            this.Refreshbutton.Text = "Refresh";
            this.Refreshbutton.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.ForestGreen;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Meet"});
            this.comboBox2.Location = new System.Drawing.Point(475, 73);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(212, 29);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.Text = "Select Category";
            // 
            // ProductDGV
            // 
            this.ProductDGV.AllowUserToOrderColumns = true;
            this.ProductDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDGV.Location = new System.Drawing.Point(435, 112);
            this.ProductDGV.Name = "ProductDGV";
            this.ProductDGV.RowHeadersWidth = 51;
            this.ProductDGV.RowTemplate.Height = 24;
            this.ProductDGV.Size = new System.Drawing.Size(433, 462);
            this.ProductDGV.TabIndex = 16;
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.White;
            this.Deletebutton.FlatAppearance.BorderSize = 0;
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.ForeColor = System.Drawing.Color.ForestGreen;
            this.Deletebutton.Location = new System.Drawing.Point(261, 398);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(119, 43);
            this.Deletebutton.TabIndex = 15;
            this.Deletebutton.Text = "DELETE";
            this.Deletebutton.UseVisualStyleBackColor = false;
            // 
            // Editbutton
            // 
            this.Editbutton.BackColor = System.Drawing.Color.White;
            this.Editbutton.FlatAppearance.BorderSize = 0;
            this.Editbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editbutton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbutton.ForeColor = System.Drawing.Color.ForestGreen;
            this.Editbutton.Location = new System.Drawing.Point(142, 398);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(100, 43);
            this.Editbutton.TabIndex = 14;
            this.Editbutton.Text = "EDIT";
            this.Editbutton.UseVisualStyleBackColor = false;
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.White;
            this.Addbutton.FlatAppearance.BorderSize = 0;
            this.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbutton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.ForeColor = System.Drawing.Color.ForestGreen;
            this.Addbutton.Location = new System.Drawing.Point(23, 398);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(100, 43);
            this.Addbutton.TabIndex = 5;
            this.Addbutton.Text = "ADD";
            this.Addbutton.UseVisualStyleBackColor = false;
            // 
            // SelectCategory
            // 
            this.SelectCategory.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCategory.ForeColor = System.Drawing.Color.ForestGreen;
            this.SelectCategory.FormattingEnabled = true;
            this.SelectCategory.Items.AddRange(new object[] {
            "Meet"});
            this.SelectCategory.Location = new System.Drawing.Point(149, 338);
            this.SelectCategory.Name = "SelectCategory";
            this.SelectCategory.Size = new System.Drawing.Size(212, 29);
            this.SelectCategory.TabIndex = 13;
            this.SelectCategory.Text = "Select Category";
            // 
            // ProdCategory_label
            // 
            this.ProdCategory_label.AutoSize = true;
            this.ProdCategory_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdCategory_label.ForeColor = System.Drawing.Color.White;
            this.ProdCategory_label.Location = new System.Drawing.Point(25, 339);
            this.ProdCategory_label.Name = "ProdCategory_label";
            this.ProdCategory_label.Size = new System.Drawing.Size(117, 23);
            this.ProdCategory_label.TabIndex = 12;
            this.ProdCategory_label.Text = "CATEGORY";
            // 
            // ProdID
            // 
            this.ProdID.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ProdID.Location = new System.Drawing.Point(149, 119);
            this.ProdID.Name = "ProdID";
            this.ProdID.Size = new System.Drawing.Size(212, 32);
            this.ProdID.TabIndex = 11;
            // 
            // ProdPrice
            // 
            this.ProdPrice.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ProdPrice.Location = new System.Drawing.Point(149, 273);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(212, 32);
            this.ProdPrice.TabIndex = 10;
            // 
            // ProdName
            // 
            this.ProdName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ProdName.Location = new System.Drawing.Point(149, 174);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(212, 32);
            this.ProdName.TabIndex = 9;
            // 
            // ProdQuantity
            // 
            this.ProdQuantity.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ProdQuantity.Location = new System.Drawing.Point(149, 224);
            this.ProdQuantity.Name = "ProdQuantity";
            this.ProdQuantity.Size = new System.Drawing.Size(212, 32);
            this.ProdQuantity.TabIndex = 6;
            // 
            // ProdPrice_label
            // 
            this.ProdPrice_label.AutoSize = true;
            this.ProdPrice_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPrice_label.ForeColor = System.Drawing.Color.White;
            this.ProdPrice_label.Location = new System.Drawing.Point(25, 270);
            this.ProdPrice_label.Name = "ProdPrice_label";
            this.ProdPrice_label.Size = new System.Drawing.Size(65, 23);
            this.ProdPrice_label.TabIndex = 5;
            this.ProdPrice_label.Text = "PRICE";
            // 
            // ProdQuantity_label
            // 
            this.ProdQuantity_label.AutoSize = true;
            this.ProdQuantity_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQuantity_label.ForeColor = System.Drawing.Color.White;
            this.ProdQuantity_label.Location = new System.Drawing.Point(25, 221);
            this.ProdQuantity_label.Name = "ProdQuantity_label";
            this.ProdQuantity_label.Size = new System.Drawing.Size(104, 23);
            this.ProdQuantity_label.TabIndex = 4;
            this.ProdQuantity_label.Text = "QUANTITY";
            // 
            // ProdName_label
            // 
            this.ProdName_label.AutoSize = true;
            this.ProdName_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdName_label.ForeColor = System.Drawing.Color.White;
            this.ProdName_label.Location = new System.Drawing.Point(25, 174);
            this.ProdName_label.Name = "ProdName_label";
            this.ProdName_label.Size = new System.Drawing.Size(68, 23);
            this.ProdName_label.TabIndex = 3;
            this.ProdName_label.Text = "NAME";
            // 
            // ProdId_label
            // 
            this.ProdId_label.AutoSize = true;
            this.ProdId_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdId_label.ForeColor = System.Drawing.Color.White;
            this.ProdId_label.Location = new System.Drawing.Point(25, 118);
            this.ProdId_label.Name = "ProdId_label";
            this.ProdId_label.Size = new System.Drawing.Size(30, 23);
            this.ProdId_label.TabIndex = 2;
            this.ProdId_label.Text = "ID";
            // 
            // ManageProd_label
            // 
            this.ManageProd_label.AutoSize = true;
            this.ManageProd_label.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageProd_label.ForeColor = System.Drawing.Color.White;
            this.ManageProd_label.Location = new System.Drawing.Point(321, 19);
            this.ManageProd_label.Name = "ManageProd_label";
            this.ManageProd_label.Size = new System.Drawing.Size(253, 34);
            this.ManageProd_label.TabIndex = 1;
            this.ManageProd_label.Text = "Manage Products";
            // 
            // Exitbutton
            // 
            this.Exitbutton.FlatAppearance.BorderSize = 0;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.ForeColor = System.Drawing.Color.ForestGreen;
            this.Exitbutton.Location = new System.Drawing.Point(1008, 5);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(77, 35);
            this.Exitbutton.TabIndex = 36;
            this.Exitbutton.Text = "X";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Categoriesbutton
            // 
            this.Categoriesbutton.FlatAppearance.BorderSize = 0;
            this.Categoriesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Categoriesbutton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoriesbutton.ForeColor = System.Drawing.Color.ForestGreen;
            this.Categoriesbutton.Location = new System.Drawing.Point(12, 258);
            this.Categoriesbutton.Name = "Categoriesbutton";
            this.Categoriesbutton.Size = new System.Drawing.Size(170, 43);
            this.Categoriesbutton.TabIndex = 39;
            this.Categoriesbutton.Text = "Catagories";
            this.Categoriesbutton.UseVisualStyleBackColor = true;
            this.Categoriesbutton.Click += new System.EventHandler(this.Categoriesbutton_Click);
            // 
            // Sellerbutton
            // 
            this.Sellerbutton.FlatAppearance.BorderSize = 0;
            this.Sellerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sellerbutton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sellerbutton.ForeColor = System.Drawing.Color.ForestGreen;
            this.Sellerbutton.Location = new System.Drawing.Point(40, 209);
            this.Sellerbutton.Name = "Sellerbutton";
            this.Sellerbutton.Size = new System.Drawing.Size(116, 43);
            this.Sellerbutton.TabIndex = 38;
            this.Sellerbutton.Text = "Sellers";
            this.Sellerbutton.UseVisualStyleBackColor = true;
            this.Sellerbutton.Click += new System.EventHandler(this.Sellerbutton_Click);
            // 
            // Logout_label
            // 
            this.Logout_label.AutoSize = true;
            this.Logout_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_label.ForeColor = System.Drawing.Color.ForestGreen;
            this.Logout_label.Location = new System.Drawing.Point(36, 597);
            this.Logout_label.Name = "Logout_label";
            this.Logout_label.Size = new System.Drawing.Size(76, 23);
            this.Logout_label.TabIndex = 35;
            this.Logout_label.Text = "Logout";
            this.Logout_label.Click += new System.EventHandler(this.Logout_label_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SuperMarketManagement.Properties.Resources.Screenshot__589_;
            this.pictureBox3.Location = new System.Drawing.Point(40, 46);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 103);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 671);
            this.Controls.Add(this.Logout_label);
            this.Controls.Add(this.Categoriesbutton);
            this.Controls.Add(this.Sellerbutton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.ManageProdpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.ManageProdpanel.ResumeLayout(false);
            this.ManageProdpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ManageProdpanel;
        private System.Windows.Forms.Button Refreshbutton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView ProductDGV;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.ComboBox SelectCategory;
        private System.Windows.Forms.Label ProdCategory_label;
        private System.Windows.Forms.TextBox ProdID;
        private System.Windows.Forms.TextBox ProdPrice;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.TextBox ProdQuantity;
        private System.Windows.Forms.Label ProdPrice_label;
        private System.Windows.Forms.Label ProdQuantity_label;
        private System.Windows.Forms.Label ProdName_label;
        private System.Windows.Forms.Label ProdId_label;
        private System.Windows.Forms.Label ManageProd_label;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Categoriesbutton;
        private System.Windows.Forms.Button Sellerbutton;
        private System.Windows.Forms.Label Logout_label;
    }
}