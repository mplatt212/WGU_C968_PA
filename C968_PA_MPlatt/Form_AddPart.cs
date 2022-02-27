using C968_PA_MPlatt.Models;
using System;
using System.Drawing;
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
        public bool digit;

        public Form_AddPart()
        {
            InitializeComponent();
            radioButton_Inhouse.Checked = true;
            id = Inventory.Products.Count + 1;
            textBox_PartID.Text = id.ToString();
        }

        private void MachineID_CoName_Change(object sender, EventArgs e)
        {
            textBox_PartMachID_CoName.Text = "";
            if (radioButton_Inhouse.Checked == true)
            {
                label_MachineID_CoName.Text = "Machine ID*";
            }
            else
            {
                label_MachineID_CoName.Text = "Company Name*";
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
            //Error handling for PartName
            if (textBox_PartName.Text == "")
            {
                textBox_PartName.Invalidate();
                MessageBox.Show("Name is a required field.");
                textBox_PartName.BackColor = Color.Red;
                name = "";
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
                qty = -1;
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
                price = -1;
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
                min = -1;
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
                max = -1;
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
                machineID = -1;
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
            if (radioButton_Inhouse.Checked == true && id > 0 && name != "" && price >= 0 && qty >= 0 && min >= 0 && max >= 0 && machineID >= 0)
            {
                if(machineID is int)
                {
                    Inventory.addPart(new Inhouse(id, name, price, qty, min, max, machineID));
                    this.Close();
                } else
                {
                    return;
                }
            }
            else if (radioButton_Outsourced.Checked == true && id > 0 && name != "" && price >= 0 && qty >= 0 && min >= 0 && max >= 0 && companyName != "")
            {
                if(companyName is string)
                {
                    Inventory.addPart(new Outsourced(id, name, price, qty, min, max, companyName));
                    this.Close();
                } else
                {
                    return;
                }
            }
        }

        private void closeForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
