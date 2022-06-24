using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IMS.Forms
{

    public partial class AddModProduct : Form
    {
        public AddModProduct(Product getProduct = null)
        {
            ModifyProduct = getProduct != null;
            product = ModifyProduct ? getProduct : new Product();
            InitializeComponent();
            AllPartsData(Inventory.AllParts);
            AssociatedPartsData(product.AssociatedParts);

            if (ModifyProduct)
            {
                AddProductlbl.Text = "Modify Product";
                Text = "Modify Product";
                IdTextbox.Text = product.ProductID.ToString();
                NameTextbox.Text = product.Name;
                InventoryTextbox.Text = product.InStock.ToString();
                PriceTextbox.Text = product.Price.ToString();
                MinTextbox.Text = product.Min.ToString();
                MaxTextbox.Text = product.Max.ToString();
            }
        }
        private readonly Product product;
        private readonly bool ModifyProduct;

        private void AssociatedPartsData(IList<Part> parts)
        {
            BindingSource associatedParts = new BindingSource
            {
                DataSource = parts
            };
            AssociatedPartsGrid.DataSource = associatedParts;
        }
        private void AllPartsData(IList<Part> parts)
        {
            BindingSource allPartsBinding = new BindingSource
            {
                DataSource = parts
            };
            allPartsGrid.DataSource = allPartsBinding;
        }

        private void PartsSearchBtn_Click(object sender, EventArgs e)
        {
            var results = Inventory.SearchParts(PartsSearchBox.Text);
            AllPartsData(results);
        }
        private void DeletePartBtn_Click(object sender, EventArgs e)
        {
            var part = allPartsGrid.CurrentRow.DataBoundItem as Part;
            if (part == null)
            {
                _ = MessageBox.Show("Select part.");
            }
            _ = product.RemoveAssociatedPart(part.PartID);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(PriceTextbox.Text, out var price) || price <= 0)
            {
                MessageBox.Show("Price must be greater than 0.");
                return;
            }

            if (
                !int.TryParse(MaxTextbox.Text, out var max) ||
                !int.TryParse(MinTextbox.Text, out int min) ||
                min > max ||
                min < 0 ||
                max <= 0)
            {
                MessageBox.Show($"Must be between minimum and maximum.");
                return;
            }

            if (!int.TryParse(InventoryTextbox.Text, out var inStock) || inStock < 0)
            {
                MessageBox.Show("Must not be less than 0.");
                return;
            }

            if (inStock < min || inStock > max)
            {
                MessageBox.Show($"Must be between minimum ({min}) and maximum ({max}).");
                return;
            }

            product.Name = NameTextbox.Text;
            product.InStock = inStock;
            product.Price = price;
            product.Max = max;
            product.Min = min;

            if (ModifyProduct)
            {
                Inventory.UpdateProduct(product.ProductID, product);
            }
            else
            {
                Inventory.AddProduct(product);
            }
            Close();
        }
        private void AddPartBtn_Click(object sender, EventArgs e)
        {
            var part = allPartsGrid.CurrentRow.DataBoundItem as Part;
            if (part == null)
            {
                MessageBox.Show("Select part.");
            }
            product.AddAssociatedPart(part);
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
