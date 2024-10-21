namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            labelCartTabItems = new Label();
            listBoxCartItems = new ListBox();
            buttonAddToCart = new Button();
            labelCustomer = new Label();
            labelCart = new Label();
            comboBoxCustomer = new ComboBox();
            textBox1 = new TextBox();
            labelAmount = new Label();
            labelAmountCount = new Label();
            buttonCreateOrder = new Button();
            buttonRemoveItem = new Button();
            buttonClearCart = new Button();
            SuspendLayout();
            // 
            // labelCartTabItems
            // 
            labelCartTabItems.AutoSize = true;
            labelCartTabItems.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCartTabItems.Location = new Point(3, 0);
            labelCartTabItems.Name = "labelCartTabItems";
            labelCartTabItems.Size = new Size(42, 17);
            labelCartTabItems.TabIndex = 0;
            labelCartTabItems.Text = "Items";
            // 
            // listBoxCartItems
            // 
            listBoxCartItems.FormattingEnabled = true;
            listBoxCartItems.ItemHeight = 15;
            listBoxCartItems.Location = new Point(3, 20);
            listBoxCartItems.Name = "listBoxCartItems";
            listBoxCartItems.Size = new Size(312, 604);
            listBoxCartItems.TabIndex = 1;
            // 
            // buttonAddToCart
            // 
            buttonAddToCart.Location = new Point(3, 630);
            buttonAddToCart.Name = "buttonAddToCart";
            buttonAddToCart.Size = new Size(101, 39);
            buttonAddToCart.TabIndex = 2;
            buttonAddToCart.Text = "Add To Cart";
            buttonAddToCart.UseVisualStyleBackColor = true;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCustomer.Location = new Point(331, 20);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(64, 15);
            labelCustomer.TabIndex = 3;
            labelCustomer.Text = "Customer:";
            // 
            // labelCart
            // 
            labelCart.AutoSize = true;
            labelCart.Location = new Point(331, 54);
            labelCart.Name = "labelCart";
            labelCart.Size = new Size(32, 15);
            labelCart.TabIndex = 4;
            labelCart.Text = "Cart:";
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(401, 17);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(390, 23);
            comboBoxCustomer.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(331, 72);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(460, 170);
            textBox1.TabIndex = 6;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAmount.Location = new Point(729, 254);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(62, 17);
            labelAmount.TabIndex = 7;
            labelAmount.Text = "Amount:";
            // 
            // labelAmountCount
            // 
            labelAmountCount.AutoSize = true;
            labelAmountCount.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAmountCount.Location = new Point(729, 271);
            labelAmountCount.Name = "labelAmountCount";
            labelAmountCount.Size = new Size(23, 25);
            labelAmountCount.TabIndex = 8;
            labelAmountCount.Text = "0";
            // 
            // buttonCreateOrder
            // 
            buttonCreateOrder.Location = new Point(331, 302);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(95, 38);
            buttonCreateOrder.TabIndex = 9;
            buttonCreateOrder.Text = "Create Order";
            buttonCreateOrder.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveItem
            // 
            buttonRemoveItem.Location = new Point(594, 301);
            buttonRemoveItem.Name = "buttonRemoveItem";
            buttonRemoveItem.Size = new Size(95, 41);
            buttonRemoveItem.TabIndex = 10;
            buttonRemoveItem.Text = "Remove Item";
            buttonRemoveItem.UseVisualStyleBackColor = true;
            // 
            // buttonClearCart
            // 
            buttonClearCart.Location = new Point(695, 302);
            buttonClearCart.Name = "buttonClearCart";
            buttonClearCart.Size = new Size(95, 41);
            buttonClearCart.TabIndex = 11;
            buttonClearCart.Text = "Clear Cart";
            buttonClearCart.UseVisualStyleBackColor = true;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonClearCart);
            Controls.Add(buttonRemoveItem);
            Controls.Add(buttonCreateOrder);
            Controls.Add(labelAmountCount);
            Controls.Add(labelAmount);
            Controls.Add(textBox1);
            Controls.Add(comboBoxCustomer);
            Controls.Add(labelCart);
            Controls.Add(labelCustomer);
            Controls.Add(buttonAddToCart);
            Controls.Add(listBoxCartItems);
            Controls.Add(labelCartTabItems);
            Name = "CartsTab";
            Size = new Size(801, 676);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCartTabItems;
        private ListBox listBoxCartItems;
        private Button buttonAddToCart;
        private Label labelCustomer;
        private Label labelCart;
        private ComboBox comboBoxCustomer;
        private TextBox textBox1;
        private Label labelAmount;
        private Label labelAmountCount;
        private Button buttonCreateOrder;
        private Button buttonRemoveItem;
        private Button buttonClearCart;
    }
}
