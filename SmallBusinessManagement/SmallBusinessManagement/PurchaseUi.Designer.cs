namespace SmallBusinessManagement
{
    partial class PurchaseUi
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.billLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.supplierGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.productGroupBox = new System.Windows.Forms.GroupBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.availableQuantityLabel = new System.Windows.Forms.Label();
            this.manufacturedDateLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.remarksLabel = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.avaiableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.manufacturedDateTextBox = new System.Windows.Forms.TextBox();
            this.expireDateTextBox = new System.Windows.Forms.TextBox();
            this.remarksRichTextBox = new System.Windows.Forms.RichTextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.unitpriceLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.previousUnitPriceLabel = new System.Windows.Forms.Label();
            this.previousMRPLabel = new System.Windows.Forms.Label();
            this.mrpLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.unitperpriceTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.previousunitpriceTextBox = new System.Windows.Forms.TextBox();
            this.previousMRPTextBox = new System.Windows.Forms.TextBox();
            this.mrpTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.showDataGirdView = new System.Windows.Forms.DataGridView();
            this.submitButton = new System.Windows.Forms.Button();
            this.supplierGroupBox.SuspendLayout();
            this.productGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGirdView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(19, 28);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date";
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Location = new System.Drawing.Point(19, 57);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(77, 13);
            this.billLabel.TabIndex = 1;
            this.billLabel.Text = "Bill/Invoice No";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(19, 92);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(45, 13);
            this.supplierLabel.TabIndex = 2;
            this.supplierLabel.Text = "Supplier";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 3;
            // 
            // supplierGroupBox
            // 
            this.supplierGroupBox.Controls.Add(this.comboBox1);
            this.supplierGroupBox.Controls.Add(this.textBox2);
            this.supplierGroupBox.Controls.Add(this.textBox1);
            this.supplierGroupBox.Controls.Add(this.supplierLabel);
            this.supplierGroupBox.Controls.Add(this.billLabel);
            this.supplierGroupBox.Controls.Add(this.dateLabel);
            this.supplierGroupBox.Location = new System.Drawing.Point(110, 12);
            this.supplierGroupBox.Name = "supplierGroupBox";
            this.supplierGroupBox.Size = new System.Drawing.Size(547, 127);
            this.supplierGroupBox.TabIndex = 0;
            this.supplierGroupBox.TabStop = false;
            this.supplierGroupBox.Text = "Supplier";
            this.supplierGroupBox.Enter += new System.EventHandler(this.supplierGroupBox_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 20);
            this.textBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // productGroupBox
            // 
            this.productGroupBox.Controls.Add(this.addButton);
            this.productGroupBox.Controls.Add(this.mrpTextBox);
            this.productGroupBox.Controls.Add(this.previousMRPTextBox);
            this.productGroupBox.Controls.Add(this.previousunitpriceTextBox);
            this.productGroupBox.Controls.Add(this.totalPriceTextBox);
            this.productGroupBox.Controls.Add(this.unitperpriceTextBox);
            this.productGroupBox.Controls.Add(this.quantityTextBox);
            this.productGroupBox.Controls.Add(this.mrpLabel);
            this.productGroupBox.Controls.Add(this.previousMRPLabel);
            this.productGroupBox.Controls.Add(this.previousUnitPriceLabel);
            this.productGroupBox.Controls.Add(this.totalPriceLabel);
            this.productGroupBox.Controls.Add(this.unitpriceLabel);
            this.productGroupBox.Controls.Add(this.quantityLabel);
            this.productGroupBox.Controls.Add(this.productComboBox);
            this.productGroupBox.Controls.Add(this.categoryComboBox);
            this.productGroupBox.Controls.Add(this.remarksRichTextBox);
            this.productGroupBox.Controls.Add(this.expireDateTextBox);
            this.productGroupBox.Controls.Add(this.manufacturedDateTextBox);
            this.productGroupBox.Controls.Add(this.avaiableQuantityTextBox);
            this.productGroupBox.Controls.Add(this.codeTextBox);
            this.productGroupBox.Controls.Add(this.remarksLabel);
            this.productGroupBox.Controls.Add(this.label6);
            this.productGroupBox.Controls.Add(this.manufacturedDateLabel);
            this.productGroupBox.Controls.Add(this.availableQuantityLabel);
            this.productGroupBox.Controls.Add(this.codeLabel);
            this.productGroupBox.Controls.Add(this.productLabel);
            this.productGroupBox.Controls.Add(this.categoryLabel);
            this.productGroupBox.Location = new System.Drawing.Point(27, 164);
            this.productGroupBox.Name = "productGroupBox";
            this.productGroupBox.Size = new System.Drawing.Size(738, 359);
            this.productGroupBox.TabIndex = 1;
            this.productGroupBox.TabStop = false;
            this.productGroupBox.Text = "Product";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(19, 33);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Category";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(19, 69);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(44, 13);
            this.productLabel.TabIndex = 1;
            this.productLabel.Text = "Product";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(19, 98);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(32, 13);
            this.codeLabel.TabIndex = 2;
            this.codeLabel.Text = "Code";
            // 
            // availableQuantityLabel
            // 
            this.availableQuantityLabel.AutoSize = true;
            this.availableQuantityLabel.Location = new System.Drawing.Point(19, 128);
            this.availableQuantityLabel.Name = "availableQuantityLabel";
            this.availableQuantityLabel.Size = new System.Drawing.Size(89, 13);
            this.availableQuantityLabel.TabIndex = 3;
            this.availableQuantityLabel.Text = "AvailableQuantity";
            // 
            // manufacturedDateLabel
            // 
            this.manufacturedDateLabel.AutoSize = true;
            this.manufacturedDateLabel.Location = new System.Drawing.Point(19, 162);
            this.manufacturedDateLabel.Name = "manufacturedDateLabel";
            this.manufacturedDateLabel.Size = new System.Drawing.Size(99, 13);
            this.manufacturedDateLabel.TabIndex = 4;
            this.manufacturedDateLabel.Text = "Manufactured Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Expire Date";
            // 
            // remarksLabel
            // 
            this.remarksLabel.AutoSize = true;
            this.remarksLabel.Location = new System.Drawing.Point(22, 233);
            this.remarksLabel.Name = "remarksLabel";
            this.remarksLabel.Size = new System.Drawing.Size(49, 13);
            this.remarksLabel.TabIndex = 6;
            this.remarksLabel.Text = "Remarks";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(125, 98);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(138, 20);
            this.codeTextBox.TabIndex = 9;
            // 
            // avaiableQuantityTextBox
            // 
            this.avaiableQuantityTextBox.Location = new System.Drawing.Point(125, 125);
            this.avaiableQuantityTextBox.Name = "avaiableQuantityTextBox";
            this.avaiableQuantityTextBox.Size = new System.Drawing.Size(138, 20);
            this.avaiableQuantityTextBox.TabIndex = 10;
            // 
            // manufacturedDateTextBox
            // 
            this.manufacturedDateTextBox.Location = new System.Drawing.Point(125, 155);
            this.manufacturedDateTextBox.Name = "manufacturedDateTextBox";
            this.manufacturedDateTextBox.Size = new System.Drawing.Size(138, 20);
            this.manufacturedDateTextBox.TabIndex = 11;
            // 
            // expireDateTextBox
            // 
            this.expireDateTextBox.Location = new System.Drawing.Point(125, 191);
            this.expireDateTextBox.Name = "expireDateTextBox";
            this.expireDateTextBox.Size = new System.Drawing.Size(138, 20);
            this.expireDateTextBox.TabIndex = 12;
            // 
            // remarksRichTextBox
            // 
            this.remarksRichTextBox.Location = new System.Drawing.Point(83, 230);
            this.remarksRichTextBox.Name = "remarksRichTextBox";
            this.remarksRichTextBox.Size = new System.Drawing.Size(618, 73);
            this.remarksRichTextBox.TabIndex = 13;
            this.remarksRichTextBox.Text = "";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(125, 33);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 14;
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(125, 69);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(121, 21);
            this.productComboBox.TabIndex = 15;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(337, 36);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 16;
            this.quantityLabel.Text = "Quantity";
            // 
            // unitpriceLabel
            // 
            this.unitpriceLabel.AutoSize = true;
            this.unitpriceLabel.Location = new System.Drawing.Point(337, 69);
            this.unitpriceLabel.Name = "unitpriceLabel";
            this.unitpriceLabel.Size = new System.Drawing.Size(92, 13);
            this.unitpriceLabel.TabIndex = 17;
            this.unitpriceLabel.Text = "Unit Per Price(TK)";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(337, 98);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(78, 13);
            this.totalPriceLabel.TabIndex = 18;
            this.totalPriceLabel.Text = "Total Price(TK)";
            // 
            // previousUnitPriceLabel
            // 
            this.previousUnitPriceLabel.AutoSize = true;
            this.previousUnitPriceLabel.Location = new System.Drawing.Point(337, 132);
            this.previousUnitPriceLabel.Name = "previousUnitPriceLabel";
            this.previousUnitPriceLabel.Size = new System.Drawing.Size(136, 13);
            this.previousUnitPriceLabel.TabIndex = 19;
            this.previousUnitPriceLabel.Text = "Previous Unit Per Price(TK)";
            // 
            // previousMRPLabel
            // 
            this.previousMRPLabel.AutoSize = true;
            this.previousMRPLabel.Location = new System.Drawing.Point(337, 162);
            this.previousMRPLabel.Name = "previousMRPLabel";
            this.previousMRPLabel.Size = new System.Drawing.Size(92, 13);
            this.previousMRPLabel.TabIndex = 20;
            this.previousMRPLabel.Text = "Previous MRP TK";
            // 
            // mrpLabel
            // 
            this.mrpLabel.AutoSize = true;
            this.mrpLabel.Location = new System.Drawing.Point(337, 191);
            this.mrpLabel.Name = "mrpLabel";
            this.mrpLabel.Size = new System.Drawing.Size(51, 13);
            this.mrpLabel.TabIndex = 21;
            this.mrpLabel.Text = "MRP(TK)";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(479, 36);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(179, 20);
            this.quantityTextBox.TabIndex = 22;
            // 
            // unitperpriceTextBox
            // 
            this.unitperpriceTextBox.Location = new System.Drawing.Point(479, 66);
            this.unitperpriceTextBox.Name = "unitperpriceTextBox";
            this.unitperpriceTextBox.Size = new System.Drawing.Size(179, 20);
            this.unitperpriceTextBox.TabIndex = 23;
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(479, 95);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(179, 20);
            this.totalPriceTextBox.TabIndex = 24;
            // 
            // previousunitpriceTextBox
            // 
            this.previousunitpriceTextBox.Location = new System.Drawing.Point(479, 128);
            this.previousunitpriceTextBox.Name = "previousunitpriceTextBox";
            this.previousunitpriceTextBox.Size = new System.Drawing.Size(179, 20);
            this.previousunitpriceTextBox.TabIndex = 25;
            // 
            // previousMRPTextBox
            // 
            this.previousMRPTextBox.Location = new System.Drawing.Point(479, 159);
            this.previousMRPTextBox.Name = "previousMRPTextBox";
            this.previousMRPTextBox.Size = new System.Drawing.Size(179, 20);
            this.previousMRPTextBox.TabIndex = 26;
            // 
            // mrpTextBox
            // 
            this.mrpTextBox.Location = new System.Drawing.Point(479, 188);
            this.mrpTextBox.Name = "mrpTextBox";
            this.mrpTextBox.Size = new System.Drawing.Size(179, 20);
            this.mrpTextBox.TabIndex = 27;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(603, 309);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 28;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // showDataGirdView
            // 
            this.showDataGirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGirdView.Location = new System.Drawing.Point(27, 552);
            this.showDataGirdView.Name = "showDataGirdView";
            this.showDataGirdView.Size = new System.Drawing.Size(738, 139);
            this.showDataGirdView.TabIndex = 2;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(653, 714);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // PurchaseUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.showDataGirdView);
            this.Controls.Add(this.productGroupBox);
            this.Controls.Add(this.supplierGroupBox);
            this.Name = "PurchaseUi";
            this.Text = "Purchase";
            this.supplierGroupBox.ResumeLayout(false);
            this.supplierGroupBox.PerformLayout();
            this.productGroupBox.ResumeLayout(false);
            this.productGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGirdView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox supplierGroupBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox productGroupBox;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.RichTextBox remarksRichTextBox;
        private System.Windows.Forms.TextBox expireDateTextBox;
        private System.Windows.Forms.TextBox manufacturedDateTextBox;
        private System.Windows.Forms.TextBox avaiableQuantityTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label remarksLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label manufacturedDateLabel;
        private System.Windows.Forms.Label availableQuantityLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox mrpTextBox;
        private System.Windows.Forms.TextBox previousMRPTextBox;
        private System.Windows.Forms.TextBox previousunitpriceTextBox;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.TextBox unitperpriceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label mrpLabel;
        private System.Windows.Forms.Label previousMRPLabel;
        private System.Windows.Forms.Label previousUnitPriceLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label unitpriceLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView showDataGirdView;
        private System.Windows.Forms.Button submitButton;
    }
}