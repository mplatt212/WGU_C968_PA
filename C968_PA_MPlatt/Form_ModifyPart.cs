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
    public partial class Form_ModifyPart : Form
    {
        Part selectedPart;
        public int id;
        public string name;
        public int qty;
        public decimal price;
        public int max;
        public int min;
        public int machineID;
        public string companyName;
        public bool digit;

        public Form_ModifyPart()
        {
            InitializeComponent();
        }

        public Form_ModifyPart(Part currentPart)
        {
            InitializeComponent();
            this.selectedPart = currentPart;
            textBox_modPartID.Text = currentPart.PartID.ToString();
            textBox_modName.Text = currentPart.Name.ToString();
            textBox_modQty.Text = currentPart.InStock.ToString();
            textBox_modPrice.Text = currentPart.Price.ToString();
            textBox_modMin.Text = currentPart.Min.ToString();
            textBox_modMax.Text = currentPart.Max.ToString();

            if (currentPart is Inhouse)
            {
                radioButton_Inhouse.Checked = true;
                Inhouse inhouse = currentPart as Inhouse;
                textBox_modMachID_CoName.Text = inhouse.MachineID.ToString();
                label_MachineID_CoName.Text = "Machine ID*";
                machineID = int.Parse(textBox_modMachID_CoName.Text);
                digit = true;
    }
            else
            {
                radioButton_Outsourced.Checked = true;
                Outsourced outsourced = currentPart as Outsourced;
                textBox_modMachID_CoName.Text = outsourced.CompanyName.ToString();
                label_MachineID_CoName.Text = "Company Name*";
                companyName = textBox_modMachID_CoName.Text;
                digit = false;
            }
        }

        private void MachineID_CoName_Change(object sender, EventArgs e)
        {
            textBox_modMachID_CoName.Text = "";
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
            if (radioButton_Inhouse.Checked == true)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
                machineID = 0;
                digit = true;
            }
            else
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                companyName = "";
                digit = false;
            }
        }

        private void btn_modifyPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modifyPartSave_Click(object sender, EventArgs e)
        {
            int index = Inventory.AllParts.IndexOf(selectedPart);

            //Error handling for PartID
            if (textBox_modPartID.Text == "")
            {
                textBox_modPartID.Invalidate();
                MessageBox.Show("Part ID is a required field.");
                textBox_modPartID.BackColor = Color.Red;
            }
            else
            {
                id = int.Parse(textBox_modPartID.Text);
                textBox_modPartID.BackColor = Color.White;
            }
            //Error handling for PartName
            if (textBox_modName.Text == "")
            {
                textBox_modName.Invalidate();
                MessageBox.Show("Name is a required field.");
                textBox_modName.BackColor = Color.Red;
                name = "";
            }
            else
            {
                name = textBox_modName.Text;
                textBox_modName.BackColor = Color.White;
            }
            //Error handling for Inventory
            if (textBox_modQty.Text == "")
            {
                textBox_modQty.Invalidate();
                MessageBox.Show("Inventory is a required field.");
                textBox_modQty.BackColor = Color.Red;
                qty = -1;
            }
            else
            {
                qty = int.Parse(textBox_modQty.Text);
                textBox_modQty.BackColor = Color.White;
            }
            //Error handling for PartPrice
            if (textBox_modPrice.Text == "")
            {
                textBox_modPrice.Invalidate();
                MessageBox.Show("Price is a required field.");
                textBox_modPrice.BackColor = Color.Red;
                price = -1;
            }
            else
            {
                price = decimal.Parse(textBox_modPrice.Text);
                textBox_modPrice.BackColor = Color.White;
            }
            //Error handling for PartMin
            if (textBox_modMin.Text == "")
            {
                textBox_modMin.Invalidate();
                MessageBox.Show("Minimum is a required field.");
                textBox_modMin.BackColor = Color.Red;
                min = -1;
            }
            else if (int.Parse(textBox_modMin.Text) >= qty)
            {
                MessageBox.Show("Minimum must be less than inventory.");
            }
            else
            {
                min = int.Parse(textBox_modMin.Text);
                textBox_modMin.BackColor = Color.White;
            }
            //Error handling for PartMax
            if (textBox_modMax.Text == "")
            {
                textBox_modMax.Invalidate();
                MessageBox.Show("Maximum is a required field.");
                textBox_modMax.BackColor = Color.Red;
                max = -1;
            }
            else if (int.Parse(textBox_modMax.Text) <= qty)
            {
                MessageBox.Show("Maximum must be greater than inventory.");
            }
            else
            {
                max = int.Parse(textBox_modMax.Text);
                textBox_modMax.BackColor = Color.White;
            }

            //Error handling for MachineID and CompanyName
            if (radioButton_Inhouse.Checked == true && textBox_modMachID_CoName.Text == "")
            {
                textBox_modMachID_CoName.Invalidate();
                MessageBox.Show("MachineID is a required field.");
                textBox_modMachID_CoName.BackColor = Color.Red;
                machineID = -1;
            }
            else if (radioButton_Outsourced.Checked == true && textBox_modMachID_CoName.Text == "")
            {
                textBox_modMax.Invalidate();
                MessageBox.Show("Company name is a required field.");
                textBox_modMachID_CoName.BackColor = Color.Red;
            }
            else if (radioButton_Inhouse.Checked == true)
            {
                if (digit)
                {
                    machineID = int.Parse(textBox_modMachID_CoName.Text);
                    textBox_modMachID_CoName.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show("Machine ID must be a number.");
                }
            }
            else if (radioButton_Outsourced.Checked == true)
            {
                if (!digit)
                {
                    companyName = textBox_modMachID_CoName.Text;
                    textBox_modMachID_CoName.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show("Company name must be a string.");
                }
            }

            //Add new part and close out the form
            if (radioButton_Inhouse.Checked == true && id > 0 && name != "" && price >= 0 && qty >= 0 && min >= 0 && max >= 0 && machineID >= 0)
            {
                if (machineID is int)
                {
                    Console.WriteLine(price);
                    Inventory.updatePart(index, new Inhouse(id, name, price, qty, min, max, machineID));
                    this.Close();
                }
                else
                {
                    return;
                }                       
            }
            else if (radioButton_Outsourced.Checked == true && id > 0 && name != "" && price >= 0 && qty >= 0 && min >= 0 && max >= 0 && companyName != "")
            {
                if (companyName is string)
                {
                    Inventory.updatePart(index, new Outsourced(id, name, price, qty, min, max, companyName));
                    this.Close();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
