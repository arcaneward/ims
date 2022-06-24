using IMS.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IMS
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            Inventory.PartData();
            Inventory.ProductData();
            LoadTables();
        }
        private void PartsSearchBtn_Click(object sender, EventArgs e)
        {
            var results = Inventory.SearchParts(PartsSearchBox.Text);
            PartsDataGridView(results);
        }
        private void ProductSearchBtn_Click(object sender, EventArgs e)
        {
            var results = Inventory.SearchProducts(ProductSearchBox.Text);
            ProductsDataGridView(results);
        }
        private void PartsGrid()
        {
            PartsDataGridView(Inventory.AllParts);
            PartsDataGrid.Columns["InStock"].HeaderText = "Inventory";
        }
        private void ProductsGrid()
        {
            ProductsDataGridView(Inventory.Products);
            ProductsDataGrid.Columns["InStock"].HeaderText = "Inventory";
        }
        public void LoadTables()
        {
            PartsGrid();
            ProductsGrid();
        }
        private void PartsDataGridView(IList<Part> parts)
        {
            BindingSource partsBinding = new BindingSource
            {
                DataSource = parts
            };
            PartsDataGrid.DataSource = partsBinding;
        }
        private void ProductsDataGridView(IList<Product> products)
        {
            BindingSource productsBindings = new BindingSource
            {
                DataSource = products
            };
            ProductsDataGrid.DataSource = productsBindings;
        }
        private void MainPartAdd_Click(object sender, EventArgs e)
        {
            new AddModPart().ShowDialog();
        }
        private void MainPartModify_Click(object sender, EventArgs e)
        {
            var part = PartsDataGrid.CurrentRow.DataBoundItem as Part;
            if (part == null)
            {
                MessageBox.Show("Select a part.");
            }
            new AddModPart(part).ShowDialog();
        }
        private void MainPartDelete_Click(object sender, EventArgs e)
        {
            var part = PartsDataGrid.CurrentRow.DataBoundItem as Part;
            if (part == null)
            {
                MessageBox.Show("Select a part.");
            }
            ConfirmDelete(part.Name, part, Inventory.DeletePart);
            _ = Inventory.DeletePart(part);
        }
        private void MainProductDelete_Click(object sender, EventArgs e)
        {
            if (!(ProductsDataGrid.CurrentRow.DataBoundItem is Product product))
            {
                MessageBox.Show("Select a product.");
                return;
            }
            if (product.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Must delete associated parts.");
                return;
            }
            ConfirmDelete(product.Name, product, Inventory.RemoveProduct);
            _ = Inventory.RemoveProduct(product);
        }
        private void ConfirmDelete<ItemType>(string name, ItemType item, Func<ItemType, bool> callback)
        {
            var dialogResult = MessageBox.Show($"Permanently delete {name}?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            _ = callback(item);
        }
        private void MainProductAdd_Click(object sender, EventArgs e)
        {
            new AddModProduct().ShowDialog();
        }
        private void MainProductModify_Click(object sender, EventArgs e)
        {
            var product = ProductsDataGrid.CurrentRow.DataBoundItem as Product;
            if (product == null)
            {
                MessageBox.Show("Select Product.");
            }
            new AddModProduct(product).ShowDialog();
        }
        private void MainExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}