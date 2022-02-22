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
            dgAssocParts.DataSource = Product.AssociatedParts;
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

            dgPartsForProds.DataSource = Inventory.AllParts;
            dgAssocParts.DataSource = Product.AssociatedParts;
            dgPartsForProds.AllowUserToAddRows = false;
            dgAssocParts.AllowUserToAddRows = false;
        }

        private void btn_prodCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_prodAdd_Click(object sender, EventArgs e)
        {
            if (dgPartsForProds.CurrentRow.Selected)
            {
                Part part = dgPartsForProds.CurrentRow.DataBoundItem as Part;
                Product.addAssociatedPart(part);
            }
            else
            {
                MessageBox.Show("Please select a part to add.");
            }
        }

        private void btn_prodDelete_Click(object sender, EventArgs e)
        {
            if (Product.AssociatedParts.Count > 0)
            {
                if (dgAssocParts.CurrentRow.Selected)
                {
                    /*Part part = dgAssocParts.CurrentRow.DataBoundItem as Part;
                    int id = part.PartID;*/
                    int index = dgAssocParts.CurrentRow.Index;
                    Product.removeAssociatedPart(index);
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
            if (name != "" && price != 0 && qty != 0 && max != 0)
            {
                Inventory.Products.RemoveAt(index);
                Inventory.addProduct(new Product(id, name, price, qty, min, max));
                this.Close();
            }
            else
            {
                Console.WriteLine("Not working");
                return;
            }
        }
    }
}
