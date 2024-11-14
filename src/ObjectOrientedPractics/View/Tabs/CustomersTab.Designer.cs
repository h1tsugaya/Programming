namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            labelCustomers = new Label();
            groupBoxCustomers = new GroupBox();
            addressControl1 = new Controls.AddressControl();
            panel = new Panel();
            textBoxFullName = new TextBox();
            textBoxId2 = new TextBox();
            labelFullName = new Label();
            labelId2 = new Label();
            labelSelectedCustomers = new Label();
            buttonRemove2 = new Button();
            buttonAdd2 = new Button();
            CustomersListBox = new ListBox();
            groupBoxCustomers2 = new GroupBox();
            tableLayoutCustomersPanel = new TableLayoutPanel();
            groupBoxCustomers.SuspendLayout();
            groupBoxCustomers2.SuspendLayout();
            tableLayoutCustomersPanel.SuspendLayout();
            SuspendLayout();
            // 
            // labelCustomers
            // 
            labelCustomers.AutoSize = true;
            labelCustomers.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCustomers.Location = new Point(6, 19);
            labelCustomers.Name = "labelCustomers";
            labelCustomers.Size = new Size(74, 17);
            labelCustomers.TabIndex = 0;
            labelCustomers.Text = "Customers";
            // 
            // groupBoxCustomers
            // 
            groupBoxCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxCustomers.Controls.Add(addressControl1);
            groupBoxCustomers.Controls.Add(panel);
            groupBoxCustomers.Controls.Add(textBoxFullName);
            groupBoxCustomers.Controls.Add(textBoxId2);
            groupBoxCustomers.Controls.Add(labelFullName);
            groupBoxCustomers.Controls.Add(labelId2);
            groupBoxCustomers.Controls.Add(labelSelectedCustomers);
            groupBoxCustomers.Location = new Point(379, 3);
            groupBoxCustomers.Name = "groupBoxCustomers";
            groupBoxCustomers.Size = new Size(1042, 943);
            groupBoxCustomers.TabIndex = 1;
            groupBoxCustomers.TabStop = false;
            // 
            // addressControl1
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 0;
            address1.Street = "";
            addressControl1.Address = address1;
            addressControl1.Location = new Point(6, 104);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(550, 158);
            addressControl1.TabIndex = 0;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel.Location = new Point(6, 676);
            panel.Name = "panel";
            panel.Size = new Size(1025, 261);
            panel.TabIndex = 11;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(82, 75);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(297, 23);
            textBoxFullName.TabIndex = 9;
            // 
            // textBoxId2
            // 
            textBoxId2.Location = new Point(82, 46);
            textBoxId2.Name = "textBoxId2";
            textBoxId2.ReadOnly = true;
            textBoxId2.Size = new Size(125, 23);
            textBoxId2.TabIndex = 8;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(6, 78);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(64, 15);
            labelFullName.TabIndex = 6;
            labelFullName.Text = "Full Name:";
            // 
            // labelId2
            // 
            labelId2.AutoSize = true;
            labelId2.Location = new Point(6, 46);
            labelId2.Name = "labelId2";
            labelId2.Size = new Size(21, 15);
            labelId2.TabIndex = 5;
            labelId2.Text = "ID:";
            // 
            // labelSelectedCustomers
            // 
            labelSelectedCustomers.AutoSize = true;
            labelSelectedCustomers.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSelectedCustomers.Location = new Point(6, 19);
            labelSelectedCustomers.Name = "labelSelectedCustomers";
            labelSelectedCustomers.Size = new Size(129, 17);
            labelSelectedCustomers.TabIndex = 4;
            labelSelectedCustomers.Text = "Selected Customers";
            // 
            // buttonRemove2
            // 
            buttonRemove2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRemove2.Location = new Point(117, 884);
            buttonRemove2.Name = "buttonRemove2";
            buttonRemove2.Size = new Size(105, 53);
            buttonRemove2.TabIndex = 3;
            buttonRemove2.Text = "Remove";
            buttonRemove2.UseVisualStyleBackColor = true;
            buttonRemove2.Click += buttonRemove2_Click;
            // 
            // buttonAdd2
            // 
            buttonAdd2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAdd2.Location = new Point(6, 884);
            buttonAdd2.Name = "buttonAdd2";
            buttonAdd2.Size = new Size(105, 53);
            buttonAdd2.TabIndex = 2;
            buttonAdd2.Text = "Add";
            buttonAdd2.UseVisualStyleBackColor = true;
            buttonAdd2.Click += buttonAdd2_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(6, 39);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(352, 829);
            CustomersListBox.TabIndex = 1;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // groupBoxCustomers2
            // 
            groupBoxCustomers2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxCustomers2.Controls.Add(labelCustomers);
            groupBoxCustomers2.Controls.Add(CustomersListBox);
            groupBoxCustomers2.Controls.Add(buttonAdd2);
            groupBoxCustomers2.Controls.Add(buttonRemove2);
            groupBoxCustomers2.Location = new Point(3, 3);
            groupBoxCustomers2.Name = "groupBoxCustomers2";
            groupBoxCustomers2.Size = new Size(370, 943);
            groupBoxCustomers2.TabIndex = 2;
            groupBoxCustomers2.TabStop = false;
            // 
            // tableLayoutCustomersPanel
            // 
            tableLayoutCustomersPanel.ColumnCount = 2;
            tableLayoutCustomersPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.4044952F));
            tableLayoutCustomersPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.5955048F));
            tableLayoutCustomersPanel.Controls.Add(groupBoxCustomers2, 0, 0);
            tableLayoutCustomersPanel.Controls.Add(groupBoxCustomers, 1, 0);
            tableLayoutCustomersPanel.Dock = DockStyle.Fill;
            tableLayoutCustomersPanel.Location = new Point(0, 0);
            tableLayoutCustomersPanel.Name = "tableLayoutCustomersPanel";
            tableLayoutCustomersPanel.RowCount = 1;
            tableLayoutCustomersPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutCustomersPanel.Size = new Size(1424, 949);
            tableLayoutCustomersPanel.TabIndex = 3;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutCustomersPanel);
            Name = "CustomersTab";
            Size = new Size(1424, 949);
            groupBoxCustomers.ResumeLayout(false);
            groupBoxCustomers.PerformLayout();
            groupBoxCustomers2.ResumeLayout(false);
            groupBoxCustomers2.PerformLayout();
            tableLayoutCustomersPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelCustomers;
        private GroupBox groupBoxCustomers;
        private Button buttonRemove2;
        private Button buttonAdd2;
        private ListBox CustomersListBox;
        private Label labelSelectedCustomers;
        private TextBox textBoxFullName;
        private TextBox textBoxId2;
        private Label labelFullName;
        private Label labelId2;
        private Panel panel;
        private GroupBox groupBoxCustomers2;
        private TableLayoutPanel tableLayoutCustomersPanel;
        private Controls.AddressControl addressControl1;
    }
}
