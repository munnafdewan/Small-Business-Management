namespace SmallBusinessManagement
{
    partial class SalesUi
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
            this.customerGroupBox = new System.Windows.Forms.GroupBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.loyalityTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.loyalityPoint = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.productGroupBox = new System.Windows.Forms.GroupBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.availabequantityLabel = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.mrpLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.availableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.mrpTextBox = new System.Windows.Forms.TextBox();
            this.totalMRPLabel = new System.Windows.Forms.Label();
            this.totalMRPTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.productDetailsLabel = new System.Windows.Forms.GroupBox();
            this.showDataGirdView = new System.Windows.Forms.DataGridView();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.payableAmountLabel = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.discountAmountLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.grantTotalLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.customerGroupBox.SuspendLayout();
            this.productGroupBox.SuspendLayout();
            this.productDetailsLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGirdView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.Controls.Add(this.customerComboBox);
            this.customerGroupBox.Controls.Add(this.dateTextBox);
            this.customerGroupBox.Controls.Add(this.loyalityPoint);
            this.customerGroupBox.Controls.Add(this.dateLabel);
            this.customerGroupBox.Controls.Add(this.loyalityTextBox);
            this.customerGroupBox.Controls.Add(this.customerLabel);
            this.customerGroupBox.Location = new System.Drawing.Point(12, 12);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Size = new System.Drawing.Size(327, 120);
            this.customerGroupBox.TabIndex = 0;
            this.customerGroupBox.TabStop = false;
            this.customerGroupBox.Text = "Customer";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(19, 25);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(51, 13);
            this.customerLabel.TabIndex = 1;
            this.customerLabel.Text = "Customer";
            // 
            // loyalityTextBox
            // 
            this.loyalityTextBox.Location = new System.Drawing.Point(74, 85);
            this.loyalityTextBox.Name = "loyalityTextBox";
            this.loyalityTextBox.Size = new System.Drawing.Size(138, 20);
            this.loyalityTextBox.TabIndex = 10;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(19, 52);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Date";
            this.dateLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // loyalityPoint
            // 
            this.loyalityPoint.AutoSize = true;
            this.loyalityPoint.Location = new System.Drawing.Point(19, 88);
            this.loyalityPoint.Name = "loyalityPoint";
            this.loyalityPoint.Size = new System.Drawing.Size(42, 13);
            this.loyalityPoint.TabIndex = 12;
            this.loyalityPoint.Text = "Loyality";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(74, 49);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(138, 20);
            this.dateTextBox.TabIndex = 13;
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(74, 17);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(121, 21);
            this.customerComboBox.TabIndex = 14;
            // 
            // productGroupBox
            // 
            this.productGroupBox.Controls.Add(this.addButton);
            this.productGroupBox.Controls.Add(this.totalMRPTextBox);
            this.productGroupBox.Controls.Add(this.totalMRPLabel);
            this.productGroupBox.Controls.Add(this.mrpTextBox);
            this.productGroupBox.Controls.Add(this.quantityTextBox);
            this.productGroupBox.Controls.Add(this.availableQuantityTextBox);
            this.productGroupBox.Controls.Add(this.productComboBox);
            this.productGroupBox.Controls.Add(this.categoryComboBox);
            this.productGroupBox.Controls.Add(this.mrpLabel);
            this.productGroupBox.Controls.Add(this.Quantity);
            this.productGroupBox.Controls.Add(this.availabequantityLabel);
            this.productGroupBox.Controls.Add(this.productLabel);
            this.productGroupBox.Controls.Add(this.categoryLabel);
            this.productGroupBox.Location = new System.Drawing.Point(12, 152);
            this.productGroupBox.Name = "productGroupBox";
            this.productGroupBox.Size = new System.Drawing.Size(327, 274);
            this.productGroupBox.TabIndex = 1;
            this.productGroupBox.TabStop = false;
            this.productGroupBox.Text = "Product";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(19, 31);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 13;
            this.categoryLabel.Text = "Category";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(19, 63);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(44, 13);
            this.productLabel.TabIndex = 14;
            this.productLabel.Text = "Product";
            // 
            // availabequantityLabel
            // 
            this.availabequantityLabel.AutoSize = true;
            this.availabequantityLabel.Location = new System.Drawing.Point(19, 94);
            this.availabequantityLabel.Name = "availabequantityLabel";
            this.availabequantityLabel.Size = new System.Drawing.Size(92, 13);
            this.availabequantityLabel.TabIndex = 15;
            this.availabequantityLabel.Text = "Available Quantity";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(19, 127);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(46, 13);
            this.Quantity.TabIndex = 16;
            this.Quantity.Text = "Quantity";
            // 
            // mrpLabel
            // 
            this.mrpLabel.AutoSize = true;
            this.mrpLabel.Location = new System.Drawing.Point(26, 150);
            this.mrpLabel.Name = "mrpLabel";
            this.mrpLabel.Size = new System.Drawing.Size(51, 13);
            this.mrpLabel.TabIndex = 17;
            this.mrpLabel.Text = "MRP(TK)";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(117, 23);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 18;
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(117, 60);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(121, 21);
            this.productComboBox.TabIndex = 19;
            // 
            // availableQuantityTextBox
            // 
            this.availableQuantityTextBox.Location = new System.Drawing.Point(117, 91);
            this.availableQuantityTextBox.Name = "availableQuantityTextBox";
            this.availableQuantityTextBox.Size = new System.Drawing.Size(138, 20);
            this.availableQuantityTextBox.TabIndex = 20;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(117, 120);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(138, 20);
            this.quantityTextBox.TabIndex = 21;
            // 
            // mrpTextBox
            // 
            this.mrpTextBox.Location = new System.Drawing.Point(117, 150);
            this.mrpTextBox.Name = "mrpTextBox";
            this.mrpTextBox.Size = new System.Drawing.Size(138, 20);
            this.mrpTextBox.TabIndex = 22;
            // 
            // totalMRPLabel
            // 
            this.totalMRPLabel.AutoSize = true;
            this.totalMRPLabel.Location = new System.Drawing.Point(19, 191);
            this.totalMRPLabel.Name = "totalMRPLabel";
            this.totalMRPLabel.Size = new System.Drawing.Size(78, 13);
            this.totalMRPLabel.TabIndex = 23;
            this.totalMRPLabel.Text = "Total MRP(TK)";
            // 
            // totalMRPTextBox
            // 
            this.totalMRPTextBox.Location = new System.Drawing.Point(117, 184);
            this.totalMRPTextBox.Name = "totalMRPTextBox";
            this.totalMRPTextBox.Size = new System.Drawing.Size(138, 20);
            this.totalMRPTextBox.TabIndex = 24;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(221, 233);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 25;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productDetailsLabel
            // 
            this.productDetailsLabel.Controls.Add(this.submitButton);
            this.productDetailsLabel.Controls.Add(this.textBox7);
            this.productDetailsLabel.Controls.Add(this.payableAmountLabel);
            this.productDetailsLabel.Controls.Add(this.textBox8);
            this.productDetailsLabel.Controls.Add(this.textBox9);
            this.productDetailsLabel.Controls.Add(this.textBox10);
            this.productDetailsLabel.Controls.Add(this.discountAmountLabel);
            this.productDetailsLabel.Controls.Add(this.discountLabel);
            this.productDetailsLabel.Controls.Add(this.grantTotalLabel);
            this.productDetailsLabel.Controls.Add(this.showDataGirdView);
            this.productDetailsLabel.Location = new System.Drawing.Point(373, 12);
            this.productDetailsLabel.Name = "productDetailsLabel";
            this.productDetailsLabel.Size = new System.Drawing.Size(423, 378);
            this.productDetailsLabel.TabIndex = 2;
            this.productDetailsLabel.TabStop = false;
            this.productDetailsLabel.Text = "Product Details";
            // 
            // showDataGirdView
            // 
            this.showDataGirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGirdView.Location = new System.Drawing.Point(19, 19);
            this.showDataGirdView.Name = "showDataGirdView";
            this.showDataGirdView.Size = new System.Drawing.Size(398, 138);
            this.showDataGirdView.TabIndex = 0;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(159, 264);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(138, 20);
            this.textBox7.TabIndex = 32;
            // 
            // payableAmountLabel
            // 
            this.payableAmountLabel.AutoSize = true;
            this.payableAmountLabel.Location = new System.Drawing.Point(45, 267);
            this.payableAmountLabel.Name = "payableAmountLabel";
            this.payableAmountLabel.Size = new System.Drawing.Size(104, 13);
            this.payableAmountLabel.TabIndex = 31;
            this.payableAmountLabel.Text = "Payable Amount(TK)";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(159, 235);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(138, 20);
            this.textBox8.TabIndex = 30;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(159, 205);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(138, 20);
            this.textBox9.TabIndex = 29;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(159, 171);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(138, 20);
            this.textBox10.TabIndex = 28;
            // 
            // discountAmountLabel
            // 
            this.discountAmountLabel.AutoSize = true;
            this.discountAmountLabel.Location = new System.Drawing.Point(45, 238);
            this.discountAmountLabel.Name = "discountAmountLabel";
            this.discountAmountLabel.Size = new System.Drawing.Size(108, 13);
            this.discountAmountLabel.TabIndex = 27;
            this.discountAmountLabel.Text = "Discount Amount(TK)";
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(45, 208);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(63, 13);
            this.discountLabel.TabIndex = 26;
            this.discountLabel.Text = "Discount(%)";
            // 
            // grantTotalLabel
            // 
            this.grantTotalLabel.AutoSize = true;
            this.grantTotalLabel.Location = new System.Drawing.Point(45, 176);
            this.grantTotalLabel.Name = "grantTotalLabel";
            this.grantTotalLabel.Size = new System.Drawing.Size(80, 13);
            this.grantTotalLabel.TabIndex = 25;
            this.grantTotalLabel.Text = "Grant Total(TK)";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(264, 341);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 33;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // SalesUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productDetailsLabel);
            this.Controls.Add(this.productGroupBox);
            this.Controls.Add(this.customerGroupBox);
            this.Name = "SalesUi";
            this.Text = "Sales";
            this.customerGroupBox.ResumeLayout(false);
            this.customerGroupBox.PerformLayout();
            this.productGroupBox.ResumeLayout(false);
            this.productGroupBox.PerformLayout();
            this.productDetailsLabel.ResumeLayout(false);
            this.productDetailsLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGirdView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox customerGroupBox;
        private System.Windows.Forms.Label loyalityPoint;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox loyalityTextBox;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.GroupBox productGroupBox;
        private System.Windows.Forms.TextBox mrpTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox availableQuantityTextBox;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label mrpLabel;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label availabequantityLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox totalMRPTextBox;
        private System.Windows.Forms.Label totalMRPLabel;
        private System.Windows.Forms.GroupBox productDetailsLabel;
        private System.Windows.Forms.DataGridView showDataGirdView;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label payableAmountLabel;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label discountAmountLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label grantTotalLabel;
    }
}