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
            }
            else
            {
                radioButton_Outsourced.Checked = true;
                Outsourced outsourced = currentPart as Outsourced;
                textBox_modMachID_CoName.Text = outsourced.CompanyName.ToString();
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

        private void btn_modifyPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modifyPartSave_Click(object sender, EventArgs e)
        {
            Inventory.AllParts.Remove(selectedPart);

            int id = int.Parse(textBox_modPartID.Text);
            string name = textBox_modName.Text;
            int qty = int.Parse(textBox_modQty.Text);
            decimal price = decimal.Parse(textBox_modPrice.Text);
            int min = int.Parse(textBox_modMin.Text);
            int max = int.Parse(textBox_modMax.Text);
            if (radioButton_Inhouse.Checked == true) 
            { 
                int machineID = int.Parse(textBox_modMachID_CoName.Text);

                Inventory.AllParts.Add(new Inhouse(id, name, price, qty, min, max, machineID));
            } else
            {
                string coName = textBox_modMachID_CoName.Text;
                Inventory.AllParts.Add(new Outsourced(id, name, price, qty, min, max, coName));
            }
        }
    }
}
