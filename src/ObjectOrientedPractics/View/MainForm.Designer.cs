namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControlMainForm = new TabControl();
            tabPageItems = new TabPage();
            itemsTab = new View.Tabs.ItemsTab();
            tabPageCustomers = new TabPage();
            customersTab = new View.Tabs.CustomersTab();
            tabPageCart = new TabPage();
            cartsTab = new View.Tabs.CartsTab();
            tabPageOrders = new TabPage();
            ordersTab = new View.Tabs.OrdersTab();
            tabControlMainForm.SuspendLayout();
            tabPageItems.SuspendLayout();
            tabPageCustomers.SuspendLayout();
            tabPageCart.SuspendLayout();
            tabPageOrders.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMainForm
            // 
            tabControlMainForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlMainForm.Controls.Add(tabPageItems);
            tabControlMainForm.Controls.Add(tabPageCustomers);
            tabControlMainForm.Controls.Add(tabPageCart);
            tabControlMainForm.Controls.Add(tabPageOrders);
            tabControlMainForm.Location = new Point(0, 0);
            tabControlMainForm.Name = "tabControlMainForm";
            tabControlMainForm.SelectedIndex = 0;
            tabControlMainForm.Size = new Size(1026, 653);
            tabControlMainForm.TabIndex = 0;
            tabControlMainForm.SelectedIndexChanged += tabControlMainForm_SelectedIndexChanged;
            // 
            // tabPageItems
            // 
            tabPageItems.Controls.Add(itemsTab);
            tabPageItems.Location = new Point(4, 24);
            tabPageItems.Name = "tabPageItems";
            tabPageItems.Padding = new Padding(3);
            tabPageItems.Size = new Size(1018, 625);
            tabPageItems.TabIndex = 0;
            tabPageItems.Text = "Items";
            tabPageItems.UseVisualStyleBackColor = true;
            // 
            // itemsTab
            // 
            itemsTab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            itemsTab.Location = new Point(3, 3);
            itemsTab.Name = "itemsTab";
            itemsTab.Size = new Size(1012, 619);
            itemsTab.TabIndex = 0;
            // 
            // tabPageCustomers
            // 
            tabPageCustomers.Controls.Add(customersTab);
            tabPageCustomers.Location = new Point(4, 24);
            tabPageCustomers.Name = "tabPageCustomers";
            tabPageCustomers.Size = new Size(1018, 625);
            tabPageCustomers.TabIndex = 1;
            tabPageCustomers.Text = "Customers";
            tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // customersTab
            // 
            customersTab.Dock = DockStyle.Fill;
            customersTab.Location = new Point(0, 0);
            customersTab.Name = "customersTab";
            customersTab.Size = new Size(1018, 625);
            customersTab.TabIndex = 0;
            // 
            // tabPageCart
            // 
            tabPageCart.Controls.Add(cartsTab);
            tabPageCart.Location = new Point(4, 24);
            tabPageCart.Name = "tabPageCart";
            tabPageCart.Size = new Size(1018, 625);
            tabPageCart.TabIndex = 2;
            tabPageCart.Text = "Carts";
            tabPageCart.UseVisualStyleBackColor = true;
            // 
            // cartsTab
            // 
            cartsTab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartsTab.Customers = null;
            cartsTab.Items = null;
            cartsTab.Location = new Point(8, 3);
            cartsTab.Name = "cartsTab";
            cartsTab.Size = new Size(1002, 614);
            cartsTab.TabIndex = 0;
            // 
            // tabPageOrders
            // 
            tabPageOrders.Controls.Add(ordersTab);
            tabPageOrders.Location = new Point(4, 24);
            tabPageOrders.Name = "tabPageOrders";
            tabPageOrders.Size = new Size(1018, 625);
            tabPageOrders.TabIndex = 3;
            tabPageOrders.Text = "Orders";
            tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // ordersTab
            // 
            ordersTab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ordersTab.Customers = null;
            ordersTab.Location = new Point(8, 3);
            ordersTab.Name = "ordersTab";
            ordersTab.Size = new Size(1003, 619);
            ordersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 653);
            Controls.Add(tabControlMainForm);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Object Oriented Practics";
            Load += Form1_Load;
            tabControlMainForm.ResumeLayout(false);
            tabPageItems.ResumeLayout(false);
            tabPageCustomers.ResumeLayout(false);
            tabPageCart.ResumeLayout(false);
            tabPageOrders.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMainForm;
        private TabPage tabPageItems;
        private View.Tabs.ItemsTab itemsTab;
        private TabPage tabPageCustomers;
        private View.Tabs.CustomersTab customersTab;
        private TabPage tabPageCart;
        private View.Tabs.CartsTab cartsTab;
        private TabPage tabPageOrders;
        private View.Tabs.OrdersTab ordersTab;
    }
}
