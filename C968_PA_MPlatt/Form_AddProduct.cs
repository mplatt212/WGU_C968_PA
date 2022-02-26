using C968_PA_MPlatt.Models;
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
    public partial class Form_AddProduct : Form
    {
        Part currentPart;
        Product newProduct;
        public BindingList<Part> AssociatedParts;
        public int id;
        public string name;
        public int qty;
        public double price;
        public int max;
        public int min;

        public Form_AddProduct()
        {
            InitializeComponent();
            newProduct = new Product();

            AssociatedParts = new BindingList<Part>();
            dgPartsForProds.DataSource = Inventory.AllParts;
            dgAssocParts.DataSource = newProduct.AssociatedParts;
            dgPartsForProds.AllowUserToAddRows = false;
            dgAssocParts.AllowUserToAddRows = false;

            dgPartsForProds.Columns[0].HeaderText = "Part ID";
            dgPartsForProds.Columns[3].HeaderText = "Inventory";
            dgAssocParts.Columns[0].HeaderText = "Part ID";
            dgAssocParts.Columns[3].HeaderText = "Inventory";
            dgPartsForProds.Columns[0].Width = 62;
            dgPartsForProds.Columns[3].Width = 55;
            dgPartsForProds.Columns[4].Width = 55;
            dgPartsForProds.Columns[5].Width = 55;
            dgAssocParts.Columns[0].Width = 62;
            dgAssocParts.Columns[3].Width = 55;
            dgAssocParts.Columns[4].Width = 55;
            dgAssocParts.Columns[5].Width = 55;
        }

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgPartsForProds.ClearSelection();
            dgAssocParts.ClearSelection();
        }

        private void textBoxProdName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxProdQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxProdPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxProdMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxProdMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_prodSave_Click(object sender, EventArgs e)
        {
            id = Inventory.Products.Count + 1;

            //Error handling for PartName
            if (textBox_ProdName.Text == "")
            {
                textBox_ProdName.Invalidate();
                MessageBox.Show("Name is a required field.");
                textBox_ProdName.BackColor = Color.Red;
                name = "";
            }
            else
            {
                name = textBox_ProdName.Text;
                textBox_ProdName.BackColor = Color.White;
            }
            //Error handling for Inventory
            if (textBox_ProdQty.Text == "")
            {
                textBox_ProdQty.Invalidate();
                MessageBox.Show("Inventory is a required field.");
                textBox_ProdQty.BackColor = Color.Red;
                qty = -1;
            }
            else
            {
                qty = int.Parse(textBox_ProdQty.Text);
                textBox_ProdQty.BackColor = Color.White;
            }
            //Error handling for PartPrice
            if (textBox_ProdPrice.Text == "")
            {
                textBox_ProdPrice.Invalidate();
                MessageBox.Show("Price is a required field.");
                textBox_ProdPrice.BackColor = Color.Red;
                price = -1;
            }
            else
            {
                price = double.Parse(textBox_ProdPrice.Text);
                textBox_ProdPrice.BackColor = Color.White;
            }
            //Error handling for PartMin
            if (textBox_ProdMin.Text == "")
            {
                textBox_ProdMin.Invalidate();
                MessageBox.Show("Minimum is a required field.");
                textBox_ProdMin.BackColor = Color.Red;
                min = -1;
            }
            else if (int.Parse(textBox_ProdMin.Text) >= qty)
            {
                MessageBox.Show("Minimum must be less than inventory.");
            }
            else
            {
                min = int.Parse(textBox_ProdMin.Text);
                textBox_ProdMin.BackColor = Color.White;
            }
            //Error handling for PartMax
            if (textBox_ProdMax.Text == "")
            {
                textBox_ProdMax.Invalidate();
                MessageBox.Show("Maximum is a required field.");
                textBox_ProdMax.BackColor = Color.Red;
                max = -1;
            }
            else if (int.Parse(textBox_ProdMax.Text) <= qty)
            {
                MessageBox.Show("Maximum must be greater than inventory.");
            }
            else
            {
                max = int.Parse(textBox_ProdMax.Text);
                textBox_ProdMax.BackColor = Color.White;
            }

            //Add new part and close out the form
            if (name != "" && price >= 0 && qty >= 0 && min >= 0 && max >= 0)
            {
                newProduct = new Product(id, name, price, qty, min, max, newProduct.AssociatedParts);
                Inventory.addProduct(newProduct);
              /*  Product newProduct = new Product(id, name, price, qty, min, max, AssociatedParts);
                this.AssociatedParts = newProduct.AssociatedParts;*/
                this.Close();
            } else
            {
                return;
            }
        }

        private void btn_prodAdd_Click(object sender, EventArgs e)
        {
            if (dgPartsForProds.CurrentRow.Selected | currentPart != null)
            {
                //Part part = dgPartsForProds.CurrentRow.DataBoundItem as Part;
                newParts.Add(currentPart);
                newProduct.addAssociatedPart(currentPart);
            }
            else
            {
                MessageBox.Show("Please select a part to add.");
            }
        }

        private void btn_prodDelete_Click(object sender, EventArgs e)
        {
            if (AssociatedParts.Count > 0)
            {
                if (dgAssocParts.CurrentRow.Selected)
                {
                    /*Part part = dgAssocParts.CurrentRow.DataBoundItem as Part;
                    int id = part.PartID;*/
                    int index = dgAssocParts.CurrentRow.Index;
                    newProduct.removeAssociatedPart(index);
                }
                else
                {
                    MessageBox.Show("Please select an item to delete.");
                }
            }
            else
            {
                MessageBox.Show("Please add associated items first.");
            }
        }

        private void btn_prodCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (dgPartsForProds.CurrentRow != null)
            {
                this.currentPart = dgPartsForProds.CurrentRow.DataBoundItem as Part;
            }
        }

        private void filterSearchParts(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_searchPart_Click(object sender, EventArgs e)
        {
            string input = searchInputParts.Text;

            if (Inventory.AllParts != null)
            {
                foreach (DataGridViewRow row in dgPartsForProds.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(input) | row.Cells[1].Value.ToString().ToLower().Contains(input.ToLower()))
                    {
                        row.Selected = true;
                        int index = row.Index;
                        Part part = Inventory.lookupPart(index);
                        this.currentPart = part;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid entry.");
            }
        }
    }
}
