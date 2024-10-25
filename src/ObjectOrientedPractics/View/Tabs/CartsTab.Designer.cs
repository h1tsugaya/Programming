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
            labelAmount = new Label();
            labelAmountCount = new Label();
            buttonCreateOrder = new Button();
            buttonRemoveItem = new Button();
            buttonClearCart = new Button();
            listBoxCart = new ListBox();
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
            buttonAddToCart.Click += buttonAddToCart_Click;
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
            comboBoxCustomer.SelectedIndexChanged += comboBoxCustomer_SelectedIndexChanged;
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
            buttonCreateOrder.Click += buttonCreateOrder_Click;
            // 
            // buttonRemoveItem
            // 
            buttonRemoveItem.Location = new Point(594, 301);
            buttonRemoveItem.Name = "buttonRemoveItem";
            buttonRemoveItem.Size = new Size(95, 41);
            buttonRemoveItem.TabIndex = 10;
            buttonRemoveItem.Text = "Remove Item";
            buttonRemoveItem.UseVisualStyleBackColor = true;
            buttonRemoveItem.Click += buttonRemoveItem_Click;
            // 
            // buttonClearCart
            // 
            buttonClearCart.Location = new Point(695, 302);
            buttonClearCart.Name = "buttonClearCart";
            buttonClearCart.Size = new Size(95, 41);
            buttonClearCart.TabIndex = 11;
            buttonClearCart.Text = "Clear Cart";
            buttonClearCart.UseVisualStyleBackColor = true;
            buttonClearCart.Click += buttonClearCart_Click;
            // 
            // listBoxCart
            // 
            listBoxCart.FormattingEnabled = true;
            listBoxCart.ItemHeight = 15;
            listBoxCart.Location = new Point(331, 72);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.Size = new Size(459, 169);
            listBoxCart.TabIndex = 12;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBoxCart);
            Controls.Add(buttonClearCart);
            Controls.Add(buttonRemoveItem);
            Controls.Add(buttonCreateOrder);
            Controls.Add(labelAmountCount);
            Controls.Add(labelAmount);
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
        private Label labelAmount;
        private Label labelAmountCount;
        private Button buttonCreateOrder;
        private Button buttonRemoveItem;
        private Button buttonClearCart;
        private ListBox listBoxCart;
    }
}
