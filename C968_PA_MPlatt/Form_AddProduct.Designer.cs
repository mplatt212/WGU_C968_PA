
namespace C968_PA_MPlatt
{
    partial class Form_AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_ProdMax = new System.Windows.Forms.TextBox();
            this.textBox_ProdMin = new System.Windows.Forms.TextBox();
            this.textBox_ProdPrice = new System.Windows.Forms.TextBox();
            this.textBox_ProdQty = new System.Windows.Forms.TextBox();
            this.label_PartMax = new System.Windows.Forms.Label();
            this.label_PartMin = new System.Windows.Forms.Label();
            this.textBox_ProdName = new System.Windows.Forms.TextBox();
            this.label_PartPrice = new System.Windows.Forms.Label();
            this.textBox_ProdID = new System.Windows.Forms.TextBox();
            this.label_Inventory = new System.Windows.Forms.Label();
            this.label_PartName = new System.Windows.Forms.Label();
            this.label_PartID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_AddProduct = new System.Windows.Forms.Label();
            this.searchInputParts = new System.Windows.Forms.TextBox();
            this.btn_searchPart = new System.Windows.Forms.Button();
            this.dgAssocParts = new System.Windows.Forms.DataGridView();
            this.btn_prodCancel = new System.Windows.Forms.Button();
            this.btn_prodSave = new System.Windows.Forms.Button();
            this.btn_prodDelete = new System.Windows.Forms.Button();
            this.btn_prodAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgPartsForProds = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAssocParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartsForProds)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_ProdMax
            // 
            this.textBox_ProdMax.Location = new System.Drawing.Point(348, 406);
            this.textBox_ProdMax.MaxLength = 10;
            this.textBox_ProdMax.Name = "textBox_ProdMax";
            this.textBox_ProdMax.Size = new System.Drawing.Size(65, 20);
            this.textBox_ProdMax.TabIndex = 11;
            this.textBox_ProdMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProdMax_KeyPress);
            // 
            // textBox_ProdMin
            // 
            this.textBox_ProdMin.Location = new System.Drawing.Point(200, 406);
            this.textBox_ProdMin.MaxLength = 10;
            this.textBox_ProdMin.Name = "textBox_ProdMin";
            this.textBox_ProdMin.Size = new System.Drawing.Size(65, 20);
            this.textBox_ProdMin.TabIndex = 12;
            this.textBox_ProdMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProdMin_KeyPress);
            // 
            // textBox_ProdPrice
            // 
            this.textBox_ProdPrice.Location = new System.Drawing.Point(200, 352);
            this.textBox_ProdPrice.MaxLength = 10;
            this.textBox_ProdPrice.Name = "textBox_ProdPrice";
            this.textBox_ProdPrice.Size = new System.Drawing.Size(159, 20);
            this.textBox_ProdPrice.TabIndex = 13;
            this.textBox_ProdPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProdPrice_KeyPress);
            // 
            // textBox_ProdQty
            // 
            this.textBox_ProdQty.Location = new System.Drawing.Point(200, 299);
            this.textBox_ProdQty.MaxLength = 10;
            this.textBox_ProdQty.Name = "textBox_ProdQty";
            this.textBox_ProdQty.Size = new System.Drawing.Size(159, 20);
            this.textBox_ProdQty.TabIndex = 14;
            this.textBox_ProdQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProdQty_KeyPress);
            // 
            // label_PartMax
            // 
            this.label_PartMax.AutoSize = true;
            this.label_PartMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PartMax.Location = new System.Drawing.Point(297, 409);
            this.label_PartMax.Name = "label_PartMax";
            this.label_PartMax.Size = new System.Drawing.Size(38, 20);
            this.label_PartMax.TabIndex = 5;
            this.label_PartMax.Text = "Max";
            // 
            // label_PartMin
            // 
            this.label_PartMin.AutoSize = true;
            this.label_PartMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PartMin.Location = new System.Drawing.Point(75, 410);
            this.label_PartMin.Name = "label_PartMin";
            this.label_PartMin.Size = new System.Drawing.Size(34, 20);
            this.label_PartMin.TabIndex = 6;
            this.label_PartMin.Text = "Min";
            // 
            // textBox_ProdName
            // 
            this.textBox_ProdName.Location = new System.Drawing.Point(200, 248);
            this.textBox_ProdName.MaxLength = 20;
            this.textBox_ProdName.Name = "textBox_ProdName";
            this.textBox_ProdName.Size = new System.Drawing.Size(159, 20);
            this.textBox_ProdName.TabIndex = 15;
            this.textBox_ProdName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProdName_KeyPress);
            // 
            // label_PartPrice
            // 
            this.label_PartPrice.AutoSize = true;
            this.label_PartPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PartPrice.Location = new System.Drawing.Point(75, 356);
            this.label_PartPrice.Name = "label_PartPrice";
            this.label_PartPrice.Size = new System.Drawing.Size(44, 20);
            this.label_PartPrice.TabIndex = 7;
            this.label_PartPrice.Text = "Price";
            // 
            // textBox_ProdID
            // 
            this.textBox_ProdID.Enabled = false;
            this.textBox_ProdID.Location = new System.Drawing.Point(200, 201);
            this.textBox_ProdID.MaxLength = 3;
            this.textBox_ProdID.Name = "textBox_ProdID";
            this.textBox_ProdID.Size = new System.Drawing.Size(159, 20);
            this.textBox_ProdID.TabIndex = 16;
            // 
            // label_Inventory
            // 
            this.label_Inventory.AutoSize = true;
            this.label_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Inventory.Location = new System.Drawing.Point(75, 303);
            this.label_Inventory.Name = "label_Inventory";
            this.label_Inventory.Size = new System.Drawing.Size(74, 20);
            this.label_Inventory.TabIndex = 8;
            this.label_Inventory.Text = "Inventory";
            // 
            // label_PartName
            // 
            this.label_PartName.AutoSize = true;
            this.label_PartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PartName.Location = new System.Drawing.Point(75, 252);
            this.label_PartName.Name = "label_PartName";
            this.label_PartName.Size = new System.Drawing.Size(51, 20);
            this.label_PartName.TabIndex = 9;
            this.label_PartName.Text = "Name";
            // 
            // label_PartID
            // 
            this.label_PartID.AutoSize = true;
            this.label_PartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PartID.Location = new System.Drawing.Point(75, 205);
            this.label_PartID.Name = "label_PartID";
            this.label_PartID.Size = new System.Drawing.Size(85, 20);
            this.label_PartID.TabIndex = 10;
            this.label_PartID.Text = "Product ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label_AddProduct
            // 
            this.label_AddProduct.AutoSize = true;
            this.label_AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_AddProduct.Location = new System.Drawing.Point(24, 26);
            this.label_AddProduct.Name = "label_AddProduct";
            this.label_AddProduct.Size = new System.Drawing.Size(115, 24);
            this.label_AddProduct.TabIndex = 10;
            this.label_AddProduct.Text = "Add Product";
            // 
            // searchInputParts
            // 
            this.searchInputParts.Location = new System.Drawing.Point(876, 84);
            this.searchInputParts.Multiline = true;
            this.searchInputParts.Name = "searchInputParts";
            this.searchInputParts.Size = new System.Drawing.Size(156, 24);
            this.searchInputParts.TabIndex = 18;
            this.searchInputParts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterSearchParts);
            // 
            // btn_searchPart
            // 
            this.btn_searchPart.Location = new System.Drawing.Point(786, 84);
            this.btn_searchPart.Name = "btn_searchPart";
            this.btn_searchPart.Size = new System.Drawing.Size(65, 24);
            this.btn_searchPart.TabIndex = 17;
            this.btn_searchPart.Text = "Search";
            this.btn_searchPart.UseVisualStyleBackColor = true;
            this.btn_searchPart.Click += new System.EventHandler(this.btn_searchPart_Click);
            // 
            // dgAssocParts
            // 
            this.dgAssocParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAssocParts.Location = new System.Drawing.Point(557, 374);
            this.dgAssocParts.MultiSelect = false;
            this.dgAssocParts.Name = "dgAssocParts";
            this.dgAssocParts.ReadOnly = true;
            this.dgAssocParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAssocParts.Size = new System.Drawing.Size(475, 176);
            this.dgAssocParts.TabIndex = 19;
            this.dgAssocParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // btn_prodCancel
            // 
            this.btn_prodCancel.Location = new System.Drawing.Point(951, 621);
            this.btn_prodCancel.Name = "btn_prodCancel";
            this.btn_prodCancel.Size = new System.Drawing.Size(75, 39);
            this.btn_prodCancel.TabIndex = 20;
            this.btn_prodCancel.Text = "Cancel";
            this.btn_prodCancel.UseVisualStyleBackColor = true;
            this.btn_prodCancel.Click += new System.EventHandler(this.btn_prodCancel_Click);
            // 
            // btn_prodSave
            // 
            this.btn_prodSave.Location = new System.Drawing.Point(860, 621);
            this.btn_prodSave.Name = "btn_prodSave";
            this.btn_prodSave.Size = new System.Drawing.Size(75, 39);
            this.btn_prodSave.TabIndex = 21;
            this.btn_prodSave.Text = "Save";
            this.btn_prodSave.UseVisualStyleBackColor = true;
            this.btn_prodSave.Click += new System.EventHandler(this.btn_prodSave_Click);
            // 
            // btn_prodDelete
            // 
            this.btn_prodDelete.Location = new System.Drawing.Point(951, 567);
            this.btn_prodDelete.Name = "btn_prodDelete";
            this.btn_prodDelete.Size = new System.Drawing.Size(75, 39);
            this.btn_prodDelete.TabIndex = 20;
            this.btn_prodDelete.Text = "Delete";
            this.btn_prodDelete.UseVisualStyleBackColor = true;
            this.btn_prodDelete.Click += new System.EventHandler(this.btn_prodDelete_Click);
            // 
            // btn_prodAdd
            // 
            this.btn_prodAdd.Location = new System.Drawing.Point(951, 314);
            this.btn_prodAdd.Name = "btn_prodAdd";
            this.btn_prodAdd.Size = new System.Drawing.Size(75, 39);
            this.btn_prodAdd.TabIndex = 20;
            this.btn_prodAdd.Text = "Add";
            this.btn_prodAdd.UseVisualStyleBackColor = true;
            this.btn_prodAdd.Click += new System.EventHandler(this.btn_prodAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(553, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "All Candidate Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(554, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Parts Associated with this Product";
            // 
            // dgPartsForProds
            // 
            this.dgPartsForProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPartsForProds.Location = new System.Drawing.Point(556, 124);
            this.dgPartsForProds.MultiSelect = false;
            this.dgPartsForProds.Name = "dgPartsForProds";
            this.dgPartsForProds.ReadOnly = true;
            this.dgPartsForProds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPartsForProds.Size = new System.Drawing.Size(470, 176);
            this.dgPartsForProds.TabIndex = 22;
            this.dgPartsForProds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgParts_CellContentClick);
            this.dgPartsForProds.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // Form_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 672);
            this.Controls.Add(this.dgPartsForProds);
            this.Controls.Add(this.btn_prodAdd);
            this.Controls.Add(this.btn_prodDelete);
            this.Controls.Add(this.btn_prodCancel);
            this.Controls.Add(this.btn_prodSave);
            this.Controls.Add(this.dgAssocParts);
            this.Controls.Add(this.searchInputParts);
            this.Controls.Add(this.btn_searchPart);
            this.Controls.Add(this.textBox_ProdMax);
            this.Controls.Add(this.textBox_ProdMin);
            this.Controls.Add(this.textBox_ProdPrice);
            this.Controls.Add(this.textBox_ProdQty);
            this.Controls.Add(this.label_PartMax);
            this.Controls.Add(this.label_PartMin);
            this.Controls.Add(this.textBox_ProdName);
            this.Controls.Add(this.label_PartPrice);
            this.Controls.Add(this.textBox_ProdID);
            this.Controls.Add(this.label_Inventory);
            this.Controls.Add(this.label_PartName);
            this.Controls.Add(this.label_AddProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_PartID);
            this.Controls.Add(this.textBox1);
            this.Name = "Form_AddProduct";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgAssocParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartsForProds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ProdMax;
        private System.Windows.Forms.TextBox textBox_ProdMin;
        private System.Windows.Forms.TextBox textBox_ProdPrice;
        private System.Windows.Forms.TextBox textBox_ProdQty;
        private System.Windows.Forms.Label label_PartMax;
        private System.Windows.Forms.Label label_PartMin;
        private System.Windows.Forms.TextBox textBox_ProdName;
        private System.Windows.Forms.Label label_PartPrice;
        private System.Windows.Forms.TextBox textBox_ProdID;
        private System.Windows.Forms.Label label_Inventory;
        private System.Windows.Forms.Label label_PartName;
        private System.Windows.Forms.Label label_PartID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_AddProduct;
        private System.Windows.Forms.TextBox searchInputParts;
        private System.Windows.Forms.Button btn_searchPart;
        private System.Windows.Forms.DataGridView dgAssocParts;
        private System.Windows.Forms.Button btn_prodCancel;
        private System.Windows.Forms.Button btn_prodSave;
        private System.Windows.Forms.Button btn_prodDelete;
        private System.Windows.Forms.Button btn_prodAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgPartsForProds;
    }
}