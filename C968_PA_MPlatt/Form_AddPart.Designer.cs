
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_PartID = new System.Windows.Forms.Label();
            this.label_PartName = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label_Inventory = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label_PartPrice = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label_PartMin = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label_PartMax = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 158);
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
            this.radioButton_Inhouse.Location = new System.Drawing.Point(133, 53);
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
            this.radioButton_Outsourced.Location = new System.Drawing.Point(319, 53);
            this.radioButton_Outsourced.Name = "radioButton_Outsourced";
            this.radioButton_Outsourced.Size = new System.Drawing.Size(110, 24);
            this.radioButton_Outsourced.TabIndex = 2;
            this.radioButton_Outsourced.TabStop = true;
            this.radioButton_Outsourced.Text = "Outsourced";
            this.radioButton_Outsourced.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(247, 111);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 28);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_PartID
            // 
            this.label_PartID.AutoSize = true;
            this.label_PartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PartID.Location = new System.Drawing.Point(122, 119);
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
            this.label_PartName.Location = new System.Drawing.Point(122, 166);
            this.label_PartName.Name = "label_PartName";
            this.label_PartName.Size = new System.Drawing.Size(51, 20);
            this.label_PartName.TabIndex = 1;
            this.label_PartName.Text = "Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(247, 158);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 28);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_Inventory
            // 
            this.label_Inventory.AutoSize = true;
            this.label_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Inventory.Location = new System.Drawing.Point(122, 217);
            this.label_Inventory.Name = "label_Inventory";
            this.label_Inventory.Size = new System.Drawing.Size(74, 20);
            this.label_Inventory.TabIndex = 1;
            this.label_Inventory.Text = "Inventory";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(247, 209);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(159, 28);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_PartPrice
            // 
            this.label_PartPrice.AutoSize = true;
            this.label_PartPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PartPrice.Location = new System.Drawing.Point(122, 270);
            this.label_PartPrice.Name = "label_PartPrice";
            this.label_PartPrice.Size = new System.Drawing.Size(44, 20);
            this.label_PartPrice.TabIndex = 1;
            this.label_PartPrice.Text = "Price";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(247, 262);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(159, 28);
            this.textBox5.TabIndex = 3;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_PartMin
            // 
            this.label_PartMin.AutoSize = true;
            this.label_PartMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PartMin.Location = new System.Drawing.Point(122, 324);
            this.label_PartMin.Name = "label_PartMin";
            this.label_PartMin.Size = new System.Drawing.Size(34, 20);
            this.label_PartMin.TabIndex = 1;
            this.label_PartMin.Text = "Min";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(247, 316);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(65, 28);
            this.textBox6.TabIndex = 3;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(122, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Add Part";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(247, 379);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(159, 28);
            this.textBox7.TabIndex = 3;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_PartMax
            // 
            this.label_PartMax.AutoSize = true;
            this.label_PartMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PartMax.Location = new System.Drawing.Point(344, 324);
            this.label_PartMax.Name = "label_PartMax";
            this.label_PartMax.Size = new System.Drawing.Size(38, 20);
            this.label_PartMax.TabIndex = 1;
            this.label_PartMax.Text = "Max";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(395, 316);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(65, 28);
            this.textBox8.TabIndex = 3;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form_AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 461);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_PartID;
        private System.Windows.Forms.Label label_PartName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label_Inventory;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label_PartPrice;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label_PartMin;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label_PartMax;
        private System.Windows.Forms.TextBox textBox8;
    }
}