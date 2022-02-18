
namespace C968_PA_MPlatt
{
    partial class Form_AddPart
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_AddPart = new System.Windows.Forms.Label();
            this.radioButton_Inhouse = new System.Windows.Forms.RadioButton();
            this.radioButton_Outsourced = new System.Windows.Forms.RadioButton();
            this.textBox_PartID = new System.Windows.Forms.TextBox();
            this.label_PartID = new System.Windows.Forms.Label();
            this.label_PartName = new System.Windows.Forms.Label();
            this.textBox_PartName = new System.Windows.Forms.TextBox();
            this.label_Inventory = new System.Windows.Forms.Label();
            this.textBox_PartQty = new System.Windows.Forms.TextBox();
            this.label_PartPrice = new System.Windows.Forms.Label();
            this.textBox_PartPrice = new System.Windows.Forms.TextBox();
            this.label_PartMin = new System.Windows.Forms.Label();
            this.textBox_PartMin = new System.Windows.Forms.TextBox();
            this.label_MachineID_CoName = new System.Windows.Forms.Label();
            this.textBox_PartMachID = new System.Windows.Forms.TextBox();
            this.label_PartMax = new System.Windows.Forms.Label();
            this.textBox_PartMax = new System.Windows.Forms.TextBox();
            this.btn_addPartSave = new System.Windows.Forms.Button();
            this.btn_addPartCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label_AddPart
            // 
            this.label_AddPart.AutoSize = true;
            this.label_AddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddPart.Location = new System.Drawing.Point(12, 9);
            this.label_AddPart.Name = "label_AddPart";
            this.label_AddPart.Size = new System.Drawing.Size(82, 24);
            this.label_AddPart.TabIndex = 1;
            this.label_AddPart.Text = "Add Part";
            // 
            // radioButton_Inhouse
            // 
            this.radioButton_Inhouse.AutoSize = true;
            this.radioButton_Inhouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton_Inhouse.Location = new System.Drawing.Point(120, 55);
            this.radioButton_Inhouse.Name = "radioButton_Inhouse";
            this.radioButton_Inhouse.Size = new System.Drawing.Size(93, 24);
            this.radioButton_Inhouse.TabIndex = 2;
            this.radioButton_Inhouse.TabStop = true;
            this.radioButton_Inhouse.Text = "In-House";
            this.radioButton_Inhouse.UseVisualStyleBackColor = true;
            // 
            // radioButton_Outsourced
            // 
            this.radioButton_Outsourced.AutoSize = true;
            this.radioButton_Outsourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton_Outsourced.Location = new System.Drawing.Point(306, 55);
            this.radioButton_Outsourced.Name = "radioButton_Outsourced";
            this.radioButton_Outsourced.Size = new System.Drawing.Size(110, 24);
            this.radioButton_Outsourced.TabIndex = 2;
            this.radioButton_Outsourced.TabStop = true;
            this.radioButton_Outsourced.Text = "Outsourced";
            this.radioButton_Outsourced.UseVisualStyleBackColor = true;
            // 
            // textBox_PartID
            // 
            this.textBox_PartID.Location = new System.Drawing.Point(234, 113);
            this.textBox_PartID.MaxLength = 3;
            this.textBox_PartID.Name = "textBox_PartID";
            this.textBox_PartID.Size = new System.Drawing.Size(159, 20);
            this.textBox_PartID.TabIndex = 3;
            this.textBox_PartID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox_PartID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPartID_KeyPress);
            // 
            // label_PartID
            // 
            this.label_PartID.AutoSize = true;
            this.label_PartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PartID.Location = new System.Drawing.Point(109, 117);
            this.label_PartID.Name = "label_PartID";
            this.label_PartID.Size = new System.Drawing.Size(59, 20);
            this.label_PartID.TabIndex = 1;
            this.label_PartID.Text = "Part ID";
            this.label_PartID.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_PartName
            // 
            this.label_PartName.AutoSize = true;
            this.label_PartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PartName.Location = new System.Drawing.Point(109, 164);
            this.label_PartName.Name = "label_PartName";
            this.label_PartName.Size = new System.Drawing.Size(51, 20);
            this.label_PartName.TabIndex = 1;
            this.label_PartName.Text = "Name";
            // 
            // textBox_PartName
            // 
            this.textBox_PartName.Location = new System.Drawing.Point(234, 160);
            this.textBox_PartName.MaxLength = 20;
            this.textBox_PartName.Name = "textBox_PartName";
            this.textBox_PartName.Size = new System.Drawing.Size(159, 20);
            this.textBox_PartName.TabIndex = 3;
            this.textBox_PartName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox_PartName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPartName_KeyPress);
            // 
            // label_Inventory
            // 
            this.label_Inventory.AutoSize = true;
            this.label_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Inventory.Location = new System.Drawing.Point(109, 215);
            this.label_Inventory.Name = "label_Inventory";
            this.label_Inventory.Size = new System.Drawing.Size(74, 20);
            this.label_Inventory.TabIndex = 1;
            this.label_Inventory.Text = "Inventory";
            // 
            // textBox_PartQty
            // 
            this.textBox_PartQty.Location = new System.Drawing.Point(234, 211);
            this.textBox_PartQty.MaxLength = 10;
            this.textBox_PartQty.Name = "textBox_PartQty";
            this.textBox_PartQty.Size = new System.Drawing.Size(159, 20);
            this.textBox_PartQty.TabIndex = 3;
            this.textBox_PartQty.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox_PartQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPartQty_KeyPress);
            // 
            // label_PartPrice
            // 
            this.label_PartPrice.AutoSize = true;
            this.label_PartPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PartPrice.Location = new System.Drawing.Point(109, 268);
            this.label_PartPrice.Name = "label_PartPrice";
            this.label_PartPrice.Size = new System.Drawing.Size(44, 20);
            this.label_PartPrice.TabIndex = 1;
            this.label_PartPrice.Text = "Price";
            // 
            // textBox_PartPrice
            // 
            this.textBox_PartPrice.Location = new System.Drawing.Point(234, 264);
            this.textBox_PartPrice.MaxLength = 10;
            this.textBox_PartPrice.Name = "textBox_PartPrice";
            this.textBox_PartPrice.Size = new System.Drawing.Size(159, 20);
            this.textBox_PartPrice.TabIndex = 3;
            this.textBox_PartPrice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox_PartPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPartPrice_KeyPress);
            // 
            // label_PartMin
            // 
            this.label_PartMin.AutoSize = true;
            this.label_PartMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PartMin.Location = new System.Drawing.Point(109, 322);
            this.label_PartMin.Name = "label_PartMin";
            this.label_PartMin.Size = new System.Drawing.Size(34, 20);
            this.label_PartMin.TabIndex = 1;
            this.label_PartMin.Text = "Min";
            // 
            // textBox_PartMin
            // 
            this.textBox_PartMin.Location = new System.Drawing.Point(234, 318);
            this.textBox_PartMin.MaxLength = 10;
            this.textBox_PartMin.Name = "textBox_PartMin";
            this.textBox_PartMin.Size = new System.Drawing.Size(65, 20);
            this.textBox_PartMin.TabIndex = 3;
            this.textBox_PartMin.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox_PartMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPartMin_KeyPress);
            // 
            // label_MachineID_CoName
            // 
            this.label_MachineID_CoName.AutoSize = true;
            this.label_MachineID_CoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_MachineID_CoName.Location = new System.Drawing.Point(109, 385);
            this.label_MachineID_CoName.Name = "label_MachineID_CoName";
            this.label_MachineID_CoName.Size = new System.Drawing.Size(90, 20);
            this.label_MachineID_CoName.TabIndex = 1;
            this.label_MachineID_CoName.Text = "Machine ID";
            // 
            // textBox_PartMachID
            // 
            this.textBox_PartMachID.Location = new System.Drawing.Point(234, 381);
            this.textBox_PartMachID.MaxLength = 10;
            this.textBox_PartMachID.Name = "textBox_PartMachID";
            this.textBox_PartMachID.Size = new System.Drawing.Size(159, 20);
            this.textBox_PartMachID.TabIndex = 3;
            this.textBox_PartMachID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_PartMax
            // 
            this.label_PartMax.AutoSize = true;
            this.label_PartMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PartMax.Location = new System.Drawing.Point(331, 321);
            this.label_PartMax.Name = "label_PartMax";
            this.label_PartMax.Size = new System.Drawing.Size(38, 20);
            this.label_PartMax.TabIndex = 1;
            this.label_PartMax.Text = "Max";
            // 
            // textBox_PartMax
            // 
            this.textBox_PartMax.Location = new System.Drawing.Point(382, 318);
            this.textBox_PartMax.MaxLength = 10;
            this.textBox_PartMax.Name = "textBox_PartMax";
            this.textBox_PartMax.Size = new System.Drawing.Size(65, 20);
            this.textBox_PartMax.TabIndex = 3;
            this.textBox_PartMax.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox_PartMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPartMax_KeyPress);
            // 
            // btn_addPartSave
            // 
            this.btn_addPartSave.Location = new System.Drawing.Point(335, 447);
            this.btn_addPartSave.Name = "btn_addPartSave";
            this.btn_addPartSave.Size = new System.Drawing.Size(75, 39);
            this.btn_addPartSave.TabIndex = 4;
            this.btn_addPartSave.Text = "Save";
            this.btn_addPartSave.UseVisualStyleBackColor = true;
            this.btn_addPartSave.Click += new System.EventHandler(this.savePart);
            // 
            // btn_addPartCancel
            // 
            this.btn_addPartCancel.Location = new System.Drawing.Point(426, 447);
            this.btn_addPartCancel.Name = "btn_addPartCancel";
            this.btn_addPartCancel.Size = new System.Drawing.Size(75, 39);
            this.btn_addPartCancel.TabIndex = 4;
            this.btn_addPartCancel.Text = "Cancel";
            this.btn_addPartCancel.UseVisualStyleBackColor = true;
            // 
            // Form_AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.btn_addPartCancel);
            this.Controls.Add(this.btn_addPartSave);
            this.Controls.Add(this.textBox_PartMachID);
            this.Controls.Add(this.textBox_PartMax);
            this.Controls.Add(this.textBox_PartMin);
            this.Controls.Add(this.textBox_PartPrice);
            this.Controls.Add(this.label_MachineID_CoName);
            this.Controls.Add(this.textBox_PartQty);
            this.Controls.Add(this.label_PartMax);
            this.Controls.Add(this.label_PartMin);
            this.Controls.Add(this.textBox_PartName);
            this.Controls.Add(this.label_PartPrice);
            this.Controls.Add(this.textBox_PartID);
            this.Controls.Add(this.label_Inventory);
            this.Controls.Add(this.radioButton_Outsourced);
            this.Controls.Add(this.label_PartName);
            this.Controls.Add(this.radioButton_Inhouse);
            this.Controls.Add(this.label_PartID);
            this.Controls.Add(this.label_AddPart);
            this.Controls.Add(this.textBox1);
            this.Name = "Form_AddPart";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_AddPart;
        private System.Windows.Forms.RadioButton radioButton_Inhouse;
        private System.Windows.Forms.RadioButton radioButton_Outsourced;
        private System.Windows.Forms.TextBox textBox_PartID;
        private System.Windows.Forms.Label label_PartID;
        private System.Windows.Forms.Label label_PartName;
        private System.Windows.Forms.TextBox textBox_PartName;
        private System.Windows.Forms.Label label_Inventory;
        private System.Windows.Forms.TextBox textBox_PartQty;
        private System.Windows.Forms.Label label_PartPrice;
        private System.Windows.Forms.TextBox textBox_PartPrice;
        private System.Windows.Forms.Label label_PartMin;
        private System.Windows.Forms.TextBox textBox_PartMin;
        private System.Windows.Forms.Label label_MachineID_CoName;
        private System.Windows.Forms.TextBox textBox_PartMachID;
        private System.Windows.Forms.Label label_PartMax;
        private System.Windows.Forms.TextBox textBox_PartMax;
        private System.Windows.Forms.Button btn_addPartSave;
        private System.Windows.Forms.Button btn_addPartCancel;
    }
}