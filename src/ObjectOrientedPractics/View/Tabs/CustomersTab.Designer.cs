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
            labelCustomers = new Label();
            groupBoxCustomers = new GroupBox();
            panel = new Panel();
            textBoxAddress = new TextBox();
            textBoxFullName = new TextBox();
            textBoxId2 = new TextBox();
            labelAddress = new Label();
            labelFullName = new Label();
            labelId2 = new Label();
            labelSelectedCustomers = new Label();
            buttonRemove2 = new Button();
            buttonAdd2 = new Button();
            CustomersListBox = new ListBox();
            groupBoxCustomers.SuspendLayout();
            SuspendLayout();
            // 
            // labelCustomers
            // 
            labelCustomers.AutoSize = true;
            labelCustomers.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCustomers.Location = new Point(6, 17);
            labelCustomers.Name = "labelCustomers";
            labelCustomers.Size = new Size(74, 17);
            labelCustomers.TabIndex = 0;
            labelCustomers.Text = "Customers";
            // 
            // groupBoxCustomers
            // 
            groupBoxCustomers.Controls.Add(panel);
            groupBoxCustomers.Controls.Add(textBoxAddress);
            groupBoxCustomers.Controls.Add(textBoxFullName);
            groupBoxCustomers.Controls.Add(textBoxId2);
            groupBoxCustomers.Controls.Add(labelAddress);
            groupBoxCustomers.Controls.Add(labelFullName);
            groupBoxCustomers.Controls.Add(labelId2);
            groupBoxCustomers.Controls.Add(labelSelectedCustomers);
            groupBoxCustomers.Controls.Add(buttonRemove2);
            groupBoxCustomers.Controls.Add(buttonAdd2);
            groupBoxCustomers.Controls.Add(CustomersListBox);
            groupBoxCustomers.Controls.Add(labelCustomers);
            groupBoxCustomers.Location = new Point(3, 3);
            groupBoxCustomers.Name = "groupBoxCustomers";
            groupBoxCustomers.Size = new Size(912, 515);
            groupBoxCustomers.TabIndex = 1;
            groupBoxCustomers.TabStop = false;
            // 
            // panel
            // 
            panel.Location = new Point(334, 253);
            panel.Name = "panel";
            panel.Size = new Size(572, 249);
            panel.TabIndex = 11;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(407, 108);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(499, 139);
            textBoxAddress.TabIndex = 10;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(407, 78);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(499, 23);
            textBoxFullName.TabIndex = 9;
            // 
            // textBoxId2
            // 
            textBoxId2.Location = new Point(407, 46);
            textBoxId2.Name = "textBoxId2";
            textBoxId2.Size = new Size(127, 23);
            textBoxId2.TabIndex = 8;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(334, 108);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(52, 15);
            labelAddress.TabIndex = 7;
            labelAddress.Text = "Address:";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(334, 78);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(64, 15);
            labelFullName.TabIndex = 6;
            labelFullName.Text = "Full Name:";
            // 
            // labelId2
            // 
            labelId2.AutoSize = true;
            labelId2.Location = new Point(334, 49);
            labelId2.Name = "labelId2";
            labelId2.Size = new Size(21, 15);
            labelId2.TabIndex = 5;
            labelId2.Text = "ID:";
            // 
            // labelSelectedCustomers
            // 
            labelSelectedCustomers.AutoSize = true;
            labelSelectedCustomers.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSelectedCustomers.Location = new Point(334, 17);
            labelSelectedCustomers.Name = "labelSelectedCustomers";
            labelSelectedCustomers.Size = new Size(129, 17);
            labelSelectedCustomers.TabIndex = 4;
            labelSelectedCustomers.Text = "Selected Customers";
            // 
            // buttonRemove2
            // 
            buttonRemove2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRemove2.Location = new Point(117, 460);
            buttonRemove2.Name = "buttonRemove2";
            buttonRemove2.Size = new Size(105, 42);
            buttonRemove2.TabIndex = 3;
            buttonRemove2.Text = "Remove";
            buttonRemove2.UseVisualStyleBackColor = true;
            buttonRemove2.Click += buttonRemove2_Click;
            // 
            // buttonAdd2
            // 
            buttonAdd2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAdd2.Location = new Point(6, 460);
            buttonAdd2.Name = "buttonAdd2";
            buttonAdd2.Size = new Size(105, 46);
            buttonAdd2.TabIndex = 2;
            buttonAdd2.Text = "Add";
            buttonAdd2.UseVisualStyleBackColor = true;
            buttonAdd2.Click += buttonAdd2_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(6, 37);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(320, 409);
            CustomersListBox.TabIndex = 1;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxCustomers);
            Name = "CustomersTab";
            Size = new Size(918, 523);
            groupBoxCustomers.ResumeLayout(false);
            groupBoxCustomers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelCustomers;
        private GroupBox groupBoxCustomers;
        private Button buttonRemove2;
        private Button buttonAdd2;
        private ListBox CustomersListBox;
        private Label labelSelectedCustomers;
        private TextBox textBoxAddress;
        private TextBox textBoxFullName;
        private TextBox textBoxId2;
        private Label labelAddress;
        private Label labelFullName;
        private Label labelId2;
        private Panel panel;
    }
}
