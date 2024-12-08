namespace SuperMarketManagement
{
    partial class CategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ManageCategoriespanel = new System.Windows.Forms.Panel();
            this.Category_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CategoryID = new System.Windows.Forms.TextBox();
            this.CategoryName = new System.Windows.Forms.TextBox();
            this.CategoryDescription = new System.Windows.Forms.TextBox();
            this.CategoryDesc_label = new System.Windows.Forms.Label();
            this.CategoryName_label = new System.Windows.Forms.Label();
            this.CategoryId_label = new System.Windows.Forms.Label();
            this.ManageCategories_label = new System.Windows.Forms.Label();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Productsbutton = new System.Windows.Forms.Button();
            this.Sellerbutton = new System.Windows.Forms.Button();
            this.Logout_label = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ManageCategoriespanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Category_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageCategoriespanel
            // 
            this.ManageCategoriespanel.BackColor = System.Drawing.Color.ForestGreen;
            this.ManageCategoriespanel.Controls.Add(this.Category_dataGridView1);
            this.ManageCategoriespanel.Controls.Add(this.button7);
            this.ManageCategoriespanel.Controls.Add(this.button6);
            this.ManageCategoriespanel.Controls.Add(this.button4);
            this.ManageCategoriespanel.Controls.Add(this.CategoryID);
            this.ManageCategoriespanel.Controls.Add(this.CategoryName);
            this.ManageCategoriespanel.Controls.Add(this.CategoryDescription);
            this.ManageCategoriespanel.Controls.Add(this.CategoryDesc_label);
            this.ManageCategoriespanel.Controls.Add(this.CategoryName_label);
            this.ManageCategoriespanel.Controls.Add(this.CategoryId_label);
            this.ManageCategoriespanel.Controls.Add(this.ManageCategories_label);
            this.ManageCategoriespanel.Location = new System.Drawing.Point(204, 46);
            this.ManageCategoriespanel.Name = "ManageCategoriespanel";
            this.ManageCategoriespanel.Size = new System.Drawing.Size(880, 625);
            this.ManageCategoriespanel.TabIndex = 4;
            // 
            // Category_dataGridView1
            // 
            this.Category_dataGridView1.AllowUserToOrderColumns = true;
            this.Category_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Category_dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Category_dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.Category_dataGridView1.ColumnHeadersHeight = 25;
            this.Category_dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.Category_dataGridView1.Location = new System.Drawing.Point(435, 112);
            this.Category_dataGridView1.Name = "Category_dataGridView1";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Category_dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.Category_dataGridView1.RowHeadersVisible = false;
            this.Category_dataGridView1.RowHeadersWidth = 51;
            this.Category_dataGridView1.RowTemplate.Height = 24;
            this.Category_dataGridView1.Size = new System.Drawing.Size(433, 462);
            this.Category_dataGridView1.TabIndex = 16;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.ForestGreen;
            this.button7.Location = new System.Drawing.Point(268, 284);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 43);
            this.button7.TabIndex = 15;
            this.button7.Text = "DELETE";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.ForestGreen;
            this.button6.Location = new System.Drawing.Point(149, 284);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 43);
            this.button6.TabIndex = 14;
            this.button6.Text = "EDIT";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.ForestGreen;
            this.button4.Location = new System.Drawing.Point(30, 284);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 43);
            this.button4.TabIndex = 5;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // CategoryID
            // 
            this.CategoryID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryID.Location = new System.Drawing.Point(166, 118);
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.Size = new System.Drawing.Size(212, 32);
            this.CategoryID.TabIndex = 11;
            // 
            // CategoryName
            // 
            this.CategoryName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryName.Location = new System.Drawing.Point(166, 174);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(212, 32);
            this.CategoryName.TabIndex = 9;
            // 
            // CategoryDescription
            // 
            this.CategoryDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryDescription.Location = new System.Drawing.Point(166, 221);
            this.CategoryDescription.Name = "CategoryDescription";
            this.CategoryDescription.Size = new System.Drawing.Size(212, 32);
            this.CategoryDescription.TabIndex = 6;
            // 
            // CategoryDesc_label
            // 
            this.CategoryDesc_label.AutoSize = true;
            this.CategoryDesc_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryDesc_label.ForeColor = System.Drawing.Color.White;
            this.CategoryDesc_label.Location = new System.Drawing.Point(25, 221);
            this.CategoryDesc_label.Name = "CategoryDesc_label";
            this.CategoryDesc_label.Size = new System.Drawing.Size(135, 23);
            this.CategoryDesc_label.TabIndex = 4;
            this.CategoryDesc_label.Text = "DESCRIPTION";
            // 
            // CategoryName_label
            // 
            this.CategoryName_label.AutoSize = true;
            this.CategoryName_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryName_label.ForeColor = System.Drawing.Color.White;
            this.CategoryName_label.Location = new System.Drawing.Point(25, 174);
            this.CategoryName_label.Name = "CategoryName_label";
            this.CategoryName_label.Size = new System.Drawing.Size(68, 23);
            this.CategoryName_label.TabIndex = 3;
            this.CategoryName_label.Text = "NAME";
            // 
            // CategoryId_label
            // 
            this.CategoryId_label.AutoSize = true;
            this.CategoryId_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryId_label.ForeColor = System.Drawing.Color.White;
            this.CategoryId_label.Location = new System.Drawing.Point(25, 118);
            this.CategoryId_label.Name = "CategoryId_label";
            this.CategoryId_label.Size = new System.Drawing.Size(30, 23);
            this.CategoryId_label.TabIndex = 2;
            this.CategoryId_label.Text = "ID";
            // 
            // ManageCategories_label
            // 
            this.ManageCategories_label.AutoSize = true;
            this.ManageCategories_label.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageCategories_label.ForeColor = System.Drawing.Color.White;
            this.ManageCategories_label.Location = new System.Drawing.Point(321, 19);
            this.ManageCategories_label.Name = "ManageCategories_label";
            this.ManageCategories_label.Size = new System.Drawing.Size(285, 34);
            this.ManageCategories_label.TabIndex = 1;
            this.ManageCategories_label.Text = "Manage Categories";
            // 
            // Exitbutton
            // 
            this.Exitbutton.FlatAppearance.BorderSize = 0;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.ForeColor = System.Drawing.Color.ForestGreen;
            this.Exitbutton.Location = new System.Drawing.Point(1007, 5);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(77, 35);
            this.Exitbutton.TabIndex = 37;
            this.Exitbutton.Text = "X";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Productsbutton
            // 
            this.Productsbutton.FlatAppearance.BorderSize = 0;
            this.Productsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Productsbutton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productsbutton.ForeColor = System.Drawing.Color.ForestGreen;
            this.Productsbutton.Location = new System.Drawing.Point(12, 258);
            this.Productsbutton.Name = "Productsbutton";
            this.Productsbutton.Size = new System.Drawing.Size(186, 43);
            this.Productsbutton.TabIndex = 22;
            this.Productsbutton.Text = "Products";
            this.Productsbutton.UseVisualStyleBackColor = true;
            this.Productsbutton.Click += new System.EventHandler(this.Productsbutton_Click);
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
            this.Sellerbutton.TabIndex = 21;
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
            this.Logout_label.TabIndex = 36;
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
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 671);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Logout_label);
            this.Controls.Add(this.Productsbutton);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Sellerbutton);
            this.Controls.Add(this.ManageCategoriespanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.ManageCategoriespanel.ResumeLayout(false);
            this.ManageCategoriespanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Category_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ManageCategoriespanel;
        private System.Windows.Forms.DataGridView Category_dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox CategoryID;
        private System.Windows.Forms.TextBox CategoryName;
        private System.Windows.Forms.TextBox CategoryDescription;
        private System.Windows.Forms.Label CategoryDesc_label;
        private System.Windows.Forms.Label CategoryName_label;
        private System.Windows.Forms.Label CategoryId_label;
        private System.Windows.Forms.Label ManageCategories_label;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Productsbutton;
        private System.Windows.Forms.Button Sellerbutton;
        private System.Windows.Forms.Label Logout_label;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}