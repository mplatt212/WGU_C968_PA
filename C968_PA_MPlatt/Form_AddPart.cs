using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C968_PA_MPlatt.Models;

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
        public bool digit;

        public Form_AddPart()
        {
            InitializeComponent();
            radioButton_Inhouse.Checked = true;
        }

        private void MachineID_CoName_Change(object sender, EventArgs e)
        {
            if (radioButton_Inhouse.Checked == true)
            {
                label_MachineID_CoName.Text = "Machine ID";
            }
            else
            {
                label_MachineID_CoName.Text = "Company Name";
            }
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
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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

        private void textBoxMachIDCoName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(radioButton_Inhouse.Checked == true)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
                digit = true;
            } else
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                digit = false;
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
            else if(int.Parse(textBox_PartMin.Text) >= qty)
            {
                MessageBox.Show("Minimum must be less than inventory.");
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
            else if (int.Parse(textBox_PartMax.Text) <= qty)
            {
                MessageBox.Show("Maximum must be greater than inventory.");
            }
            else
            {
                max = int.Parse(textBox_PartMax.Text);
                textBox_PartMax.BackColor = Color.White;
            }

            //Error handling for MachineID and CompanyName
            if (radioButton_Inhouse.Checked == true && textBox_PartMachID_CoName.Text == "")
            {
                textBox_PartMachID_CoName.Invalidate();
                MessageBox.Show("MachineID is a required field.");
                textBox_PartMachID_CoName.BackColor = Color.Red;
            }
            else if(radioButton_Outsourced.Checked == true && textBox_PartMachID_CoName.Text == "")
            {
                textBox_PartMax.Invalidate();
                MessageBox.Show("Company name is a required field.");
                textBox_PartMachID_CoName.BackColor = Color.Red;
            }
            else if(radioButton_Inhouse.Checked == true)
            {
                if (digit)
                {
                    machineID = int.Parse(textBox_PartMachID_CoName.Text);
                    textBox_PartMachID_CoName.BackColor = Color.White;
                } else
                {
                    MessageBox.Show("Machine ID must be a number.");
                }
            }
            else if (radioButton_Outsourced.Checked == true)
            {
                if(!digit)
                {
                    companyName = textBox_PartMachID_CoName.Text;
                    textBox_PartMachID_CoName.BackColor = Color.White;
                } else
                {
                    MessageBox.Show("Company name must be a string.");
                }
            }

            //Add new part and close out the form
            if (radioButton_Inhouse.Checked == true && id != 0 && name != "" && price != 0 && qty != 0 && min != 0 && max != 0 && machineID != 0)
            {
                //Inventory.AllParts.Add(new Inhouse(id, name, price, qty, min, max, machineID));
                Inventory.addPart(new Inhouse(id, name, price, qty, min, max, machineID));
                this.Close();
            }
            else if (radioButton_Outsourced.Checked == true && id != 0 && name != "" && price != 0 && qty != 0 && min != 0 && max != 0 && companyName != "")
            {
                //Inventory.AllParts.Add(new Outsourced(id, name, price, qty, min, max, companyName));
                Inventory.addPart(new Outsourced(id, name, price, qty, min, max, companyName));
                this.Close();
            }
        }

        private void closeForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
