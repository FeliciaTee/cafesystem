using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace cafesystem
{
    public partial class mainMenu : Form
    {
        // List to store selected items
        List<string> selectedItems = new List<string>();

        public mainMenu()
        {
            InitializeComponent();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            // Initialize or reset if needed
        }

        private void AddItem(string itemName)
        {
            if (!selectedItems.Contains(itemName))
            {
                selectedItems.Add(itemName);
            }
            else
            {
                MessageBox.Show($"{itemName} is already selected.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMatchaLatte_Click(object sender, EventArgs e)
        {
            AddItem("Matcha Latte");
        }

        private void btnMocha_Click(object sender, EventArgs e)
        {
            AddItem("Mocha");
        }

        private void btnCaramelLatte_Click(object sender, EventArgs e)
        {
            AddItem("Caramel Latte");
        }

        private void btnStrawberryMatcha_Click(object sender, EventArgs e)
        {
            AddItem("Strawberry Matcha");
        }

        private void btnSpanishLatte_Click(object sender, EventArgs e)
        {
            AddItem("Spanish Latte");
        }

        private void btnCaramelMacchiato_Click(object sender, EventArgs e)
        {
            AddItem("Caramel Macchiato");
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (selectedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one item before continuing.");
                return;
            }

            // Pass the selected items to the next form
            

            // Optionally close this form:
            // this.Hide();
        }
    }
}

