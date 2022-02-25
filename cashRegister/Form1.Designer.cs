namespace cashRegister
{
    partial class Form1
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.burgesInput = new System.Windows.Forms.TextBox();
            this.friesInput = new System.Windows.Forms.TextBox();
            this.drinksInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.burgersLabel = new System.Windows.Forms.Label();
            this.friesLabel = new System.Windows.Forms.Label();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.subInput = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.taxInput = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalInput = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.printButton = new System.Windows.Forms.Button();
            this.blackLine = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(88, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(202, 29);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Burger Town Pub";
            this.nameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(-6, -32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(899, 84);
            this.label2.TabIndex = 1;
            // 
            // burgesInput
            // 
            this.burgesInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgesInput.Location = new System.Drawing.Point(326, 111);
            this.burgesInput.Name = "burgesInput";
            this.burgesInput.Size = new System.Drawing.Size(100, 31);
            this.burgesInput.TabIndex = 2;
            this.burgesInput.Text = "0";
            // 
            // friesInput
            // 
            this.friesInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesInput.Location = new System.Drawing.Point(326, 165);
            this.friesInput.Name = "friesInput";
            this.friesInput.Size = new System.Drawing.Size(100, 31);
            this.friesInput.TabIndex = 3;
            this.friesInput.Text = "0";
            // 
            // drinksInput
            // 
            this.drinksInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksInput.Location = new System.Drawing.Point(326, 216);
            this.drinksInput.Name = "drinksInput";
            this.drinksInput.Size = new System.Drawing.Size(100, 31);
            this.drinksInput.TabIndex = 4;
            this.drinksInput.Text = "0";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(68, 262);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(222, 51);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // receiptOutput
            // 
            this.receiptOutput.BackColor = System.Drawing.SystemColors.Menu;
            this.receiptOutput.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutput.Location = new System.Drawing.Point(490, 52);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(336, 350);
            this.receiptOutput.TabIndex = 6;
            // 
            // burgersLabel
            // 
            this.burgersLabel.AutoSize = true;
            this.burgersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgersLabel.Location = new System.Drawing.Point(63, 111);
            this.burgersLabel.Name = "burgersLabel";
            this.burgersLabel.Size = new System.Drawing.Size(192, 25);
            this.burgersLabel.TabIndex = 7;
            this.burgersLabel.Text = "Number of Burgers";
            // 
            // friesLabel
            // 
            this.friesLabel.AutoSize = true;
            this.friesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesLabel.Location = new System.Drawing.Point(63, 165);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(165, 25);
            this.friesLabel.TabIndex = 8;
            this.friesLabel.Text = "Number of Fries";
            // 
            // drinksLabel
            // 
            this.drinksLabel.AutoSize = true;
            this.drinksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksLabel.Location = new System.Drawing.Point(63, 216);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(178, 25);
            this.drinksLabel.TabIndex = 9;
            this.drinksLabel.Text = "Number of Drinks";
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLabel.Location = new System.Drawing.Point(63, 334);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(104, 25);
            this.subLabel.TabIndex = 10;
            this.subLabel.Text = "Sub Total";
            // 
            // subInput
            // 
            this.subInput.BackColor = System.Drawing.SystemColors.Control;
            this.subInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subInput.Location = new System.Drawing.Point(320, 334);
            this.subInput.Name = "subInput";
            this.subInput.Size = new System.Drawing.Size(104, 25);
            this.subInput.TabIndex = 11;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(63, 379);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(48, 25);
            this.taxLabel.TabIndex = 12;
            this.taxLabel.Text = "Tax";
            // 
            // taxInput
            // 
            this.taxInput.BackColor = System.Drawing.SystemColors.Control;
            this.taxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxInput.Location = new System.Drawing.Point(320, 379);
            this.taxInput.Name = "taxInput";
            this.taxInput.Size = new System.Drawing.Size(104, 25);
            this.taxInput.TabIndex = 13;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(63, 426);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(60, 25);
            this.totalLabel.TabIndex = 14;
            this.totalLabel.Text = "Total";
            // 
            // totalInput
            // 
            this.totalInput.BackColor = System.Drawing.SystemColors.Control;
            this.totalInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalInput.Location = new System.Drawing.Point(321, 426);
            this.totalInput.Name = "totalInput";
            this.totalInput.Size = new System.Drawing.Size(104, 25);
            this.totalInput.TabIndex = 15;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.Location = new System.Drawing.Point(176, 516);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(100, 31);
            this.tenderedInput.TabIndex = 16;
            this.tenderedInput.Text = "0";
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(553, 413);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(222, 51);
            this.printButton.TabIndex = 17;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // blackLine
            // 
            this.blackLine.BackColor = System.Drawing.Color.Black;
            this.blackLine.Location = new System.Drawing.Point(68, 468);
            this.blackLine.Name = "blackLine";
            this.blackLine.Size = new System.Drawing.Size(356, 15);
            this.blackLine.TabIndex = 18;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(66, 519);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(104, 25);
            this.tenderedLabel.TabIndex = 19;
            this.tenderedLabel.Text = "Tendered";
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(71, 55);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(153, 40);
            this.newButton.TabIndex = 20;
            this.newButton.Text = "New Order";
            this.newButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "=";
            // 
            // changeLabel
            // 
            this.changeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(322, 516);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(104, 25);
            this.changeLabel.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(443, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "Calculate Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 556);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.blackLine);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.totalInput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxInput);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subInput);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.drinksLabel);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.burgersLabel);
            this.Controls.Add(this.receiptOutput);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.drinksInput);
            this.Controls.Add(this.friesInput);
            this.Controls.Add(this.burgesInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Calculate Change ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox burgesInput;
        private System.Windows.Forms.TextBox friesInput;
        private System.Windows.Forms.TextBox drinksInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label receiptOutput;
        private System.Windows.Forms.Label burgersLabel;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label subInput;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label taxInput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalInput;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label blackLine;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button button1;
    }
}

