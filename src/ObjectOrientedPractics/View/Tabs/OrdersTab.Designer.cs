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
            Model.Address address2 = new Model.Address();
            labelOrders = new Label();
            dataGridViewOrders = new DataGridView();
            labelSelectedOrder = new Label();
            labelIdOrder = new Label();
            labelCreated = new Label();
            labelStatus = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            addressControl1 = new Controls.AddressControl();
            labelOrderItems = new Label();
            listBox1 = new ListBox();
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
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(3, 29);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.Size = new Size(335, 587);
            dataGridViewOrders.TabIndex = 1;
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
            // textBox1
            // 
            textBox1.Location = new Point(421, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(421, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 23);
            textBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(421, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(144, 23);
            comboBox1.TabIndex = 8;
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
            addressControl1.Location = new Point(343, 134);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(551, 167);
            addressControl1.TabIndex = 9;
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
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(344, 339);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(648, 154);
            listBox1.TabIndex = 11;
            // 
            // labelAmountOrdersTab
            // 
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
            Controls.Add(listBox1);
            Controls.Add(labelOrderItems);
            Controls.Add(addressControl1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Controls.AddressControl addressControl1;
        private Label labelOrderItems;
        private ListBox listBox1;
        private Label labelAmountOrdersTab;
        private Label labelTotalAmountOrdersTab;
    }
}
