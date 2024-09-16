namespace solution
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.selectedProductgroupBox = new System.Windows.Forms.GroupBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.nameProductLabel = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.editProductButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.selectedProductgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Location = new System.Drawing.Point(12, 12);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(264, 381);
            this.listBoxProducts.TabIndex = 0;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // selectedProductgroupBox
            // 
            this.selectedProductgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedProductgroupBox.Controls.Add(this.numericUpDownQuantity);
            this.selectedProductgroupBox.Controls.Add(this.quantityLabel);
            this.selectedProductgroupBox.Controls.Add(this.comboBoxCategory);
            this.selectedProductgroupBox.Controls.Add(this.productCategoryLabel);
            this.selectedProductgroupBox.Controls.Add(this.textBoxManufacturer);
            this.selectedProductgroupBox.Controls.Add(this.manufacturerLabel);
            this.selectedProductgroupBox.Controls.Add(this.nameProductLabel);
            this.selectedProductgroupBox.Controls.Add(this.textBoxName);
            this.selectedProductgroupBox.Location = new System.Drawing.Point(282, 12);
            this.selectedProductgroupBox.Name = "selectedProductgroupBox";
            this.selectedProductgroupBox.Size = new System.Drawing.Size(506, 125);
            this.selectedProductgroupBox.TabIndex = 1;
            this.selectedProductgroupBox.TabStop = false;
            this.selectedProductgroupBox.Text = "Selected Product";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownQuantity.Location = new System.Drawing.Point(111, 99);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(164, 20);
            this.numericUpDownQuantity.TabIndex = 5;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(56, 101);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(49, 13);
            this.quantityLabel.TabIndex = 6;
            this.quantityLabel.Text = "Quantity:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(111, 71);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(164, 21);
            this.comboBoxCategory.TabIndex = 5;
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.Location = new System.Drawing.Point(15, 74);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(92, 13);
            this.productCategoryLabel.TabIndex = 4;
            this.productCategoryLabel.Text = "Product Category:";
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxManufacturer.Location = new System.Drawing.Point(111, 45);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(164, 20);
            this.textBoxManufacturer.TabIndex = 3;
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(32, 48);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(73, 13);
            this.manufacturerLabel.TabIndex = 2;
            this.manufacturerLabel.Text = "Manufacturer:";
            // 
            // nameProductLabel
            // 
            this.nameProductLabel.AutoSize = true;
            this.nameProductLabel.Location = new System.Drawing.Point(27, 22);
            this.nameProductLabel.Name = "nameProductLabel";
            this.nameProductLabel.Size = new System.Drawing.Size(78, 13);
            this.nameProductLabel.TabIndex = 1;
            this.nameProductLabel.Text = "Name Product:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(111, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(375, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(12, 399);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(78, 23);
            this.addProductButton.TabIndex = 2;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(96, 399);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(87, 23);
            this.deleteProductButton.TabIndex = 3;
            this.deleteProductButton.Text = "Delete Product";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // editProductButton
            // 
            this.editProductButton.Location = new System.Drawing.Point(193, 399);
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.Size = new System.Drawing.Size(83, 23);
            this.editProductButton.TabIndex = 4;
            this.editProductButton.Text = "Edit Product";
            this.editProductButton.UseVisualStyleBackColor = true;
            this.editProductButton.Click += new System.EventHandler(this.editProductButton_click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.editProductButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.selectedProductgroupBox);
            this.Controls.Add(this.listBoxProducts);
            this.Name = "Form1";
            this.Text = "List Products";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.selectedProductgroupBox.ResumeLayout(false);
            this.selectedProductgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.GroupBox selectedProductgroupBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label productCategoryLabel;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label nameProductLabel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button editProductButton;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

