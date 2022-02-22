
namespace C968_PA_MPlatt
{
    partial class formMain
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
            this.dgParts = new System.Windows.Forms.DataGridView();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.btn_addPart = new System.Windows.Forms.Button();
            this.btn_modifyPart = new System.Windows.Forms.Button();
            this.btn_deletePart = new System.Windows.Forms.Button();
            this.btn_addProd = new System.Windows.Forms.Button();
            this.btn_modifyProd = new System.Windows.Forms.Button();
            this.btn_deleteProd = new System.Windows.Forms.Button();
            this.btn_closeProg = new System.Windows.Forms.Button();
            this.btn_searchPart = new System.Windows.Forms.Button();
            this.label_Parts = new System.Windows.Forms.Label();
            this.labelProd = new System.Windows.Forms.Label();
            this.labelIMS = new System.Windows.Forms.Label();
            this.searchInputParts = new System.Windows.Forms.TextBox();
            this.btn_searchProd = new System.Windows.Forms.Button();
            this.searchInputProd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgParts
            // 
            this.dgParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParts.Location = new System.Drawing.Point(26, 100);
            this.dgParts.MultiSelect = false;
            this.dgParts.Name = "dgParts";
            this.dgParts.ReadOnly = true;
            this.dgParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgParts.Size = new System.Drawing.Size(550, 275);
            this.dgParts.TabIndex = 0;
            this.dgParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgParts_CellContentClick);
            this.dgParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // dgProducts
            // 
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Location = new System.Drawing.Point(608, 100);
            this.dgProducts.MultiSelect = false;
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.ReadOnly = true;
            this.dgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProducts.Size = new System.Drawing.Size(550, 275);
            this.dgProducts.TabIndex = 1;
            this.dgProducts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // btn_addPart
            // 
            this.btn_addPart.Location = new System.Drawing.Point(364, 397);
            this.btn_addPart.Name = "btn_addPart";
            this.btn_addPart.Size = new System.Drawing.Size(65, 34);
            this.btn_addPart.TabIndex = 2;
            this.btn_addPart.Text = "Add";
            this.btn_addPart.UseVisualStyleBackColor = true;
            this.btn_addPart.Click += new System.EventHandler(this.openAddPartForm_Click);
            // 
            // btn_modifyPart
            // 
            this.btn_modifyPart.Location = new System.Drawing.Point(435, 397);
            this.btn_modifyPart.Name = "btn_modifyPart";
            this.btn_modifyPart.Size = new System.Drawing.Size(65, 34);
            this.btn_modifyPart.TabIndex = 2;
            this.btn_modifyPart.Text = "Modify";
            this.btn_modifyPart.UseVisualStyleBackColor = true;
            this.btn_modifyPart.Click += new System.EventHandler(this.openModifyPartForm_Click);
            // 
            // btn_deletePart
            // 
            this.btn_deletePart.Location = new System.Drawing.Point(506, 397);
            this.btn_deletePart.Name = "btn_deletePart";
            this.btn_deletePart.Size = new System.Drawing.Size(65, 34);
            this.btn_deletePart.TabIndex = 2;
            this.btn_deletePart.Text = "Delete";
            this.btn_deletePart.UseVisualStyleBackColor = true;
            this.btn_deletePart.Click += new System.EventHandler(this.btn_deletePart_Click);
            // 
            // btn_addProd
            // 
            this.btn_addProd.Location = new System.Drawing.Point(952, 397);
            this.btn_addProd.Name = "btn_addProd";
            this.btn_addProd.Size = new System.Drawing.Size(65, 34);
            this.btn_addProd.TabIndex = 2;
            this.btn_addProd.Text = "Add";
            this.btn_addProd.UseVisualStyleBackColor = true;
            this.btn_addProd.Click += new System.EventHandler(this.btn_addProd_Click);
            // 
            // btn_modifyProd
            // 
            this.btn_modifyProd.Location = new System.Drawing.Point(1023, 397);
            this.btn_modifyProd.Name = "btn_modifyProd";
            this.btn_modifyProd.Size = new System.Drawing.Size(65, 34);
            this.btn_modifyProd.TabIndex = 2;
            this.btn_modifyProd.Text = "Modify";
            this.btn_modifyProd.UseVisualStyleBackColor = true;
            this.btn_modifyProd.Click += new System.EventHandler(this.btn_modifyProd_Click);
            // 
            // btn_deleteProd
            // 
            this.btn_deleteProd.Location = new System.Drawing.Point(1094, 397);
            this.btn_deleteProd.Name = "btn_deleteProd";
            this.btn_deleteProd.Size = new System.Drawing.Size(65, 34);
            this.btn_deleteProd.TabIndex = 2;
            this.btn_deleteProd.Text = "Delete";
            this.btn_deleteProd.UseVisualStyleBackColor = true;
            this.btn_deleteProd.Click += new System.EventHandler(this.btn_deleteProd_Click);
            // 
            // btn_closeProg
            // 
            this.btn_closeProg.Location = new System.Drawing.Point(1093, 514);
            this.btn_closeProg.Name = "btn_closeProg";
            this.btn_closeProg.Size = new System.Drawing.Size(65, 34);
            this.btn_closeProg.TabIndex = 2;
            this.btn_closeProg.Text = "Exit";
            this.btn_closeProg.UseVisualStyleBackColor = true;
            this.btn_closeProg.Click += new System.EventHandler(this.btn_closeProg_Click);
            // 
            // btn_searchPart
            // 
            this.btn_searchPart.Location = new System.Drawing.Point(230, 70);
            this.btn_searchPart.Name = "btn_searchPart";
            this.btn_searchPart.Size = new System.Drawing.Size(65, 24);
            this.btn_searchPart.TabIndex = 2;
            this.btn_searchPart.Text = "Search";
            this.btn_searchPart.UseVisualStyleBackColor = true;
            // 
            // label_Parts
            // 
            this.label_Parts.AutoSize = true;
            this.label_Parts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Parts.Location = new System.Drawing.Point(22, 70);
            this.label_Parts.Name = "label_Parts";
            this.label_Parts.Size = new System.Drawing.Size(51, 24);
            this.label_Parts.TabIndex = 3;
            this.label_Parts.Text = "Parts";
            this.label_Parts.Click += new System.EventHandler(this.openAddPartForm_Click);
            // 
            // labelProd
            // 
            this.labelProd.AutoSize = true;
            this.labelProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProd.Location = new System.Drawing.Point(604, 70);
            this.labelProd.Name = "labelProd";
            this.labelProd.Size = new System.Drawing.Size(84, 24);
            this.labelProd.TabIndex = 3;
            this.labelProd.Text = "Products";
            this.labelProd.Click += new System.EventHandler(this.openAddPartForm_Click);
            // 
            // labelIMS
            // 
            this.labelIMS.AutoSize = true;
            this.labelIMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIMS.Location = new System.Drawing.Point(12, 9);
            this.labelIMS.Name = "labelIMS";
            this.labelIMS.Size = new System.Drawing.Size(258, 24);
            this.labelIMS.TabIndex = 3;
            this.labelIMS.Text = "Inventory Mangement System";
            this.labelIMS.Click += new System.EventHandler(this.openAddPartForm_Click);
            // 
            // searchInputParts
            // 
            this.searchInputParts.Location = new System.Drawing.Point(320, 70);
            this.searchInputParts.Multiline = true;
            this.searchInputParts.Name = "searchInputParts";
            this.searchInputParts.Size = new System.Drawing.Size(156, 24);
            this.searchInputParts.TabIndex = 4;
            // 
            // btn_searchProd
            // 
            this.btn_searchProd.Location = new System.Drawing.Point(812, 70);
            this.btn_searchProd.Name = "btn_searchProd";
            this.btn_searchProd.Size = new System.Drawing.Size(65, 24);
            this.btn_searchProd.TabIndex = 2;
            this.btn_searchProd.Text = "Search";
            this.btn_searchProd.UseVisualStyleBackColor = true;
            // 
            // searchInputProd
            // 
            this.searchInputProd.Location = new System.Drawing.Point(902, 70);
            this.searchInputProd.Multiline = true;
            this.searchInputProd.Name = "searchInputProd";
            this.searchInputProd.Size = new System.Drawing.Size(156, 24);
            this.searchInputProd.TabIndex = 4;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1180, 571);
            this.Controls.Add(this.searchInputProd);
            this.Controls.Add(this.searchInputParts);
            this.Controls.Add(this.labelProd);
            this.Controls.Add(this.labelIMS);
            this.Controls.Add(this.label_Parts);
            this.Controls.Add(this.btn_closeProg);
            this.Controls.Add(this.btn_deleteProd);
            this.Controls.Add(this.btn_modifyProd);
            this.Controls.Add(this.btn_deletePart);
            this.Controls.Add(this.btn_addProd);
            this.Controls.Add(this.btn_searchProd);
            this.Controls.Add(this.btn_modifyPart);
            this.Controls.Add(this.btn_searchPart);
            this.Controls.Add(this.btn_addPart);
            this.Controls.Add(this.dgProducts);
            this.Controls.Add(this.dgParts);
            this.Name = "formMain";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dgParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_addPart;
        private System.Windows.Forms.Button btn_modifyPart;
        private System.Windows.Forms.Button btn_deletePart;
        private System.Windows.Forms.Button btn_addProd;
        private System.Windows.Forms.Button btn_modifyProd;
        private System.Windows.Forms.Button btn_deleteProd;
        private System.Windows.Forms.Button btn_closeProg;
        private System.Windows.Forms.Button btn_searchPart;
        private System.Windows.Forms.Label label_Parts;
        private System.Windows.Forms.Label labelProd;
        private System.Windows.Forms.Label labelIMS;
        private System.Windows.Forms.TextBox searchInputParts;
        private System.Windows.Forms.Button btn_searchProd;
        private System.Windows.Forms.TextBox searchInputProd;
        public System.Windows.Forms.DataGridView dgParts;
        public System.Windows.Forms.DataGridView dgProducts;
    }
}

