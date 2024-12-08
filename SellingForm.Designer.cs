namespace SuperMarketManagement
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Sellingpanel = new System.Windows.Forms.Panel();
            this.SellsList_label = new System.Windows.Forms.Label();
            this.Order_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AmountRs = new System.Windows.Forms.Label();
            this.Amountlabel = new System.Windows.Forms.Label();
            this.AddProdbutton = new System.Windows.Forms.Button();
            this.SellerName = new System.Windows.Forms.Label();
            this.ProdQuantity = new System.Windows.Forms.TextBox();
            this.ProdQuantity_label = new System.Windows.Forms.Label();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.ProdPrice_label = new System.Windows.Forms.Label();
            this.Product2_dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.Label();
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.SelectCategory = new System.Windows.Forms.ComboBox();
            this.Bills_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Printbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.BillId = new System.Windows.Forms.TextBox();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.ProdName_label = new System.Windows.Forms.Label();
            this.BillId_label = new System.Windows.Forms.Label();
            this.Selling_label = new System.Windows.Forms.Label();
            this.Logout_label = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Sellingpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product2_dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bills_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Sellingpanel
            // 
            this.Sellingpanel.BackColor = System.Drawing.Color.ForestGreen;
            this.Sellingpanel.Controls.Add(this.SellsList_label);
            this.Sellingpanel.Controls.Add(this.Order_dataGridView1);
            this.Sellingpanel.Controls.Add(this.AmountRs);
            this.Sellingpanel.Controls.Add(this.Amountlabel);
            this.Sellingpanel.Controls.Add(this.AddProdbutton);
            this.Sellingpanel.Controls.Add(this.SellerName);
            this.Sellingpanel.Controls.Add(this.ProdQuantity);
            this.Sellingpanel.Controls.Add(this.ProdQuantity_label);
            this.Sellingpanel.Controls.Add(this.ProdPrice);
            this.Sellingpanel.Controls.Add(this.ProdPrice_label);
            this.Sellingpanel.Controls.Add(this.Product2_dataGridView2);
            this.Sellingpanel.Controls.Add(this.Date);
            this.Sellingpanel.Controls.Add(this.Refreshbutton);
            this.Sellingpanel.Controls.Add(this.SelectCategory);
            this.Sellingpanel.Controls.Add(this.Bills_dataGridView1);
            this.Sellingpanel.Controls.Add(this.Printbutton);
            this.Sellingpanel.Controls.Add(this.Addbutton);
            this.Sellingpanel.Controls.Add(this.BillId);
            this.Sellingpanel.Controls.Add(this.ProdName);
            this.Sellingpanel.Controls.Add(this.ProdName_label);
            this.Sellingpanel.Controls.Add(this.BillId_label);
            this.Sellingpanel.Controls.Add(this.Selling_label);
            this.Sellingpanel.Location = new System.Drawing.Point(113, 26);
            this.Sellingpanel.Name = "Sellingpanel";
            this.Sellingpanel.Size = new System.Drawing.Size(972, 645);
            this.Sellingpanel.TabIndex = 3;
            // 
            // SellsList_label
            // 
            this.SellsList_label.AutoSize = true;
            this.SellsList_label.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellsList_label.ForeColor = System.Drawing.Color.White;
            this.SellsList_label.Location = new System.Drawing.Point(658, 337);
            this.SellsList_label.Name = "SellsList_label";
            this.SellsList_label.Size = new System.Drawing.Size(116, 34);
            this.SellsList_label.TabIndex = 31;
            this.SellsList_label.Text = "Sells list";
            // 
            // Order_dataGridView1
            // 
            this.Order_dataGridView1.AllowUserToOrderColumns = true;
            this.Order_dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Order_dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Order_dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Order_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Order_dataGridView1.EnableHeadersVisualStyles = false;
            this.Order_dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.Order_dataGridView1.Location = new System.Drawing.Point(446, 72);
            this.Order_dataGridView1.Name = "Order_dataGridView1";
            this.Order_dataGridView1.RowHeadersVisible = false;
            this.Order_dataGridView1.RowHeadersWidth = 51;
            this.Order_dataGridView1.RowTemplate.Height = 24;
            this.Order_dataGridView1.Size = new System.Drawing.Size(523, 197);
            this.Order_dataGridView1.TabIndex = 30;
            // 
            // AmountRs
            // 
            this.AmountRs.AutoSize = true;
            this.AmountRs.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountRs.ForeColor = System.Drawing.Color.White;
            this.AmountRs.Location = new System.Drawing.Point(761, 272);
            this.AmountRs.Name = "AmountRs";
            this.AmountRs.Size = new System.Drawing.Size(43, 34);
            this.AmountRs.TabIndex = 29;
            this.AmountRs.Text = "Rs";
            // 
            // Amountlabel
            // 
            this.Amountlabel.AutoSize = true;
            this.Amountlabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountlabel.ForeColor = System.Drawing.Color.White;
            this.Amountlabel.Location = new System.Drawing.Point(574, 272);
            this.Amountlabel.Name = "Amountlabel";
            this.Amountlabel.Size = new System.Drawing.Size(158, 34);
            this.Amountlabel.TabIndex = 28;
            this.Amountlabel.Text = "Amount Rs";
            // 
            // AddProdbutton
            // 
            this.AddProdbutton.BackColor = System.Drawing.Color.White;
            this.AddProdbutton.FlatAppearance.BorderSize = 0;
            this.AddProdbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProdbutton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProdbutton.ForeColor = System.Drawing.Color.ForestGreen;
            this.AddProdbutton.Location = new System.Drawing.Point(155, 249);
            this.AddProdbutton.Name = "AddProdbutton";
            this.AddProdbutton.Size = new System.Drawing.Size(212, 36);
            this.AddProdbutton.TabIndex = 27;
            this.AddProdbutton.Text = "ADD";
            this.AddProdbutton.UseVisualStyleBackColor = false;
            // 
            // SellerName
            // 
            this.SellerName.AutoSize = true;
            this.SellerName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerName.ForeColor = System.Drawing.Color.White;
            this.SellerName.Location = new System.Drawing.Point(26, 23);
            this.SellerName.Name = "SellerName";
            this.SellerName.Size = new System.Drawing.Size(62, 23);
            this.SellerName.TabIndex = 25;
            this.SellerName.Text = "Seller";
            // 
            // ProdQuantity
            // 
            this.ProdQuantity.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ProdQuantity.Location = new System.Drawing.Point(155, 202);
            this.ProdQuantity.Name = "ProdQuantity";
            this.ProdQuantity.Size = new System.Drawing.Size(212, 32);
            this.ProdQuantity.TabIndex = 24;
            // 
            // ProdQuantity_label
            // 
            this.ProdQuantity_label.AutoSize = true;
            this.ProdQuantity_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQuantity_label.ForeColor = System.Drawing.Color.White;
            this.ProdQuantity_label.Location = new System.Drawing.Point(26, 211);
            this.ProdQuantity_label.Name = "ProdQuantity_label";
            this.ProdQuantity_label.Size = new System.Drawing.Size(93, 23);
            this.ProdQuantity_label.TabIndex = 23;
            this.ProdQuantity_label.Text = "Quantity";
            // 
            // ProdPrice
            // 
            this.ProdPrice.Enabled = false;
            this.ProdPrice.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ProdPrice.Location = new System.Drawing.Point(155, 154);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(212, 32);
            this.ProdPrice.TabIndex = 22;
            // 
            // ProdPrice_label
            // 
            this.ProdPrice_label.AutoSize = true;
            this.ProdPrice_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPrice_label.ForeColor = System.Drawing.Color.White;
            this.ProdPrice_label.Location = new System.Drawing.Point(26, 163);
            this.ProdPrice_label.Name = "ProdPrice_label";
            this.ProdPrice_label.Size = new System.Drawing.Size(58, 23);
            this.ProdPrice_label.TabIndex = 21;
            this.ProdPrice_label.Text = "Price";
            // 
            // Product2_dataGridView2
            // 
            this.Product2_dataGridView2.AllowUserToOrderColumns = true;
            this.Product2_dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Product2_dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Product2_dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Product2_dataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.Product2_dataGridView2.Location = new System.Drawing.Point(18, 337);
            this.Product2_dataGridView2.Name = "Product2_dataGridView2";
            this.Product2_dataGridView2.RowHeadersVisible = false;
            this.Product2_dataGridView2.RowHeadersWidth = 51;
            this.Product2_dataGridView2.RowTemplate.Height = 24;
            this.Product2_dataGridView2.Size = new System.Drawing.Size(338, 295);
            this.Product2_dataGridView2.TabIndex = 20;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.White;
            this.Date.Location = new System.Drawing.Point(852, 12);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(57, 23);
            this.Date.TabIndex = 19;
            this.Date.Text = "DATE";
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.BackColor = System.Drawing.Color.White;
            this.Refreshbutton.FlatAppearance.BorderSize = 0;
            this.Refreshbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refreshbutton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refreshbutton.ForeColor = System.Drawing.Color.ForestGreen;
            this.Refreshbutton.Location = new System.Drawing.Point(234, 302);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(122, 33);
            this.Refreshbutton.TabIndex = 18;
            this.Refreshbutton.Text = "Refresh";
            this.Refreshbutton.UseVisualStyleBackColor = false;
            // 
            // SelectCategory
            // 
            this.SelectCategory.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCategory.ForeColor = System.Drawing.Color.ForestGreen;
            this.SelectCategory.FormattingEnabled = true;
            this.SelectCategory.Items.AddRange(new object[] {
            "Meet"});
            this.SelectCategory.Location = new System.Drawing.Point(18, 302);
            this.SelectCategory.Name = "SelectCategory";
            this.SelectCategory.Size = new System.Drawing.Size(212, 29);
            this.SelectCategory.TabIndex = 17;
            this.SelectCategory.Text = "Select Category";
            // 
            // Bills_dataGridView1
            // 
            this.Bills_dataGridView1.AllowUserToOrderColumns = true;
            this.Bills_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Bills_dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Bills_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bills_dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.Bills_dataGridView1.Location = new System.Drawing.Point(446, 374);
            this.Bills_dataGridView1.Name = "Bills_dataGridView1";
            this.Bills_dataGridView1.RowHeadersVisible = false;
            this.Bills_dataGridView1.RowHeadersWidth = 51;
            this.Bills_dataGridView1.RowTemplate.Height = 24;
            this.Bills_dataGridView1.Size = new System.Drawing.Size(523, 197);
            this.Bills_dataGridView1.TabIndex = 16;
            // 
            // Printbutton
            // 
            this.Printbutton.BackColor = System.Drawing.Color.White;
            this.Printbutton.FlatAppearance.BorderSize = 0;
            this.Printbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Printbutton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Printbutton.ForeColor = System.Drawing.Color.ForestGreen;
            this.Printbutton.Location = new System.Drawing.Point(724, 589);
            this.Printbutton.Name = "Printbutton";
            this.Printbutton.Size = new System.Drawing.Size(100, 43);
            this.Printbutton.TabIndex = 14;
            this.Printbutton.Text = "PRINT";
            this.Printbutton.UseVisualStyleBackColor = false;
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.White;
            this.Addbutton.FlatAppearance.BorderSize = 0;
            this.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbutton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.ForeColor = System.Drawing.Color.ForestGreen;
            this.Addbutton.Location = new System.Drawing.Point(580, 589);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(100, 43);
            this.Addbutton.TabIndex = 5;
            this.Addbutton.Text = "ADD";
            this.Addbutton.UseVisualStyleBackColor = false;
            // 
            // BillId
            // 
            this.BillId.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BillId.Location = new System.Drawing.Point(155, 62);
            this.BillId.Name = "BillId";
            this.BillId.Size = new System.Drawing.Size(212, 32);
            this.BillId.TabIndex = 11;
            // 
            // ProdName
            // 
            this.ProdName.Enabled = false;
            this.ProdName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ProdName.Location = new System.Drawing.Point(155, 109);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(212, 32);
            this.ProdName.TabIndex = 9;
            // 
            // ProdName_label
            // 
            this.ProdName_label.AutoSize = true;
            this.ProdName_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdName_label.ForeColor = System.Drawing.Color.White;
            this.ProdName_label.Location = new System.Drawing.Point(25, 118);
            this.ProdName_label.Name = "ProdName_label";
            this.ProdName_label.Size = new System.Drawing.Size(113, 23);
            this.ProdName_label.TabIndex = 3;
            this.ProdName_label.Text = "ProdName";
            // 
            // BillId_label
            // 
            this.BillId_label.AutoSize = true;
            this.BillId_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillId_label.ForeColor = System.Drawing.Color.White;
            this.BillId_label.Location = new System.Drawing.Point(27, 71);
            this.BillId_label.Name = "BillId_label";
            this.BillId_label.Size = new System.Drawing.Size(57, 23);
            this.BillId_label.TabIndex = 2;
            this.BillId_label.Text = "BillID";
            // 
            // Selling_label
            // 
            this.Selling_label.AutoSize = true;
            this.Selling_label.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selling_label.ForeColor = System.Drawing.Color.White;
            this.Selling_label.Location = new System.Drawing.Point(393, 12);
            this.Selling_label.Name = "Selling_label";
            this.Selling_label.Size = new System.Drawing.Size(122, 34);
            this.Selling_label.TabIndex = 1;
            this.Selling_label.Text = "SELLING";
            // 
            // Logout_label
            // 
            this.Logout_label.AutoSize = true;
            this.Logout_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_label.ForeColor = System.Drawing.Color.ForestGreen;
            this.Logout_label.Location = new System.Drawing.Point(12, 615);
            this.Logout_label.Name = "Logout_label";
            this.Logout_label.Size = new System.Drawing.Size(76, 23);
            this.Logout_label.TabIndex = 34;
            this.Logout_label.Text = "Logout";
            this.Logout_label.Click += new System.EventHandler(this.Logout_label_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SuperMarketManagement.Properties.Resources.Screenshot__589_;
            this.pictureBox3.Location = new System.Drawing.Point(7, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 671);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Logout_label);
            this.Controls.Add(this.Sellingpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Sellingpanel.ResumeLayout(false);
            this.Sellingpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product2_dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bills_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Sellingpanel;
        private System.Windows.Forms.Label SellsList_label;
        private System.Windows.Forms.DataGridView Order_dataGridView1;
        private System.Windows.Forms.Label AmountRs;
        private System.Windows.Forms.Label Amountlabel;
        private System.Windows.Forms.Button AddProdbutton;
        private System.Windows.Forms.Label SellerName;
        private System.Windows.Forms.TextBox ProdQuantity;
        private System.Windows.Forms.Label ProdQuantity_label;
        private System.Windows.Forms.TextBox ProdPrice;
        private System.Windows.Forms.Label ProdPrice_label;
        private System.Windows.Forms.DataGridView Product2_dataGridView2;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button Refreshbutton;
        private System.Windows.Forms.ComboBox SelectCategory;
        private System.Windows.Forms.DataGridView Bills_dataGridView1;
        private System.Windows.Forms.Button Printbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.TextBox BillId;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.Label ProdName_label;
        private System.Windows.Forms.Label BillId_label;
        private System.Windows.Forms.Label Selling_label;
        private System.Windows.Forms.Label Logout_label;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}