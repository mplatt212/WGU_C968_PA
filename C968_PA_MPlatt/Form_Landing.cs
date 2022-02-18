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
    public partial class formMain : System.Windows.Forms.Form
    {
        public formMain()
        {
            
            InitializeComponent();
            dgProducts.DataSource = Inventory.DefaultProducts();
            dgParts.DataSource = Inventory.DefaultParts();
        }
        
        private void openAddPartForm_Click(object sender, EventArgs e)
        {
            Form_AddPart partForm = new Form_AddPart();
            partForm.Show();
        }

        private void openModifyPartForm_Click(object sender, EventArgs e)
        {
            Form_ModifyPart partForm = new Form_ModifyPart();
            partForm.Show();
        }

        private void btn_closeProg_Click(object sender, EventArgs e)
        {

        }

        private void dgParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
