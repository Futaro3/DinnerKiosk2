using System;

using ClientApp.Backend;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        private Order newOrder;

        public string s = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newOrder = new Order();

            for (int i = 0; i < newOrder.menuEntree.Length; i++)
            {
                this.lstBxEntree.Items.Add(newOrder.menuEntree[i]);
            }
        }

        private void lstBxEntree_SelectedIndexChanged(object sender, EventArgs e)
        {
            newOrder.entree = this.lstBxEntree.Text;
        }

        private void cmboSpecial_SelectedIndexChanged(object sender, EventArgs e)
        {
            newOrder.specialRequest = this.cmboSpecial.Text;
        }

        private void ckBxWater_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBxWater.Checked)
            {
                newOrder.waterSelection = true;
            }
            else
            {
                newOrder.waterSelection = false;
            }
        }

        private void cmboSpecial_KeyPress(object sender, KeyPressEventArgs e)
        {
            // I have no idea on whaty I should be putting here...
        }

        private void radMilk_CheckedChanged(object sender, EventArgs e)
        {
            if (radMilk.Checked)
            {
                newOrder.drinkSelection = "Milk";
            }
        }

        private void radJuice_CheckedChanged(object sender, EventArgs e)
        {
            if (radJuice.Checked)
            {
                newOrder.drinkSelection = "Juice";
            }
        }

        private void radSoda_CheckedChanged(object sender, EventArgs e)
        {
            if (radSoda.Checked)
            {
                newOrder.drinkSelection = "Soda";
            }
        }

        private void radLemon_CheckedChanged(object sender, EventArgs e)
        {
            if (radLemon.Checked)
            {
                newOrder.drinkSelection = "Lemonade";
            }
        }

        private void radTea_CheckedChanged(object sender, EventArgs e)
        {
            if (radTea.Checked)
            {
                newOrder.drinkSelection = "Tea";
            }
        }

        private void radCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (radCoffee.Checked)
            {
                newOrder.drinkSelection = "Coffee";
            }
        }

        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check whether lstBxEntree has a selected item of at least 1
            if (lstBxEntree.SelectedItems.Count >= 1)
            {
                for (int x = 0; x < lstBxEntree.SelectedItems.Count; x++)
                {
                    s += "Sandwich " + (x + 1) + ": " + lstBxEntree.SelectedItems[x].ToString() + "\n";
                    newOrder.SetEntreePrice(lstBxEntree.SelectedItems[x].ToString());
                }

                if (cmboSpecial.Text != "")
                {
                    s += "Special Request: " + cmboSpecial.Text + "\n";
                }

                s += "Water Selection: " + newOrder.getWaterSelection() + "\n";

                if (newOrder.drinkSelection != "")
                {
                    s += "Drink Selection: " + newOrder.drinkSelection + "\n";
                }

                s += "\n\nTotal Charges: $" + newOrder.DetermineTotalCharges().ToString() + "\n";



                MessageBox.Show(s);
            }
        }

        private void displayOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s);
        }

        private void clearOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s = "";
            MessageBox.Show("Order Cleared");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
