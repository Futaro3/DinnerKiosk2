using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Form2 : Form
    {
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
        }

        private void guna2GradientButton14_Click(object sender, EventArgs e)
        {
        }

        private void guna2GradientButton15_Click(object sender, EventArgs e)
        {
        }

        private void guna2GradientButton16_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            AddToPanel("Chicken Salad", 5.00);
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
            Closing_Screen closing_screen = new Closing_Screen();
            closing_screen.Show();
            this.Hide();
        }

        private void label80_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
