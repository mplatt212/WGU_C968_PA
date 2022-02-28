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
    public partial class Form_ModifyProduct : Form
    {
        Product currentProd;
        Part currentPart;
        public BindingList<Part> associatedParts;
        public BindingList<Part> newParts;
        public int index;
        public int id;
        public string name;
        public int qty;
        public double price;
        public int max;
        public int min;

        public Form_ModifyProduct()
        {
            InitializeComponent();
            dgPartsForProds.DataSource = Inventory.AllParts;
            dgAssocParts.DataSource = currentProd.AssociatedParts;
            dgPartsForProds.AllowUserToAddRows = false;
            dgAssocParts.AllowUserToAddRows = false;
        }

        public Form_ModifyProduct(Product currentProduct, int index)
        {
            InitializeComponent();
            this.currentProd = currentProduct;
            this.index = index;
            this.id = currentProd.ProductID;
            this.name = currentProd.Name;
            this.qty = currentProd.InStock;
            this.price = currentProd.Price;
            this.max = currentProd.Min;
            this.min = currentProd.Max;
            textBox_modProdID.Text = currentProd.ProductID.ToString();
            textBox_modName.Text = currentProd.Name.ToString();
            textBox_modQty.Text = currentProd.InStock.ToString();
            textBox_modPrice.Text = currentProd.Price.ToString();
            textBox_modMin.Text = currentProd.Min.ToString();
            textBox_modMax.Text = currentProd.Max.ToString();

            this.associatedParts = currentProd.AssociatedParts;
            newParts = new BindingList<Part>();

            dgPartsForProds.DataSource = Inventory.AllParts;
            dgAssocParts.DataSource = currentProd.AssociatedParts;
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

        private void btn_prodCancel_Click(object sender, EventArgs e)
        {
            int count = newParts.Count - 1;
            for(int i = currentProd.AssociatedParts.Count - 1; i >= 0; i--)
            {
                if(count >= 0)
                {
                    if (currentProd.AssociatedParts[i] == newParts[count])
                    {
                        Console.WriteLine(currentProd.AssociatedParts[i].Name);
                        Console.WriteLine(newParts[count].Name);
                        currentProd.removeAssociatedPart(i);
                    }
                    count -= 1;
                }
            }
            this.Close();
        }

        private void btn_prodAdd_Click(object sender, EventArgs e)
        {
            if (dgPartsForProds.CurrentRow.Selected | currentPart != null)
            {
                newParts.Add(currentPart);
                currentProd.addAssociatedPart(currentPart);
            }
            else
            {
                MessageBox.Show("Please select a part to add.");
            }
        }

        private void btn_prodDelete_Click(object sender, EventArgs e)
        {
            if (currentProd.AssociatedParts.Count > 0)
            {
                if (dgAssocParts.CurrentRow.Selected)
                {
                    int index = dgAssocParts.CurrentRow.Index;
                    currentProd.removeAssociatedPart(index);
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

        private void btn_prodSave_Click(object sender, EventArgs e)
        {
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
                price = double.Parse(textBox_modPrice.Text);
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

            //Add new part and close out the form
            if (name != "" && price >= 0 && qty >= 0 && min >= 0 && max >= 0)
            {
                if (currentProd.AssociatedParts.Count < 1)
                {
                    MessageBox.Show("Must add at least one part.");
                } else
                {
                    Inventory.Products.Remove(currentProd);
                    currentProd = new Product(id, name, price, qty, min, max, currentProd.AssociatedParts);
                    Inventory.addProduct(currentProd);
                    this.Close();
                }
            }
            else
            {
                return;
            }
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
                        Part part = Product.lookupAssociatedPart(index);
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

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgPartsForProds.ClearSelection();
            dgAssocParts.ClearSelection();
        }
    }
}
