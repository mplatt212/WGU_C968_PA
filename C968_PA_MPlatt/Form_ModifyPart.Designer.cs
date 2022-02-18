
namespace C968_PA_MPlatt
{
    partial class Form_ModifyPart
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
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label_MachineID_CoName = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label_PartMax = new System.Windows.Forms.Label();
            this.label_PartMin = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label_PartPrice = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_Inventory = new System.Windows.Forms.Label();
            this.radioButton_Outsourced = new System.Windows.Forms.RadioButton();
            this.label_PartName = new System.Windows.Forms.Label();
            this.radioButton_Inhouse = new System.Windows.Forms.RadioButton();
            this.label_PartID = new System.Windows.Forms.Label();
            this.label_ModifyPart = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_modifyPartCancel = new System.Windows.Forms.Button();
            this.btn_modifyPartSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(218, 378);
            this.textBox7.MaxLength = 10;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(159, 20);
            this.textBox7.TabIndex = 21;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(366, 315);
            this.textBox8.MaxLength = 10;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(65, 20);
            this.textBox8.TabIndex = 19;
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPartMax_KeyPress);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(218, 315);
            this.textBox6.MaxLength = 10;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(65, 20);
            this.textBox6.TabIndex = 18;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPartMin_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(218, 261);
            this.textBox5.MaxLength = 10;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(159, 20);
            this.textBox5.TabIndex = 17;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPartPrice_KeyPress);
            // 
            // label_MachineID_CoName
            // 
            this.label_MachineID_CoName.AutoSize = true;
            this.label_MachineID_CoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_MachineID_CoName.Location = new System.Drawing.Point(93, 379);
            this.label_MachineID_CoName.Name = "label_MachineID_CoName";
            this.label_MachineID_CoName.Size = new System.Drawing.Size(90, 20);
            this.label_MachineID_CoName.TabIndex = 7;
            this.label_MachineID_CoName.Text = "Machine ID";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(218, 208);
            this.textBox4.MaxLength = 10;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(159, 20);
            this.textBox4.TabIndex = 16;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPartQty_KeyPress);
            // 
            // label_PartMax
            // 
            this.label_PartMax.AutoSize = true;
            this.label_PartMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PartMax.Location = new System.Drawing.Point(315, 316);
            this.label_PartMax.Name = "label_PartMax";
            this.label_PartMax.Size = new System.Drawing.Size(38, 20);
            this.label_PartMax.TabIndex = 8;
            this.label_PartMax.Text = "Max";
            // 
            // label_PartMin
            // 
            this.label_PartMin.AutoSize = true;
            this.label_PartMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PartMin.Location = new System.Drawing.Point(93, 316);
            this.label_PartMin.Name = "label_PartMin";
            this.label_PartMin.Size = new System.Drawing.Size(34, 20);
            this.label_PartMin.TabIndex = 9;
            this.label_PartMin.Text = "Min";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(218, 157);
            this.textBox3.MaxLength = 20;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPartName_KeyPress);
            // 
            // label_PartPrice
            // 
            this.label_PartPrice.AutoSize = true;
            this.label_PartPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PartPrice.Location = new System.Drawing.Point(93, 262);
            this.label_PartPrice.Name = "label_PartPrice";
            this.label_PartPrice.Size = new System.Drawing.Size(44, 20);
            this.label_PartPrice.TabIndex = 11;
            this.label_PartPrice.Text = "Price";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 110);
            this.textBox2.MaxLength = 3;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPartID_KeyPress);
            // 
            // label_Inventory
            // 
            this.label_Inventory.AutoSize = true;
            this.label_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Inventory.Location = new System.Drawing.Point(93, 209);
            this.label_Inventory.Name = "label_Inventory";
            this.label_Inventory.Size = new System.Drawing.Size(74, 20);
            this.label_Inventory.TabIndex = 12;
            this.label_Inventory.Text = "Inventory";
            // 
            // radioButton_Outsourced
            // 
            this.radioButton_Outsourced.AutoSize = true;
            this.radioButton_Outsourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton_Outsourced.Location = new System.Drawing.Point(290, 52);
            this.radioButton_Outsourced.Name = "radioButton_Outsourced";
            this.radioButton_Outsourced.Size = new System.Drawing.Size(110, 24);
            this.radioButton_Outsourced.TabIndex = 14;
            this.radioButton_Outsourced.TabStop = true;
            this.radioButton_Outsourced.Text = "Outsourced";
            this.radioButton_Outsourced.UseVisualStyleBackColor = true;
            // 
            // label_PartName
            // 
            this.label_PartName.AutoSize = true;
            this.label_PartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PartName.Location = new System.Drawing.Point(93, 158);
            this.label_PartName.Name = "label_PartName";
            this.label_PartName.Size = new System.Drawing.Size(51, 20);
            this.label_PartName.TabIndex = 6;
            this.label_PartName.Text = "Name";
            // 
            // radioButton_Inhouse
            // 
            this.radioButton_Inhouse.AutoSize = true;
            this.radioButton_Inhouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton_Inhouse.Location = new System.Drawing.Point(104, 52);
            this.radioButton_Inhouse.Name = "radioButton_Inhouse";
            this.radioButton_Inhouse.Size = new System.Drawing.Size(93, 24);
            this.radioButton_Inhouse.TabIndex = 13;
            this.radioButton_Inhouse.TabStop = true;
            this.radioButton_Inhouse.Text = "In-House";
            this.radioButton_Inhouse.UseVisualStyleBackColor = true;
            // 
            // label_PartID
            // 
            this.label_PartID.AutoSize = true;
            this.label_PartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PartID.Location = new System.Drawing.Point(93, 111);
            this.label_PartID.Name = "label_PartID";
            this.label_PartID.Size = new System.Drawing.Size(59, 20);
            this.label_PartID.TabIndex = 5;
            this.label_PartID.Text = "Part ID";
            // 
            // label_ModifyPart
            // 
            this.label_ModifyPart.AutoSize = true;
            this.label_ModifyPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ModifyPart.Location = new System.Drawing.Point(10, 10);
            this.label_ModifyPart.Name = "label_ModifyPart";
            this.label_ModifyPart.Size = new System.Drawing.Size(102, 24);
            this.label_ModifyPart.TabIndex = 10;
            this.label_ModifyPart.Text = "Modify Part";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btn_modifyPartCancel
            // 
            this.btn_modifyPartCancel.Location = new System.Drawing.Point(426, 449);
            this.btn_modifyPartCancel.Name = "btn_modifyPartCancel";
            this.btn_modifyPartCancel.Size = new System.Drawing.Size(75, 39);
            this.btn_modifyPartCancel.TabIndex = 22;
            this.btn_modifyPartCancel.Text = "Cancel";
            this.btn_modifyPartCancel.UseVisualStyleBackColor = true;
            // 
            // btn_modifyPartSave
            // 
            this.btn_modifyPartSave.Location = new System.Drawing.Point(335, 449);
            this.btn_modifyPartSave.Name = "btn_modifyPartSave";
            this.btn_modifyPartSave.Size = new System.Drawing.Size(75, 39);
            this.btn_modifyPartSave.TabIndex = 23;
            this.btn_modifyPartSave.Text = "Save";
            this.btn_modifyPartSave.UseVisualStyleBackColor = true;
            // 
            // Form_ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.btn_modifyPartCancel);
            this.Controls.Add(this.btn_modifyPartSave);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label_MachineID_CoName);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label_PartMax);
            this.Controls.Add(this.label_PartMin);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label_PartPrice);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_Inventory);
            this.Controls.Add(this.radioButton_Outsourced);
            this.Controls.Add(this.label_PartName);
            this.Controls.Add(this.radioButton_Inhouse);
            this.Controls.Add(this.label_PartID);
            this.Controls.Add(this.label_ModifyPart);
            this.Controls.Add(this.textBox1);
            this.Name = "Form_ModifyPart";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label_MachineID_CoName;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label_PartMax;
        private System.Windows.Forms.Label label_PartMin;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label_PartPrice;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_Inventory;
        private System.Windows.Forms.RadioButton radioButton_Outsourced;
        private System.Windows.Forms.Label label_PartName;
        private System.Windows.Forms.RadioButton radioButton_Inhouse;
        private System.Windows.Forms.Label label_PartID;
        private System.Windows.Forms.Label label_ModifyPart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_modifyPartCancel;
        private System.Windows.Forms.Button btn_modifyPartSave;
    }
}