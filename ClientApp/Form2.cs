using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ClientApp
{
    public partial class Form2 : Form
    {
        List<string> favorites = new List<string>();
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            MainTabPane.SelectedTab = Home;
        }

        private void MainTabPane_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {
        }

        private void Order_Click(object sender, EventArgs e)
        {
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            MainTabPane.SelectedTab = Order;
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            RenderFavorites();
            MainTabPane.SelectedTab = Favorites;
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            MainTabPane.SelectedTab = Settings;
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            MainTabPane.SelectedTab = About;
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            MainTabPane.SelectedTab = Exit;
        }

        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {
            MainTabPane.SelectedTab = Order;
        }

        private void About_Click(object sender, EventArgs e)
        {

        }

        private void Favorites_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton12_Click(object sender, EventArgs e)
        {
            MainTabPane.SelectedTab = Home;
        }

        private void guna2CircleButton11_Click(object sender, EventArgs e)
        {
            MainTabPane.SelectedTab = Order;
        }

        private void guna2CircleButton10_Click(object sender, EventArgs e)
        {
            MainTabPane.SelectedTab = Favorites;
        }

        private void guna2CircleButton9_Click(object sender, EventArgs e)
        {
            MainTabPane.SelectedTab = Settings;
        }

        private void guna2CircleButton8_Click_1(object sender, EventArgs e)
        {
            MainTabPane.SelectedTab = About;
        }

        private void guna2CircleButton7_Click_1(object sender, EventArgs e)
        {
            MainTabPane.SelectedTab = Exit;
        }

        private void Exit_Click(object sender, EventArgs e)
        {

        }

        private void guna2TabControl4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton13_Click(object sender, EventArgs e)
        {
            AddOrUpdateItem("Spaghetti", 1, 1.75);
            AddToCart("Spaghetti");
        }

        private void guna2GradientButton14_Click(object sender, EventArgs e)
        {
            AddOrUpdateItem("Pesto", 1, 1.75);
            AddToCart("Pesto");
        }

        private void guna2GradientButton15_Click(object sender, EventArgs e)
        {
            AddOrUpdateItem("Carbonara", 1, 1.75);
            AddToCart("Carbonara");
        }

        private void guna2GradientButton16_Click(object sender, EventArgs e)
        {
            AddOrUpdateItem("Seafood Marinara", 1, 1.75);
            AddToCart("Seafood Marinara");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        Dictionary<string, int> itemsAndQuantities = new Dictionary<string, int>();

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            // Order Summary
            AddOrUpdateItem("Chicken Salad", 1, 5.00);
            AddToCart("Chicken Salad");
        }

        private void AddToCart(string name)
        {
            myCart.Text += name + "\n";
        }

        private void AddOrUpdateItem(string itemName, int quantity, double cost)
        {
            if (itemsAndQuantities.ContainsKey(itemName))
            {
                itemsAndQuantities[itemName] += quantity;
            }
            else
            {
                itemsAndQuantities[itemName] = quantity;
            }
            UpdateTextBox();
            UpdateTotal();
        }

        private void UpdateTextBox()
        {
            textBox1.Clear();

            foreach (var item in itemsAndQuantities)
            {
                string itemName = item.Key;
                int quantity = item.Value;
                double cost = GetItemCost(itemName);

                if (itemName != "Tea")
                {
                    string formattedText = $"{itemName.PadRight(20)}\t{quantity.ToString().PadRight(10)}\t${(quantity * cost).ToString()}";
                    textBox1.AppendText(formattedText + Environment.NewLine);
                }
                else
                {
                    string formattedText = $"{itemName.PadRight(25)}\t{quantity.ToString().PadRight(10)}\t${(quantity * cost).ToString()}";
                    textBox1.AppendText(formattedText + Environment.NewLine);
                }
            }
        }

        private void UpdateTotal()
        {
            double totalCost = CalculateTotalCost();
            lblTotal.Text = $"$ {totalCost.ToString()}";
        }

        private double CalculateTotalCost()
        {
            double totalCost = 0;

            foreach (var item in itemsAndQuantities)
            {
                string itemName = item.Key;
                int quantity = item.Value;
                double cost = GetItemCost(itemName);

                totalCost += quantity * cost;
            }

            return totalCost;
        }

        private double GetItemCost(string itemName)
        {
            if (itemName == "Chicken Salad")
            {
                return 5.00;
            }
            else if (itemName == "Ham and Cheese")
            {
                return 4.50;
            }
            else if (itemName == "Turkey")
            {
                return 4.50;
            }
            else if (itemName == "Vegetable Wrap")
            {
                return 3.50;
            }
            else if (itemName == "Tuna Salad")
            {
                return 4.00;
            }
            else if (itemName == "Roast Beef")
            {
                return 4.75;
            }
            else if (itemName == "Orange")
            {
                return 1.75;
            }
            else if (itemName == "Soda")
            {
                return 2.00;
            }
            else if (itemName == "Tea")
            {
                return 1.50;
            }
            else if (itemName == "Coffee")
            {
                return 1.50;
            }
            else if (itemName == "Lemonade")
            {
                return 2.00;
            }
            else if (itemName == "Spaghetti")
            {
                return 1.75;
            }
            else if (itemName == "Pesto")
            {
                return 1.75;
            }
            else if (itemName == "Carbonara")
            {
                return 1.75;
            }
            else if (itemName == "Seafood Marinara")
            {
                return 1.75;
            }
            else if (itemName == "Ice Cream")
            {
                return 1.25;
            }
            else if (itemName == "Fruit Salad")
            {
                return 1.75;
            }
            else if (itemName == "Halo-Halo")
            {
                return 1.50;
            }
            else if (itemName == "Cookie")
            {
                return 1.25;
            }
            else
            {
                return 0.00;
            }
        }

        private void AddToPanel(string name, double price)
        {
            Panel itemPanel = new Panel();
            itemPanel.Size = new Size(284, 122);
            itemPanel.Dock = DockStyle.Top;

            Label itemLabel = new Label();
            itemLabel.Text = name;
            itemLabel.AutoSize = true;
            itemLabel.ForeColor = Color.White;

            NumericUpDown quantity = new NumericUpDown();
            quantity.Value = 1;
            quantity.Dock = DockStyle.Right;

            itemPanel.Controls.Add(itemLabel);
            itemPanel.Controls.Add(quantity);

            myCart.Controls.Add(itemPanel);
        }

        private void guna2CircleButton7_Click_2(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit the application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Closing_Screen closing_screen = new Closing_Screen();
                closing_screen.Show();
                this.Hide();
            }
        }

        private void label80_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            AddOrUpdateItem("Ham and Cheese", 1, 4.50);
            AddToCart("Ham and Cheese");
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            AddOrUpdateItem("Turkey", 1, 4.50);
            AddToCart("Turkey");
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            AddOrUpdateItem("Vegetable Wrap", 1, 3.50);
            AddToCart("Vegetable Wrap");
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            AddOrUpdateItem("Tuna Salad", 1, 4.00);
            AddToCart("Tuna Salad");
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            AddOrUpdateItem("Roast Beef", 1, 4.75);
            AddToCart("Roast Beef");
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            AddOrUpdateItem("Orange", 1, 1.75);
            AddToCart("Orange");
        }

        private void guna2GradientButton11_Click(object sender, EventArgs e)
        {
            AddOrUpdateItem("Soda", 1, 2.00);
            AddToCart("Soda");
        }

        private void guna2GradientButton12_Click(object sender, EventArgs e)
        {
            AddOrUpdateItem("Tea", 1, 1.50);
            AddToCart("Tea");
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            AddOrUpdateItem("Coffee", 1, 1.50);
            AddToCart("Coffee");
        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
            AddOrUpdateItem("Lemonade", 1, 2.00);
            AddToCart("Lemonade");
        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            AddOrUpdateItem("Bottled Water", 1, 0.00);
            AddToCart("Bottled Water");
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clearAll();
        }

        void clearAll()
        {
            myCart.Clear();
            textBox1.Clear();
            itemsAndQuantities.Clear();

            lblTotal.Text = "$ 0.00";

            guna2CustomRadioButton1.Checked = false;
            guna2CustomRadioButton2.Checked = false;
            guna2CustomRadioButton3.Checked = false;
            guna2CustomRadioButton4.Checked = false;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string selectedDesertName = GetSelectedDesertName();



            if (!string.IsNullOrEmpty(selectedDesertName))
            {
                AddOrUpdateItem(selectedDesertName, GetSelectedDesertQuantity(), GetSelectedDesertCost());

                if (textBox1.Text.Trim() == "") // Empty Cart
                {
                    MessageBox.Show("Your cart is empty. Please add items before checking out.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Receipt MessageBox
                string orderSummary = "Order Summary\n----------------------------------------------------------------------\n";
                orderSummary += textBox1.Text.Trim() + "\n";
                orderSummary += "----------------------------------------------------------------------\nTotal: " + lblTotal.Text;

                MessageBox.Show(orderSummary, "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                print(); // Print Receipt
                clearAll(); // Clear everything after printing receipt
            }
            else
            {
                string orderSummary = "Order Summary\n----------------------------------------------------------------------\n";
                orderSummary += textBox1.Text.Trim() + "\n";
                orderSummary += "----------------------------------------------------------------------\nTotal: " + lblTotal.Text;

                MessageBox.Show(orderSummary, "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                print();
                clearAll();
            }
        }

        void print()
        {
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            PrintDocument printDocument1 = new PrintDocument();

            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);

            RectangleF area = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height);
            e.Graphics.DrawString(textBox1.Text, font, brush, area);
        }

        private string GetSelectedDesertName()
        {
            if (guna2CustomRadioButton1.Checked)
            {
                return "Ice Cream";
            }
            else if (guna2CustomRadioButton2.Checked)
            {
                return "Fruit Salad";
            }
            else if (guna2CustomRadioButton3.Checked)
            {
                return "Halo-Halo";
            }
            else if (guna2CustomRadioButton4.Checked)
            {
                return "Cookie";
            }
            return "";
        }

        private int GetSelectedDesertQuantity()
        {
            return 1;
        }

        private double GetSelectedDesertCost()
        {
            if (guna2CustomRadioButton1.Checked)
            {
                return 1.25;
            }
            else if (guna2CustomRadioButton2.Checked)
            {
                return 1.75;
            }
            else if (guna2CustomRadioButton3.Checked)
            {
                return 1.50;
            }
            else if (guna2CustomRadioButton4.Checked)
            {
                return 1.25;
            }
            return 0.00;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                AddFavorites("Chicken Salad");
            }
            else if (checkBox1.Checked == false)
            {
                RemoveFavorites("Chicken Salad");
            }
        }

        private void AddFavorites(string v)
        {
            favorites.Add(v);
        }

        private void RemoveFavorites(string item)
        {
            favorites.Remove(item);
        }

        private void RenderFavorites()
        {
            favoritesHere.Text = string.Empty;

            foreach (string favorite in favorites)
            {
                favoritesHere.Text += favorite + "\n";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                AddFavorites("Ham and Cheese");
            }
            else if (checkBox4.Checked == false)
            {
                RemoveFavorites("Ham and Cheese");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                AddFavorites("Turkey");
            }
            else if (checkBox2.Checked == false)
            {
                RemoveFavorites("Turkey");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                AddFavorites("Vegetable Wrap");
            }
            else if (checkBox5.Checked == false)
            {
                RemoveFavorites("Vegetable Wrap");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                AddFavorites("Tuna Salad");
            }
            else if (checkBox3.Checked == false)
            {
                RemoveFavorites("Tuna Salad");
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                AddFavorites("Roast Beef");
            }
            else if (checkBox6.Checked == false)
            {
                RemoveFavorites("Roast Beef");
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                AddFavorites("Orange");
            }
            else if (checkBox7.Checked == false)
            {
                RemoveFavorites("Orange");
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                AddFavorites("Soda");
            }
            else if (checkBox10.Checked == false)
            {
                RemoveFavorites("Soda");
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                AddFavorites("Tea");
            }
            else if (checkBox8.Checked == false)
            {
                RemoveFavorites("Tea");
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                AddFavorites("Coffee");
            }
            else if (checkBox11.Checked == false)
            {
                RemoveFavorites("Coffee");
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                AddFavorites("Lemonade");
            }
            else if (checkBox11.Checked == false)
            {
                RemoveFavorites("Lemonade");
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                AddFavorites("Bottled Water");
            }
            else if (checkBox12.Checked == false)
            {
                RemoveFavorites("Bottled Water");
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                AddFavorites("Spaghetti");
            }
            else if (checkBox13.Checked == false)
            {
                RemoveFavorites("Spaghetti");
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                AddFavorites("Pesto");
            }
            else if (checkBox15.Checked == false)
            {
                RemoveFavorites("Pesto");
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                AddFavorites("Carbonara");
            }
            else if (checkBox14.Checked == false)
            {
                RemoveFavorites("Carbonara");
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                AddFavorites("Seafood Marinara");
            }
            else if (checkBox16.Checked == false)
            {
                RemoveFavorites("Seafood Marinara");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
