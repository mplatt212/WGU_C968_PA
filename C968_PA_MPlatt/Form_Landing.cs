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
    public partial class formMain : System.Windows.Forms.Form
    {
        Part currentPart;
        Product currentProduct;
       
        public formMain()
        {
            InitializeComponent();
            dgProducts.DataSource = Inventory.DefaultProducts();
            dgParts.DataSource = Inventory.DefaultParts();
            dgParts.AllowUserToAddRows = false;
            dgProducts.AllowUserToAddRows = false;
        }
        
        private void openAddPartForm_Click(object sender, EventArgs e)
        {
            Form_AddPart partForm = new Form_AddPart();
            partForm.Show();
        }

        private void openModifyPartForm_Click(object sender, EventArgs e)
        {
            if (!dgParts.CurrentRow.Selected && currentPart == null)
            {
                MessageBox.Show("No row currently selected.");
                return;
            } else
            {
                //this.currentPart = dgParts.CurrentRow.DataBoundItem as Part;
                if (currentPart != null)
                {
                    int index = dgParts.CurrentCell.RowIndex;
                    int id = currentPart.PartID;
                    string name = currentPart.Name;
                    int qty = currentPart.InStock;
                    decimal price = currentPart.Price;
                    int min = currentPart.Min;
                    int max = currentPart.Max;

                    Form_ModifyPart partForm = new Form_ModifyPart(currentPart);
                    partForm.Show();
                }
                
            }
        }

        private void btn_closeProg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (dgParts.CurrentRow != null)
            {
                this.currentPart = dgParts.CurrentRow.DataBoundItem as Part;
            }
        }

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgParts.ClearSelection();
            dgProducts.ClearSelection();
        }

        private void btn_deletePart_Click(object sender, EventArgs e)
        {
            if(!dgParts.CurrentRow.Selected)
            {
                MessageBox.Show("No row currently selected.");
            } else
            {
                //this.currentPart = dgParts.CurrentRow.DataBoundItem as Part;
                Inventory.deletePart(currentPart);
            }
        }

        private void btn_deleteProd_Click(object sender, EventArgs e)
        {
            if (!dgProducts.CurrentRow.Selected)
            {
                MessageBox.Show("No row currently selected.");
            }
            else
            {
                //Product currentProduct = dgProducts.CurrentRow.DataBoundItem as Product;
                int index = dgProducts.CurrentRow.Index;
                Inventory.removeProduct(index);
            }

        }

        private void btn_addProd_Click(object sender, EventArgs e)
        {
            Form_AddProduct productForm = new Form_AddProduct();
            productForm.Show();
        }

        private void btn_modifyProd_Click(object sender, EventArgs e)
        {
            if(dgProducts.CurrentRow.Selected | currentProduct != null) 
            {
                int index = dgProducts.CurrentRow.Index;
                //Product selectedProduct = dgProducts.CurrentRow.DataBoundItem as Product;
                Form_ModifyProduct productForm = new Form_ModifyProduct(this.currentProduct, index);
                productForm.Show();
            } else
            {
                MessageBox.Show("Please select a product to modify.");
            }
        }

        private void btn_searchPart_Click(object sender, EventArgs e)
        {
            string input = searchInputParts.Text;

            if(Inventory.AllParts != null)
            {
                foreach (DataGridViewRow row in dgParts.Rows)
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
            } else
            {
                MessageBox.Show("Invalid entry.");
            }
        }

        private void filterSearchParts(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (dgProducts.CurrentRow != null)
            {
                this.currentProduct = dgProducts.CurrentRow.DataBoundItem as Product;
            }
        }

        private void btn_searchProduct_Click(object sender, EventArgs e)
        {
            string input = searchInputProd.Text;

            if (Inventory.Products != null)
            {
                foreach (DataGridViewRow row in dgProducts.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(input) | row.Cells[1].Value.ToString().ToLower().Contains(input.ToLower()))
                    {
                        row.Selected = true;
                        int index = row.Index;
                        Product product = Inventory.lookupProduct(index);
                        this.currentProduct = product;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid entry.");
            }
        }

        private void filterSearchProd(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
