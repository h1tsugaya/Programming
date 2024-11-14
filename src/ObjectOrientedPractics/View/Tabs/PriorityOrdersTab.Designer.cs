namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            Model.Address address2 = new Model.Address();
            labelSelectedOrder = new Label();
            textBoxIdOrder = new TextBox();
            labelIdOrder = new Label();
            comboBoxStatus = new ComboBox();
            textBoxCreated = new TextBox();
            labelStatus = new Label();
            labelCreated = new Label();
            addressControl1 = new Controls.AddressControl();
            labelPriorityOptions = new Label();
            labelDeliveryTime = new Label();
            comboBoxDeliveryTime = new ComboBox();
            listBoxOrderItems = new ListBox();
            labelOrderItems = new Label();
            labelTotalAmountOrdersTab = new Label();
            labelAmountOrdersTab = new Label();
            buttonClearOrder = new Button();
            buttonAddItem = new Button();
            buttonRemoveItem = new Button();
            SuspendLayout();
            // 
            // labelSelectedOrder
            // 
            labelSelectedOrder.AutoSize = true;
            labelSelectedOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSelectedOrder.Location = new Point(3, 11);
            labelSelectedOrder.Name = "labelSelectedOrder";
            labelSelectedOrder.Size = new Size(98, 17);
            labelSelectedOrder.TabIndex = 3;
            labelSelectedOrder.Text = "Selected Order";
            // 
            // textBoxIdOrder
            // 
            textBoxIdOrder.Location = new Point(80, 42);
            textBoxIdOrder.Name = "textBoxIdOrder";
            textBoxIdOrder.Size = new Size(144, 23);
            textBoxIdOrder.TabIndex = 8;
            // 
            // labelIdOrder
            // 
            labelIdOrder.AutoSize = true;
            labelIdOrder.Location = new Point(3, 45);
            labelIdOrder.Name = "labelIdOrder";
            labelIdOrder.Size = new Size(21, 15);
            labelIdOrder.TabIndex = 7;
            labelIdOrder.Text = "ID:";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(80, 105);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(144, 23);
            comboBoxStatus.TabIndex = 12;
            // 
            // textBoxCreated
            // 
            textBoxCreated.Location = new Point(80, 71);
            textBoxCreated.Name = "textBoxCreated";
            textBoxCreated.Size = new Size(144, 23);
            textBoxCreated.TabIndex = 11;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(3, 108);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(42, 15);
            labelStatus.TabIndex = 10;
            labelStatus.Text = "Status:";
            // 
            // labelCreated
            // 
            labelCreated.AutoSize = true;
            labelCreated.Location = new Point(2, 74);
            labelCreated.Name = "labelCreated";
            labelCreated.Size = new Size(51, 15);
            labelCreated.TabIndex = 9;
            labelCreated.Text = "Created:";
            // 
            // addressControl1
            // 
            address2.Apartment = "";
            address2.Building = "";
            address2.City = "";
            address2.Country = "";
            address2.Index = 0;
            address2.Street = "";
            addressControl1.Address = address2;
            addressControl1.Location = new Point(2, 134);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(550, 158);
            addressControl1.TabIndex = 13;
            // 
            // labelPriorityOptions
            // 
            labelPriorityOptions.AutoSize = true;
            labelPriorityOptions.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPriorityOptions.Location = new Point(241, 11);
            labelPriorityOptions.Name = "labelPriorityOptions";
            labelPriorityOptions.Size = new Size(107, 17);
            labelPriorityOptions.TabIndex = 14;
            labelPriorityOptions.Text = "Priority Options";
            // 
            // labelDeliveryTime
            // 
            labelDeliveryTime.AutoSize = true;
            labelDeliveryTime.Location = new Point(241, 45);
            labelDeliveryTime.Name = "labelDeliveryTime";
            labelDeliveryTime.Size = new Size(81, 15);
            labelDeliveryTime.TabIndex = 15;
            labelDeliveryTime.Text = "Delivery Time:";
            // 
            // comboBoxDeliveryTime
            // 
            comboBoxDeliveryTime.FormattingEnabled = true;
            comboBoxDeliveryTime.Location = new Point(328, 42);
            comboBoxDeliveryTime.Name = "comboBoxDeliveryTime";
            comboBoxDeliveryTime.Size = new Size(173, 23);
            comboBoxDeliveryTime.TabIndex = 16;
            // 
            // listBoxOrderItems
            // 
            listBoxOrderItems.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBoxOrderItems.FormattingEnabled = true;
            listBoxOrderItems.ItemHeight = 15;
            listBoxOrderItems.Location = new Point(12, 325);
            listBoxOrderItems.Name = "listBoxOrderItems";
            listBoxOrderItems.Size = new Size(540, 154);
            listBoxOrderItems.TabIndex = 18;
            // 
            // labelOrderItems
            // 
            labelOrderItems.AutoSize = true;
            labelOrderItems.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelOrderItems.Location = new Point(11, 305);
            labelOrderItems.Name = "labelOrderItems";
            labelOrderItems.Size = new Size(81, 17);
            labelOrderItems.TabIndex = 17;
            labelOrderItems.Text = "Order Items";
            // 
            // labelTotalAmountOrdersTab
            // 
            labelTotalAmountOrdersTab.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTotalAmountOrdersTab.AutoSize = true;
            labelTotalAmountOrdersTab.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTotalAmountOrdersTab.Location = new Point(462, 511);
            labelTotalAmountOrdersTab.Name = "labelTotalAmountOrdersTab";
            labelTotalAmountOrdersTab.Size = new Size(90, 25);
            labelTotalAmountOrdersTab.TabIndex = 20;
            labelTotalAmountOrdersTab.Text = "4 999,90";
            // 
            // labelAmountOrdersTab
            // 
            labelAmountOrdersTab.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelAmountOrdersTab.AutoSize = true;
            labelAmountOrdersTab.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAmountOrdersTab.Location = new Point(490, 494);
            labelAmountOrdersTab.Name = "labelAmountOrdersTab";
            labelAmountOrdersTab.Size = new Size(62, 17);
            labelAmountOrdersTab.TabIndex = 19;
            labelAmountOrdersTab.Text = "Amount:";
            // 
            // buttonClearOrder
            // 
            buttonClearOrder.Location = new Point(462, 560);
            buttonClearOrder.Name = "buttonClearOrder";
            buttonClearOrder.Size = new Size(90, 45);
            buttonClearOrder.TabIndex = 21;
            buttonClearOrder.Text = "Clear Order";
            buttonClearOrder.UseVisualStyleBackColor = true;
            // 
            // buttonAddItem
            // 
            buttonAddItem.Location = new Point(12, 564);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(90, 45);
            buttonAddItem.TabIndex = 22;
            buttonAddItem.Text = "Add Item";
            buttonAddItem.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveItem
            // 
            buttonRemoveItem.Location = new Point(108, 564);
            buttonRemoveItem.Name = "buttonRemoveItem";
            buttonRemoveItem.Size = new Size(89, 45);
            buttonRemoveItem.TabIndex = 23;
            buttonRemoveItem.Text = "Remove Item";
            buttonRemoveItem.UseVisualStyleBackColor = true;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonRemoveItem);
            Controls.Add(buttonAddItem);
            Controls.Add(buttonClearOrder);
            Controls.Add(labelTotalAmountOrdersTab);
            Controls.Add(labelAmountOrdersTab);
            Controls.Add(listBoxOrderItems);
            Controls.Add(labelOrderItems);
            Controls.Add(comboBoxDeliveryTime);
            Controls.Add(labelDeliveryTime);
            Controls.Add(labelPriorityOptions);
            Controls.Add(addressControl1);
            Controls.Add(comboBoxStatus);
            Controls.Add(textBoxCreated);
            Controls.Add(labelStatus);
            Controls.Add(labelCreated);
            Controls.Add(textBoxIdOrder);
            Controls.Add(labelIdOrder);
            Controls.Add(labelSelectedOrder);
            Name = "PriorityOrdersTab";
            Size = new Size(563, 620);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSelectedOrder;
        private TextBox textBoxIdOrder;
        private Label labelIdOrder;
        private ComboBox comboBoxStatus;
        private TextBox textBoxCreated;
        private Label labelStatus;
        private Label labelCreated;
        private Controls.AddressControl addressControl1;
        private Label labelPriorityOptions;
        private Label labelDeliveryTime;
        private ComboBox comboBoxDeliveryTime;
        private ListBox listBoxOrderItems;
        private Label labelOrderItems;
        private Label labelTotalAmountOrdersTab;
        private Label labelAmountOrdersTab;
        private Button buttonClearOrder;
        private Button buttonAddItem;
        private Button buttonRemoveItem;
    }
}
