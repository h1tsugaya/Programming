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
            labelDiscounts = new Label();
            checkedListBoxDiscount = new CheckedListBox();
            labelDiscountAmount = new Label();
            labelDiscountAmountCount = new Label();
            labelTotal = new Label();
            labelTotalCount = new Label();
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
            listBoxCartItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxCartItems.FormattingEnabled = true;
            listBoxCartItems.ItemHeight = 15;
            listBoxCartItems.Location = new Point(3, 20);
            listBoxCartItems.Name = "listBoxCartItems";
            listBoxCartItems.Size = new Size(309, 604);
            listBoxCartItems.TabIndex = 1;
            // 
            // buttonAddToCart
            // 
            buttonAddToCart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddToCart.Location = new Point(6, 643);
            buttonAddToCart.Name = "buttonAddToCart";
            buttonAddToCart.Size = new Size(104, 39);
            buttonAddToCart.TabIndex = 2;
            buttonAddToCart.Text = "Add To Cart";
            buttonAddToCart.UseVisualStyleBackColor = true;
            buttonAddToCart.Click += buttonAddToCart_Click;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCustomer.Location = new Point(321, 20);
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
            comboBoxCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(401, 17);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(516, 23);
            comboBoxCustomer.TabIndex = 5;
            comboBoxCustomer.SelectedIndexChanged += comboBoxCustomer_SelectedIndexChanged;
            // 
            // labelAmount
            // 
            labelAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAmount.Location = new Point(820, 270);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(62, 17);
            labelAmount.TabIndex = 7;
            labelAmount.Text = "Amount:";
            // 
            // labelAmountCount
            // 
            labelAmountCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelAmountCount.AutoSize = true;
            labelAmountCount.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAmountCount.Location = new Point(820, 287);
            labelAmountCount.Name = "labelAmountCount";
            labelAmountCount.Size = new Size(23, 25);
            labelAmountCount.TabIndex = 8;
            labelAmountCount.Text = "0";
            // 
            // buttonCreateOrder
            // 
            buttonCreateOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCreateOrder.Location = new Point(331, 324);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(99, 38);
            buttonCreateOrder.TabIndex = 9;
            buttonCreateOrder.Text = "Create Order";
            buttonCreateOrder.UseVisualStyleBackColor = true;
            buttonCreateOrder.Click += buttonCreateOrder_Click;
            // 
            // buttonRemoveItem
            // 
            buttonRemoveItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRemoveItem.Location = new Point(714, 324);
            buttonRemoveItem.Name = "buttonRemoveItem";
            buttonRemoveItem.Size = new Size(98, 38);
            buttonRemoveItem.TabIndex = 10;
            buttonRemoveItem.Text = "Remove Item";
            buttonRemoveItem.UseVisualStyleBackColor = true;
            buttonRemoveItem.Click += buttonRemoveItem_Click;
            // 
            // buttonClearCart
            // 
            buttonClearCart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClearCart.Location = new Point(818, 324);
            buttonClearCart.Name = "buttonClearCart";
            buttonClearCart.Size = new Size(98, 38);
            buttonClearCart.TabIndex = 11;
            buttonClearCart.Text = "Clear Cart";
            buttonClearCart.UseVisualStyleBackColor = true;
            buttonClearCart.Click += buttonClearCart_Click;
            // 
            // listBoxCart
            // 
            listBoxCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxCart.FormattingEnabled = true;
            listBoxCart.ItemHeight = 15;
            listBoxCart.Location = new Point(331, 72);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.Size = new Size(585, 184);
            listBoxCart.TabIndex = 12;
            // 
            // labelDiscounts
            // 
            labelDiscounts.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelDiscounts.AutoSize = true;
            labelDiscounts.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDiscounts.Location = new Point(331, 384);
            labelDiscounts.Name = "labelDiscounts";
            labelDiscounts.Size = new Size(73, 17);
            labelDiscounts.TabIndex = 13;
            labelDiscounts.Text = "Discounts:";
            // 
            // checkedListBoxDiscount
            // 
            checkedListBoxDiscount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkedListBoxDiscount.BackColor = SystemColors.ButtonHighlight;
            checkedListBoxDiscount.BorderStyle = BorderStyle.None;
            checkedListBoxDiscount.FormattingEnabled = true;
            checkedListBoxDiscount.Location = new Point(331, 404);
            checkedListBoxDiscount.Name = "checkedListBoxDiscount";
            checkedListBoxDiscount.Size = new Size(315, 162);
            checkedListBoxDiscount.TabIndex = 14;
            checkedListBoxDiscount.ItemCheck += checkedListBoxDiscount_ItemCheck;
            // 
            // labelDiscountAmount
            // 
            labelDiscountAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelDiscountAmount.AutoSize = true;
            labelDiscountAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDiscountAmount.Location = new Point(761, 404);
            labelDiscountAmount.Name = "labelDiscountAmount";
            labelDiscountAmount.Size = new Size(121, 17);
            labelDiscountAmount.TabIndex = 15;
            labelDiscountAmount.Text = "Discount Amount:";
            // 
            // labelDiscountAmountCount
            // 
            labelDiscountAmountCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelDiscountAmountCount.AutoSize = true;
            labelDiscountAmountCount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDiscountAmountCount.Location = new Point(824, 431);
            labelDiscountAmountCount.Name = "labelDiscountAmountCount";
            labelDiscountAmountCount.Size = new Size(23, 25);
            labelDiscountAmountCount.TabIndex = 16;
            labelDiscountAmountCount.Text = "0";
            // 
            // labelTotal
            // 
            labelTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTotal.Location = new Point(844, 609);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(47, 17);
            labelTotal.TabIndex = 17;
            labelTotal.Text = "TOTAL:";
            // 
            // labelTotalCount
            // 
            labelTotalCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTotalCount.AutoSize = true;
            labelTotalCount.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTotalCount.Location = new Point(845, 637);
            labelTotalCount.Name = "labelTotalCount";
            labelTotalCount.Size = new Size(23, 25);
            labelTotalCount.TabIndex = 18;
            labelTotalCount.Text = "0";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelTotalCount);
            Controls.Add(labelTotal);
            Controls.Add(labelDiscountAmountCount);
            Controls.Add(labelDiscountAmount);
            Controls.Add(checkedListBoxDiscount);
            Controls.Add(labelDiscounts);
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
            Size = new Size(927, 698);
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
        private Label labelDiscounts;
        private CheckedListBox checkedListBoxDiscount;
        private Label labelDiscountAmount;
        private Label labelDiscountAmountCount;
        private Label labelTotal;
        private Label labelTotalCount;
    }
}
