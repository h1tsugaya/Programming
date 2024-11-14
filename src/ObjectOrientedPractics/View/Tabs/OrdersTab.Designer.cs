namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            Model.Address address1 = new Model.Address();
            labelOrders = new Label();
            dataGridViewOrders = new DataGridView();
            labelSelectedOrder = new Label();
            labelIdOrder = new Label();
            labelCreated = new Label();
            labelStatus = new Label();
            textBoxIdOrder = new TextBox();
            textBoxCreated = new TextBox();
            comboBoxStatus = new ComboBox();
            addressControlOrdersTab = new Controls.AddressControl();
            labelOrderItems = new Label();
            listBoxOrderItems = new ListBox();
            labelAmountOrdersTab = new Label();
            labelTotalAmountOrdersTab = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // labelOrders
            // 
            labelOrders.AutoSize = true;
            labelOrders.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelOrders.Location = new Point(3, 9);
            labelOrders.Name = "labelOrders";
            labelOrders.Size = new Size(49, 17);
            labelOrders.TabIndex = 0;
            labelOrders.Text = "Orders";
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AllowUserToAddRows = false;
            dataGridViewOrders.AllowUserToResizeRows = false;
            dataGridViewOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(3, 29);
            dataGridViewOrders.MultiSelect = false;
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.Size = new Size(335, 587);
            dataGridViewOrders.TabIndex = 1;
            dataGridViewOrders.SelectionChanged += dataGridViewOrders_SelectionChanged;
            // 
            // labelSelectedOrder
            // 
            labelSelectedOrder.AutoSize = true;
            labelSelectedOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSelectedOrder.Location = new Point(343, 9);
            labelSelectedOrder.Name = "labelSelectedOrder";
            labelSelectedOrder.Size = new Size(98, 17);
            labelSelectedOrder.TabIndex = 2;
            labelSelectedOrder.Text = "Selected Order";
            // 
            // labelIdOrder
            // 
            labelIdOrder.AutoSize = true;
            labelIdOrder.Location = new Point(344, 44);
            labelIdOrder.Name = "labelIdOrder";
            labelIdOrder.Size = new Size(21, 15);
            labelIdOrder.TabIndex = 3;
            labelIdOrder.Text = "ID:";
            // 
            // labelCreated
            // 
            labelCreated.AutoSize = true;
            labelCreated.Location = new Point(343, 74);
            labelCreated.Name = "labelCreated";
            labelCreated.Size = new Size(51, 15);
            labelCreated.TabIndex = 4;
            labelCreated.Text = "Created:";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(344, 108);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(42, 15);
            labelStatus.TabIndex = 5;
            labelStatus.Text = "Status:";
            // 
            // textBoxIdOrder
            // 
            textBoxIdOrder.Location = new Point(421, 41);
            textBoxIdOrder.Name = "textBoxIdOrder";
            textBoxIdOrder.Size = new Size(144, 23);
            textBoxIdOrder.TabIndex = 6;
            // 
            // textBoxCreated
            // 
            textBoxCreated.Location = new Point(421, 71);
            textBoxCreated.Name = "textBoxCreated";
            textBoxCreated.Size = new Size(144, 23);
            textBoxCreated.TabIndex = 7;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(421, 105);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(144, 23);
            comboBoxStatus.TabIndex = 8;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // addressControlOrdersTab
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 0;
            address1.Street = "";
            addressControlOrdersTab.Address = address1;
            addressControlOrdersTab.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressControlOrdersTab.Location = new Point(343, 134);
            addressControlOrdersTab.Name = "addressControlOrdersTab";
            addressControlOrdersTab.Size = new Size(649, 167);
            addressControlOrdersTab.TabIndex = 9;
            // 
            // labelOrderItems
            // 
            labelOrderItems.AutoSize = true;
            labelOrderItems.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelOrderItems.Location = new Point(343, 319);
            labelOrderItems.Name = "labelOrderItems";
            labelOrderItems.Size = new Size(81, 17);
            labelOrderItems.TabIndex = 10;
            labelOrderItems.Text = "Order Items";
            // 
            // listBoxOrderItems
            // 
            listBoxOrderItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxOrderItems.FormattingEnabled = true;
            listBoxOrderItems.ItemHeight = 15;
            listBoxOrderItems.Location = new Point(344, 339);
            listBoxOrderItems.Name = "listBoxOrderItems";
            listBoxOrderItems.Size = new Size(648, 154);
            listBoxOrderItems.TabIndex = 11;
            // 
            // labelAmountOrdersTab
            // 
            labelAmountOrdersTab.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelAmountOrdersTab.AutoSize = true;
            labelAmountOrdersTab.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAmountOrdersTab.Location = new Point(930, 506);
            labelAmountOrdersTab.Name = "labelAmountOrdersTab";
            labelAmountOrdersTab.Size = new Size(62, 17);
            labelAmountOrdersTab.TabIndex = 12;
            labelAmountOrdersTab.Text = "Amount:";
            // 
            // labelTotalAmountOrdersTab
            // 
            labelTotalAmountOrdersTab.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTotalAmountOrdersTab.AutoSize = true;
            labelTotalAmountOrdersTab.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTotalAmountOrdersTab.Location = new Point(902, 532);
            labelTotalAmountOrdersTab.Name = "labelTotalAmountOrdersTab";
            labelTotalAmountOrdersTab.Size = new Size(90, 25);
            labelTotalAmountOrdersTab.TabIndex = 13;
            labelTotalAmountOrdersTab.Text = "4 999,90";
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelTotalAmountOrdersTab);
            Controls.Add(labelAmountOrdersTab);
            Controls.Add(listBoxOrderItems);
            Controls.Add(labelOrderItems);
            Controls.Add(addressControlOrdersTab);
            Controls.Add(comboBoxStatus);
            Controls.Add(textBoxCreated);
            Controls.Add(textBoxIdOrder);
            Controls.Add(labelStatus);
            Controls.Add(labelCreated);
            Controls.Add(labelIdOrder);
            Controls.Add(labelSelectedOrder);
            Controls.Add(dataGridViewOrders);
            Controls.Add(labelOrders);
            Name = "OrdersTab";
            Size = new Size(1003, 619);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOrders;
        private DataGridView dataGridViewOrders;
        private Label labelSelectedOrder;
        private Label labelIdOrder;
        private Label labelCreated;
        private Label labelStatus;
        private TextBox textBoxIdOrder;
        private TextBox textBoxCreated;
        private ComboBox comboBoxStatus;
        private Controls.AddressControl addressControlOrdersTab;
        private Label labelOrderItems;
        private ListBox listBoxOrderItems;
        private Label labelAmountOrdersTab;
        private Label labelTotalAmountOrdersTab;
    }
}
