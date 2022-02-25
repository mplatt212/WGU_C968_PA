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
        int index;
       
        public formMain()
        {
            InitializeComponent();
            dgProducts.DataSource = Inventory.DefaultProducts();
            dgParts.DataSource = Inventory.DefaultParts();
            dgParts.AllowUserToAddRows = false;
            dgProducts.AllowUserToAddRows = false;
            dgParts.Columns[0].HeaderText = "Part ID";
            dgParts.Columns[3].HeaderText = "Inventory";
            dgProducts.Columns[0].HeaderText = "Part ID";
            dgProducts.Columns[3].HeaderText = "Inventory";
            dgParts.Columns[0].Width = 82;
            dgParts.Columns[3].Width = 75;
            dgParts.Columns[4].Width = 75;
            dgParts.Columns[5].Width = 75;
            dgProducts.Columns[0].Width = 82;
            dgProducts.Columns[3].Width = 75;
            dgProducts.Columns[4].Width = 75;
            dgProducts.Columns[5].Width = 75;
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
                MessageBox.Show("Please select a part to modify.");
                return;
            } else
            {
                //this.currentPart = dgParts.CurrentRow.DataBoundItem as Part;
                if (currentPart != null)
                {
                    //int index = dgParts.CurrentCell.RowIndex;
                    int index = dgParts.CurrentRow.Index;
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
            this.index = e.RowIndex;
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
                MessageBox.Show("Please select a part to delete.");
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
                MessageBox.Show("Please select a product to delete.");
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
                        this.index = row.Index;
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
            this.index = e.RowIndex;
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

        private void orderList(object sender, DataGridViewRowsAddedEventArgs e)
        {
  
        }
    }
}
