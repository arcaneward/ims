namespace IMS
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.ImsLbl = new System.Windows.Forms.Label();
            this.PartsDataGrid = new System.Windows.Forms.DataGridView();
            this.PartsLbl = new System.Windows.Forms.Label();
            this.ProductsDataGrid = new System.Windows.Forms.DataGridView();
            this.ProductLbl = new System.Windows.Forms.Label();
            this.AddPartsBtn = new System.Windows.Forms.Button();
            this.ModifyPartsBtn = new System.Windows.Forms.Button();
            this.DeletePartsBtn = new System.Windows.Forms.Button();
            this.AddProdBtn = new System.Windows.Forms.Button();
            this.ModifyProdBtn = new System.Windows.Forms.Button();
            this.DeleteProdBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.PartsSearchBox = new System.Windows.Forms.TextBox();
            this.PartsSearchBtn = new System.Windows.Forms.Button();
            this.ProductSearchBox = new System.Windows.Forms.TextBox();
            this.ProductSearchBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImsLbl
            // 
            this.ImsLbl.AutoSize = true;
            this.ImsLbl.BackColor = System.Drawing.Color.Transparent;
            this.ImsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImsLbl.Location = new System.Drawing.Point(74, 23);
            this.ImsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ImsLbl.Name = "ImsLbl";
            this.ImsLbl.Size = new System.Drawing.Size(367, 29);
            this.ImsLbl.TabIndex = 0;
            this.ImsLbl.Text = "Inventory Management System";
            // 
            // PartsDataGrid
            // 
            this.PartsDataGrid.AllowUserToAddRows = false;
            this.PartsDataGrid.AllowUserToDeleteRows = false;
            this.PartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDataGrid.Location = new System.Drawing.Point(13, 108);
            this.PartsDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.PartsDataGrid.MultiSelect = false;
            this.PartsDataGrid.Name = "PartsDataGrid";
            this.PartsDataGrid.ReadOnly = true;
            this.PartsDataGrid.RowHeadersVisible = false;
            this.PartsDataGrid.RowHeadersWidth = 82;
            this.PartsDataGrid.RowTemplate.Height = 33;
            this.PartsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsDataGrid.ShowEditingIcon = false;
            this.PartsDataGrid.Size = new System.Drawing.Size(430, 250);
            this.PartsDataGrid.StandardTab = true;
            this.PartsDataGrid.TabIndex = 1;
            // 
            // PartsLbl
            // 
            this.PartsLbl.AutoSize = true;
            this.PartsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsLbl.Location = new System.Drawing.Point(11, 88);
            this.PartsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PartsLbl.Name = "PartsLbl";
            this.PartsLbl.Size = new System.Drawing.Size(43, 16);
            this.PartsLbl.TabIndex = 3;
            this.PartsLbl.Text = "Parts";
            // 
            // ProductsDataGrid
            // 
            this.ProductsDataGrid.AllowUserToAddRows = false;
            this.ProductsDataGrid.AllowUserToDeleteRows = false;
            this.ProductsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGrid.Location = new System.Drawing.Point(476, 108);
            this.ProductsDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.ProductsDataGrid.MultiSelect = false;
            this.ProductsDataGrid.Name = "ProductsDataGrid";
            this.ProductsDataGrid.ReadOnly = true;
            this.ProductsDataGrid.RowHeadersVisible = false;
            this.ProductsDataGrid.RowHeadersWidth = 82;
            this.ProductsDataGrid.RowTemplate.Height = 33;
            this.ProductsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDataGrid.ShowEditingIcon = false;
            this.ProductsDataGrid.Size = new System.Drawing.Size(430, 250);
            this.ProductsDataGrid.TabIndex = 4;
            // 
            // ProductLbl
            // 
            this.ProductLbl.AutoSize = true;
            this.ProductLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLbl.Location = new System.Drawing.Point(473, 86);
            this.ProductLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductLbl.Name = "ProductLbl";
            this.ProductLbl.Size = new System.Drawing.Size(68, 16);
            this.ProductLbl.TabIndex = 5;
            this.ProductLbl.Text = "Products";
            // 
            // AddPartsBtn
            // 
            this.AddPartsBtn.Location = new System.Drawing.Point(285, 362);
            this.AddPartsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddPartsBtn.Name = "AddPartsBtn";
            this.AddPartsBtn.Size = new System.Drawing.Size(50, 26);
            this.AddPartsBtn.TabIndex = 6;
            this.AddPartsBtn.Text = "Add";
            this.AddPartsBtn.UseVisualStyleBackColor = true;
            this.AddPartsBtn.Click += new System.EventHandler(this.MainPartAdd_Click);
            // 
            // ModifyPartsBtn
            // 
            this.ModifyPartsBtn.Location = new System.Drawing.Point(339, 362);
            this.ModifyPartsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyPartsBtn.Name = "ModifyPartsBtn";
            this.ModifyPartsBtn.Size = new System.Drawing.Size(50, 26);
            this.ModifyPartsBtn.TabIndex = 7;
            this.ModifyPartsBtn.Text = "Modify";
            this.ModifyPartsBtn.UseVisualStyleBackColor = true;
            this.ModifyPartsBtn.Click += new System.EventHandler(this.MainPartModify_Click);
            // 
            // DeletePartsBtn
            // 
            this.DeletePartsBtn.Location = new System.Drawing.Point(393, 362);
            this.DeletePartsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeletePartsBtn.Name = "DeletePartsBtn";
            this.DeletePartsBtn.Size = new System.Drawing.Size(50, 26);
            this.DeletePartsBtn.TabIndex = 8;
            this.DeletePartsBtn.Text = "Delete";
            this.DeletePartsBtn.UseVisualStyleBackColor = true;
            this.DeletePartsBtn.Click += new System.EventHandler(this.MainPartDelete_Click);
            // 
            // AddProdBtn
            // 
            this.AddProdBtn.Location = new System.Drawing.Point(748, 362);
            this.AddProdBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddProdBtn.Name = "AddProdBtn";
            this.AddProdBtn.Size = new System.Drawing.Size(50, 26);
            this.AddProdBtn.TabIndex = 9;
            this.AddProdBtn.Text = "Add";
            this.AddProdBtn.UseVisualStyleBackColor = true;
            this.AddProdBtn.Click += new System.EventHandler(this.MainProductAdd_Click);
            // 
            // ModifyProdBtn
            // 
            this.ModifyProdBtn.Location = new System.Drawing.Point(802, 362);
            this.ModifyProdBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyProdBtn.Name = "ModifyProdBtn";
            this.ModifyProdBtn.Size = new System.Drawing.Size(50, 26);
            this.ModifyProdBtn.TabIndex = 10;
            this.ModifyProdBtn.Text = "Modify";
            this.ModifyProdBtn.UseVisualStyleBackColor = true;
            this.ModifyProdBtn.Click += new System.EventHandler(this.MainProductModify_Click);
            // 
            // DeleteProdBtn
            // 
            this.DeleteProdBtn.Location = new System.Drawing.Point(856, 362);
            this.DeleteProdBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteProdBtn.Name = "DeleteProdBtn";
            this.DeleteProdBtn.Size = new System.Drawing.Size(50, 26);
            this.DeleteProdBtn.TabIndex = 11;
            this.DeleteProdBtn.Text = "Delete";
            this.DeleteProdBtn.UseVisualStyleBackColor = true;
            this.DeleteProdBtn.Click += new System.EventHandler(this.MainProductDelete_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(856, 412);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(50, 26);
            this.ExitBtn.TabIndex = 12;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.MainExit_Click);
            // 
            // PartsSearchBox
            // 
            this.PartsSearchBox.Location = new System.Drawing.Point(294, 83);
            this.PartsSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.PartsSearchBox.Name = "PartsSearchBox";
            this.PartsSearchBox.Size = new System.Drawing.Size(149, 20);
            this.PartsSearchBox.TabIndex = 13;
            // 
            // PartsSearchBtn
            // 
            this.PartsSearchBtn.Location = new System.Drawing.Point(230, 83);
            this.PartsSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PartsSearchBtn.Name = "PartsSearchBtn";
            this.PartsSearchBtn.Size = new System.Drawing.Size(60, 20);
            this.PartsSearchBtn.TabIndex = 14;
            this.PartsSearchBtn.Text = "Search";
            this.PartsSearchBtn.UseVisualStyleBackColor = true;
            this.PartsSearchBtn.Click += new System.EventHandler(this.PartsSearchBtn_Click);
            // 
            // ProductSearchBox
            // 
            this.ProductSearchBox.Location = new System.Drawing.Point(757, 84);
            this.ProductSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProductSearchBox.Name = "ProductSearchBox";
            this.ProductSearchBox.Size = new System.Drawing.Size(149, 20);
            this.ProductSearchBox.TabIndex = 15;
            // 
            // ProductSearchBtn
            // 
            this.ProductSearchBtn.Location = new System.Drawing.Point(693, 84);
            this.ProductSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ProductSearchBtn.Name = "ProductSearchBtn";
            this.ProductSearchBtn.Size = new System.Drawing.Size(60, 20);
            this.ProductSearchBtn.TabIndex = 16;
            this.ProductSearchBtn.Text = "Search";
            this.ProductSearchBtn.UseVisualStyleBackColor = true;
            this.ProductSearchBtn.Click += new System.EventHandler(this.ProductSearchBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ImsLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 67);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 73);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProductSearchBtn);
            this.Controls.Add(this.ProductSearchBox);
            this.Controls.Add(this.PartsSearchBtn);
            this.Controls.Add(this.PartsSearchBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.DeleteProdBtn);
            this.Controls.Add(this.ModifyProdBtn);
            this.Controls.Add(this.AddProdBtn);
            this.Controls.Add(this.DeletePartsBtn);
            this.Controls.Add(this.ModifyPartsBtn);
            this.Controls.Add(this.AddPartsBtn);
            this.Controls.Add(this.ProductLbl);
            this.Controls.Add(this.ProductsDataGrid);
            this.Controls.Add(this.PartsLbl);
            this.Controls.Add(this.PartsDataGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImsLbl;
        public System.Windows.Forms.DataGridView PartsDataGrid;
        private System.Windows.Forms.Label PartsLbl;
        public System.Windows.Forms.DataGridView ProductsDataGrid;
        private System.Windows.Forms.Label ProductLbl;
        private System.Windows.Forms.Button AddPartsBtn;
        private System.Windows.Forms.Button ModifyPartsBtn;
        private System.Windows.Forms.Button DeletePartsBtn;
        private System.Windows.Forms.Button AddProdBtn;
        private System.Windows.Forms.Button ModifyProdBtn;
        private System.Windows.Forms.Button DeleteProdBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox PartsSearchBox;
        private System.Windows.Forms.Button PartsSearchBtn;
        private System.Windows.Forms.TextBox ProductSearchBox;
        private System.Windows.Forms.Button ProductSearchBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}