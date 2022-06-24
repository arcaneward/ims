namespace IMS.Forms
{
    partial class AddModPart
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
            this.AddPartLbl = new System.Windows.Forms.Label();
            this.IdLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.InvLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.MaxLbl = new System.Windows.Forms.Label();
            this.MinLbl = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.InvTextbox = new System.Windows.Forms.TextBox();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.MaxTextbox = new System.Windows.Forms.TextBox();
            this.MinTextbox = new System.Windows.Forms.TextBox();
            this.MachCompTextbox = new System.Windows.Forms.TextBox();
            this.MachCompLbl = new System.Windows.Forms.Label();
            this.InHouseRadio = new System.Windows.Forms.RadioButton();
            this.OutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPartLbl
            // 
            this.AddPartLbl.AutoSize = true;
            this.AddPartLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartLbl.Location = new System.Drawing.Point(6, 5);
            this.AddPartLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddPartLbl.Name = "AddPartLbl";
            this.AddPartLbl.Size = new System.Drawing.Size(79, 20);
            this.AddPartLbl.TabIndex = 0;
            this.AddPartLbl.Text = "Add Part";
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Location = new System.Drawing.Point(117, 73);
            this.IdLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(18, 13);
            this.IdLbl.TabIndex = 3;
            this.IdLbl.Text = "ID";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(99, 105);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(35, 13);
            this.NameLbl.TabIndex = 4;
            this.NameLbl.Text = "Name";
            // 
            // InvLbl
            // 
            this.InvLbl.AutoSize = true;
            this.InvLbl.Location = new System.Drawing.Point(83, 139);
            this.InvLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InvLbl.Name = "InvLbl";
            this.InvLbl.Size = new System.Drawing.Size(51, 13);
            this.InvLbl.TabIndex = 5;
            this.InvLbl.Text = "Inventory";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Location = new System.Drawing.Point(104, 173);
            this.PriceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(31, 13);
            this.PriceLbl.TabIndex = 6;
            this.PriceLbl.Text = "Price";
            // 
            // MaxLbl
            // 
            this.MaxLbl.AutoSize = true;
            this.MaxLbl.Location = new System.Drawing.Point(229, 212);
            this.MaxLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxLbl.Name = "MaxLbl";
            this.MaxLbl.Size = new System.Drawing.Size(27, 13);
            this.MaxLbl.TabIndex = 7;
            this.MaxLbl.Text = "Max";
            // 
            // MinLbl
            // 
            this.MinLbl.AutoSize = true;
            this.MinLbl.Location = new System.Drawing.Point(110, 212);
            this.MinLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinLbl.Name = "MinLbl";
            this.MinLbl.Size = new System.Drawing.Size(24, 13);
            this.MinLbl.TabIndex = 8;
            this.MinLbl.Text = "Min";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(159, 73);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(111, 20);
            this.IdTextBox.TabIndex = 9;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(159, 105);
            this.NameTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(111, 20);
            this.NameTextbox.TabIndex = 10;
            // 
            // InvTextbox
            // 
            this.InvTextbox.Location = new System.Drawing.Point(159, 139);
            this.InvTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InvTextbox.Name = "InvTextbox";
            this.InvTextbox.Size = new System.Drawing.Size(111, 20);
            this.InvTextbox.TabIndex = 11;
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.Location = new System.Drawing.Point(159, 170);
            this.PriceTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.Size = new System.Drawing.Size(111, 20);
            this.PriceTextbox.TabIndex = 12;
            // 
            // MaxTextbox
            // 
            this.MaxTextbox.Location = new System.Drawing.Point(261, 205);
            this.MaxTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaxTextbox.Name = "MaxTextbox";
            this.MaxTextbox.Size = new System.Drawing.Size(62, 20);
            this.MaxTextbox.TabIndex = 13;
            // 
            // MinTextbox
            // 
            this.MinTextbox.Location = new System.Drawing.Point(159, 205);
            this.MinTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinTextbox.Name = "MinTextbox";
            this.MinTextbox.Size = new System.Drawing.Size(61, 20);
            this.MinTextbox.TabIndex = 14;
            // 
            // MachCompTextbox
            // 
            this.MachCompTextbox.Location = new System.Drawing.Point(159, 236);
            this.MachCompTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MachCompTextbox.Name = "MachCompTextbox";
            this.MachCompTextbox.Size = new System.Drawing.Size(111, 20);
            this.MachCompTextbox.TabIndex = 15;
            // 
            // MachCompLbl
            // 
            this.MachCompLbl.AutoSize = true;
            this.MachCompLbl.Location = new System.Drawing.Point(73, 243);
            this.MachCompLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MachCompLbl.Name = "MachCompLbl";
            this.MachCompLbl.Size = new System.Drawing.Size(62, 13);
            this.MachCompLbl.TabIndex = 16;
            this.MachCompLbl.Text = "Machine ID";
            // 
            // InHouseRadio
            // 
            this.InHouseRadio.AutoSize = true;
            this.InHouseRadio.Checked = true;
            this.InHouseRadio.Location = new System.Drawing.Point(120, 11);
            this.InHouseRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InHouseRadio.Name = "InHouseRadio";
            this.InHouseRadio.Size = new System.Drawing.Size(68, 17);
            this.InHouseRadio.TabIndex = 1;
            this.InHouseRadio.TabStop = true;
            this.InHouseRadio.Text = "In-House";
            this.InHouseRadio.UseVisualStyleBackColor = true;
            this.InHouseRadio.CheckedChanged += new System.EventHandler(this.InhouseRadio_CheckedChanged);
            // 
            // OutsourcedRadio
            // 
            this.OutsourcedRadio.AutoSize = true;
            this.OutsourcedRadio.Location = new System.Drawing.Point(243, 11);
            this.OutsourcedRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OutsourcedRadio.Name = "OutsourcedRadio";
            this.OutsourcedRadio.Size = new System.Drawing.Size(80, 17);
            this.OutsourcedRadio.TabIndex = 2;
            this.OutsourcedRadio.Text = "Outsourced";
            this.OutsourcedRadio.UseVisualStyleBackColor = true;
            this.OutsourcedRadio.CheckedChanged += new System.EventHandler(this.OutsourcedRadio_CheckedChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(211, 268);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(60, 26);
            this.SaveBtn.TabIndex = 17;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(281, 268);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(60, 26);
            this.CancelBtn.TabIndex = 18;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddModPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 306);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.InHouseRadio);
            this.Controls.Add(this.OutsourcedRadio);
            this.Controls.Add(this.MachCompLbl);
            this.Controls.Add(this.MachCompTextbox);
            this.Controls.Add(this.MinTextbox);
            this.Controls.Add(this.MaxTextbox);
            this.Controls.Add(this.PriceTextbox);
            this.Controls.Add(this.InvTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.MinLbl);
            this.Controls.Add(this.MaxLbl);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.InvLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.IdLbl);
            this.Controls.Add(this.AddPartLbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddModPart";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPartLbl;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label InvLbl;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label MaxLbl;
        private System.Windows.Forms.Label MinLbl;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox InvTextbox;
        private System.Windows.Forms.TextBox PriceTextbox;
        private System.Windows.Forms.TextBox MaxTextbox;
        private System.Windows.Forms.TextBox MinTextbox;
        private System.Windows.Forms.TextBox MachCompTextbox;
        private System.Windows.Forms.Label MachCompLbl;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.RadioButton InHouseRadio;
        private System.Windows.Forms.RadioButton OutsourcedRadio;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}