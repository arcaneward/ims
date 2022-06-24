namespace IMS.Forms
{
    partial class AddModProduct
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
            this.AddProductlbl = new System.Windows.Forms.Label();
            this.IdLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.InventoryLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.MaxLbl = new System.Windows.Forms.Label();
            this.MinLbl = new System.Windows.Forms.Label();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.InventoryTextbox = new System.Windows.Forms.TextBox();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.MaxTextbox = new System.Windows.Forms.TextBox();
            this.MinTextbox = new System.Windows.Forms.TextBox();
            this.allPartsGrid = new System.Windows.Forms.DataGridView();
            this.AssociatedPartsGrid = new System.Windows.Forms.DataGridView();
            this.PartsSearchBtn = new System.Windows.Forms.Button();
            this.PartsSearchBox = new System.Windows.Forms.TextBox();
            this.AllPartsLbl = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.AssociatedPartsLbl = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductlbl
            // 
            this.AddProductlbl.AutoSize = true;
            this.AddProductlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductlbl.Location = new System.Drawing.Point(11, 9);
            this.AddProductlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddProductlbl.Name = "AddProductlbl";
            this.AddProductlbl.Size = new System.Drawing.Size(108, 20);
            this.AddProductlbl.TabIndex = 0;
            this.AddProductlbl.Text = "Add Product";
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Location = new System.Drawing.Point(48, 176);
            this.IdLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(18, 13);
            this.IdLbl.TabIndex = 1;
            this.IdLbl.Text = "ID";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(31, 204);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(35, 13);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "Name";
            // 
            // InventoryLbl
            // 
            this.InventoryLbl.AutoSize = true;
            this.InventoryLbl.Location = new System.Drawing.Point(15, 232);
            this.InventoryLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InventoryLbl.Name = "InventoryLbl";
            this.InventoryLbl.Size = new System.Drawing.Size(51, 13);
            this.InventoryLbl.TabIndex = 3;
            this.InventoryLbl.Text = "Inventory";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Location = new System.Drawing.Point(35, 262);
            this.PriceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(31, 13);
            this.PriceLbl.TabIndex = 4;
            this.PriceLbl.Text = "Price";
            // 
            // MaxLbl
            // 
            this.MaxLbl.AutoSize = true;
            this.MaxLbl.Location = new System.Drawing.Point(189, 297);
            this.MaxLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxLbl.Name = "MaxLbl";
            this.MaxLbl.Size = new System.Drawing.Size(27, 13);
            this.MaxLbl.TabIndex = 5;
            this.MaxLbl.Text = "Max";
            // 
            // MinLbl
            // 
            this.MinLbl.AutoSize = true;
            this.MinLbl.Location = new System.Drawing.Point(42, 297);
            this.MinLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinLbl.Name = "MinLbl";
            this.MinLbl.Size = new System.Drawing.Size(24, 13);
            this.MinLbl.TabIndex = 6;
            this.MinLbl.Text = "Min";
            // 
            // IdTextbox
            // 
            this.IdTextbox.Enabled = false;
            this.IdTextbox.Location = new System.Drawing.Point(105, 169);
            this.IdTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.ReadOnly = true;
            this.IdTextbox.Size = new System.Drawing.Size(124, 20);
            this.IdTextbox.TabIndex = 7;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(105, 197);
            this.NameTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(124, 20);
            this.NameTextbox.TabIndex = 8;
            // 
            // InventoryTextbox
            // 
            this.InventoryTextbox.Location = new System.Drawing.Point(105, 225);
            this.InventoryTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.InventoryTextbox.Name = "InventoryTextbox";
            this.InventoryTextbox.Size = new System.Drawing.Size(124, 20);
            this.InventoryTextbox.TabIndex = 9;
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.Location = new System.Drawing.Point(105, 255);
            this.PriceTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.Size = new System.Drawing.Size(124, 20);
            this.PriceTextbox.TabIndex = 10;
            // 
            // MaxTextbox
            // 
            this.MaxTextbox.Location = new System.Drawing.Point(220, 290);
            this.MaxTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.MaxTextbox.Name = "MaxTextbox";
            this.MaxTextbox.Size = new System.Drawing.Size(69, 20);
            this.MaxTextbox.TabIndex = 11;
            // 
            // MinTextbox
            // 
            this.MinTextbox.Location = new System.Drawing.Point(105, 290);
            this.MinTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.MinTextbox.Name = "MinTextbox";
            this.MinTextbox.Size = new System.Drawing.Size(69, 20);
            this.MinTextbox.TabIndex = 12;
            // 
            // allPartsGrid
            // 
            this.allPartsGrid.AllowUserToAddRows = false;
            this.allPartsGrid.AllowUserToDeleteRows = false;
            this.allPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsGrid.Location = new System.Drawing.Point(367, 35);
            this.allPartsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.allPartsGrid.Name = "allPartsGrid";
            this.allPartsGrid.ReadOnly = true;
            this.allPartsGrid.RowHeadersVisible = false;
            this.allPartsGrid.RowHeadersWidth = 82;
            this.allPartsGrid.RowTemplate.Height = 33;
            this.allPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allPartsGrid.ShowCellErrors = false;
            this.allPartsGrid.ShowEditingIcon = false;
            this.allPartsGrid.ShowRowErrors = false;
            this.allPartsGrid.Size = new System.Drawing.Size(398, 154);
            this.allPartsGrid.TabIndex = 13;
            // 
            // AssociatedPartsGrid
            // 
            this.AssociatedPartsGrid.AllowUserToAddRows = false;
            this.AssociatedPartsGrid.AllowUserToDeleteRows = false;
            this.AssociatedPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssociatedPartsGrid.Location = new System.Drawing.Point(367, 265);
            this.AssociatedPartsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.AssociatedPartsGrid.Name = "AssociatedPartsGrid";
            this.AssociatedPartsGrid.ReadOnly = true;
            this.AssociatedPartsGrid.RowHeadersVisible = false;
            this.AssociatedPartsGrid.RowHeadersWidth = 82;
            this.AssociatedPartsGrid.RowTemplate.Height = 33;
            this.AssociatedPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AssociatedPartsGrid.ShowCellErrors = false;
            this.AssociatedPartsGrid.ShowEditingIcon = false;
            this.AssociatedPartsGrid.ShowRowErrors = false;
            this.AssociatedPartsGrid.Size = new System.Drawing.Size(398, 154);
            this.AssociatedPartsGrid.TabIndex = 14;
            // 
            // PartsSearchBtn
            // 
            this.PartsSearchBtn.Location = new System.Drawing.Point(573, 11);
            this.PartsSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PartsSearchBtn.Name = "PartsSearchBtn";
            this.PartsSearchBtn.Size = new System.Drawing.Size(50, 20);
            this.PartsSearchBtn.TabIndex = 15;
            this.PartsSearchBtn.Text = "Search";
            this.PartsSearchBtn.UseVisualStyleBackColor = true;
            this.PartsSearchBtn.Click += new System.EventHandler(this.PartsSearchBtn_Click);
            // 
            // PartsSearchBox
            // 
            this.PartsSearchBox.Location = new System.Drawing.Point(627, 11);
            this.PartsSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.PartsSearchBox.Name = "PartsSearchBox";
            this.PartsSearchBox.Size = new System.Drawing.Size(138, 20);
            this.PartsSearchBox.TabIndex = 16;
            // 
            // AllPartsLbl
            // 
            this.AllPartsLbl.AutoSize = true;
            this.AllPartsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllPartsLbl.Location = new System.Drawing.Point(364, 17);
            this.AllPartsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AllPartsLbl.Name = "AllPartsLbl";
            this.AllPartsLbl.Size = new System.Drawing.Size(43, 16);
            this.AllPartsLbl.TabIndex = 17;
            this.AllPartsLbl.Text = "Parts";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(710, 194);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(55, 26);
            this.AddBtn.TabIndex = 18;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddPartBtn_Click);
            // 
            // AssociatedPartsLbl
            // 
            this.AssociatedPartsLbl.AutoSize = true;
            this.AssociatedPartsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssociatedPartsLbl.Location = new System.Drawing.Point(364, 247);
            this.AssociatedPartsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssociatedPartsLbl.Name = "AssociatedPartsLbl";
            this.AssociatedPartsLbl.Size = new System.Drawing.Size(125, 16);
            this.AssociatedPartsLbl.TabIndex = 19;
            this.AssociatedPartsLbl.Text = "Associated Parts";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(710, 423);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(55, 26);
            this.DeleteBtn.TabIndex = 20;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeletePartBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(651, 423);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(55, 26);
            this.SaveBtn.TabIndex = 21;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(710, 466);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(55, 26);
            this.CancelBtn.TabIndex = 22;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddModProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 502);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AssociatedPartsLbl);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.AllPartsLbl);
            this.Controls.Add(this.PartsSearchBox);
            this.Controls.Add(this.PartsSearchBtn);
            this.Controls.Add(this.AssociatedPartsGrid);
            this.Controls.Add(this.allPartsGrid);
            this.Controls.Add(this.MinTextbox);
            this.Controls.Add(this.MaxTextbox);
            this.Controls.Add(this.PriceTextbox);
            this.Controls.Add(this.InventoryTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.IdTextbox);
            this.Controls.Add(this.MinLbl);
            this.Controls.Add(this.MaxLbl);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.InventoryLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.IdLbl);
            this.Controls.Add(this.AddProductlbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddModProduct";
            this.Text = "ProductInputScreen";
            ((System.ComponentModel.ISupportInitialize)(this.allPartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddProductlbl;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label InventoryLbl;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label MaxLbl;
        private System.Windows.Forms.Label MinLbl;
        private System.Windows.Forms.TextBox IdTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox InventoryTextbox;
        private System.Windows.Forms.TextBox PriceTextbox;
        private System.Windows.Forms.TextBox MaxTextbox;
        private System.Windows.Forms.TextBox MinTextbox;
        private System.Windows.Forms.DataGridView allPartsGrid;
        private System.Windows.Forms.DataGridView AssociatedPartsGrid;
        private System.Windows.Forms.Button PartsSearchBtn;
        private System.Windows.Forms.TextBox PartsSearchBox;
        private System.Windows.Forms.Label AllPartsLbl;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label AssociatedPartsLbl;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}