using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_PA_MPlatt
{
    public partial class Form_AddPart : Form
    {
        public int id;
        public string name;
        public int qty;
        public decimal price;
        public int max;
        public int min;
        public int machineID;
        public string companyName;

        public Form_AddPart()
        {
            InitializeComponent();
        }

        private void textBoxPartID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPartName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPartQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPartPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPartMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPartMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void savePart(object sender, EventArgs e)
        {
            //Error handling for PartID
            if (textBox_PartID.Text == "")
            {
                textBox_PartID.Invalidate();
                MessageBox.Show("Part ID is a required field.");
                textBox_PartID.BackColor = Color.Red;
            } else
            {
                id = int.Parse(textBox_PartID.Text);
                textBox_PartID.BackColor = Color.White;
            }
            //Error handling for PartName
            if (textBox_PartName.Text == "")
            {
                textBox_PartName.Invalidate();
                MessageBox.Show("Name is a required field.");
                textBox_PartName.BackColor = Color.Red;
            }
            else
            {
                name = textBox_PartName.Text;
                textBox_PartName.BackColor = Color.White;
            }
            //Error handling for Inventory
            if (textBox_PartQty.Text == "")
            {
                textBox_PartQty.Invalidate();
                MessageBox.Show("Inventory is a required field.");
                textBox_PartQty.BackColor = Color.Red;
            }
            else
            {
                qty = int.Parse(textBox_PartQty.Text);
                textBox_PartQty.BackColor = Color.White;
            }
            //Error handling for PartPrice
            if (textBox_PartPrice.Text == "")
            {
                textBox_PartPrice.Invalidate();
                MessageBox.Show("Price is a required field.");
                textBox_PartPrice.BackColor = Color.Red;
            }
            else
            {
                price = decimal.Parse(textBox_PartPrice.Text);
                textBox_PartPrice.BackColor = Color.White;
            }
            //Error handling for PartMin
            if (textBox_PartMin.Text == "")
            {
                textBox_PartMin.Invalidate();
                MessageBox.Show("Minimum is a required field.");
                textBox_PartMin.BackColor = Color.Red;
            }
            else
            {
                min = int.Parse(textBox_PartMin.Text);
                textBox_PartMin.BackColor = Color.White;
            }
            //Error handling for PartMax
            if (textBox_PartMax.Text == "")
            {
                textBox_PartMax.Invalidate();
                MessageBox.Show("Maximum is a required field.");
                textBox_PartMax.BackColor = Color.Red;
            }
            else
            {
                max = int.Parse(textBox_PartMax.Text);
                textBox_PartMax.BackColor = Color.White;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
