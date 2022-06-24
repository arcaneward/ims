using System;
using System.Windows.Forms;

namespace IMS.Forms
{
    public partial class AddModPart : Form
    {
        public AddModPart(Part part = null)
        {
            getPart = part;
            modify = getPart != null;
            InitializeComponent();

            if (modify)
            {
                ModifyPartValues(getPart);
            }
            else
            {
                AddPartValues();
            }
        }
        private void AddPartValues()
        {
            SelectPartType();
            Text = "Add Part";
            AddPartLbl.Text = "Add Part";
            InHouseRadio.Checked = true;
            OutsourcedRadio.Checked = false;
        }
        private void ModifyPartValues(Part part)
        {
            IdTextBox.Text = part.PartID.ToString();
            NameTextbox.Text = part.Name.ToString();
            InvTextbox.Text = part.InStock.ToString();
            PriceTextbox.Text = part.Price.ToString();
            MinTextbox.Text = part.Min.ToString();
            MaxTextbox.Text = part.Max.ToString();
            Text = "Modify Part";
            AddPartLbl.Text = "Modify Part";
            InHouseRadio.Checked = part is Inhouse;
            OutsourcedRadio.Checked = part is Outsourced;
            if (InHouseRadio.Checked)
            {
                var inhouse = part as Inhouse;
                MachCompTextbox.Text = inhouse.MachineID.ToString();
            }
            else
            {
                var outsourced = part as Outsourced;
                MachCompTextbox.Text = outsourced.CompanyName;
            }
            SelectPartType();
        }
        private readonly bool modify;
        private readonly Part getPart;

        private void SelectPartType()
        {
            if (InHouseRadio.Checked)
            {
                MachCompLbl.Text = "Machine ID";
            }
            else
            {
                MachCompLbl.Text = "Company Name";
            }
        }
        private void InhouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            SelectPartType();
        }

        private void OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            SelectPartType();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(PriceTextbox.Text, out var price) || price <= 0)
            {
                MessageBox.Show("Number must greater than 0.");
                return;
            }
            if (
                !int.TryParse(MaxTextbox.Text, out var max) ||
                !int.TryParse(MinTextbox.Text, out int min) ||
                min > max ||
                min < 0 ||
                max <= 0)
            {
                MessageBox.Show("Minimum must be less than maximum.");
                return;
            }
            if (!int.TryParse(InvTextbox.Text, out var inStock) || inStock < 0)
            {
                MessageBox.Show("Must be greater than zero.");
                return;
            }
            if (inStock < min || inStock > max)
            {
                _ = MessageBox.Show($"Must be between min ({min}) and max ({max}).");
                return;
            }

            Part newPart;
            if (InHouseRadio.Checked)
            {
                if (!int.TryParse(MachCompTextbox.Text, out var machineId) || machineId <= 0)
                {
                    MessageBox.Show("Machine ID must be greater than 0.");
                    return;
                }
                newPart = new Inhouse()
                {
                    Name = NameTextbox.Text,
                    Price = price,
                    InStock = inStock,
                    Min = min,
                    Max = max,
                    MachineID = int.Parse(MachCompTextbox.Text)
                };
            }
            else
            {
                newPart = new Outsourced()
                {
                    Name = NameTextbox.Text,
                    Price = price,
                    InStock = inStock,
                    Min = min,
                    Max = max,
                    CompanyName = MachCompTextbox.Text
                };
            }
            if (modify)
            {
                Inventory.UpdatePart(getPart.PartID, newPart);
            }
            else
            {
                Inventory.AddPart(newPart);
            }
            Close();
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}