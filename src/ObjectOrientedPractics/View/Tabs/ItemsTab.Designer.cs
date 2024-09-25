namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            itemsListBox = new ListBox();
            buttonAddItem = new Button();
            buttonRemoveItem = new Button();
            labelItems = new Label();
            groupBoxSelectedItems1 = new GroupBox();
            textBoxDescription = new TextBox();
            labelDescription = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            textBoxCost = new TextBox();
            labelCost = new Label();
            textBoxId = new TextBox();
            labelId = new Label();
            labelSelectedItem = new Label();
            groupBoxSelectedItems2 = new GroupBox();
            panel2 = new Panel();
            tableLayoutItemsPanel = new TableLayoutPanel();
            groupBoxSelectedItems1.SuspendLayout();
            groupBoxSelectedItems2.SuspendLayout();
            tableLayoutItemsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // itemsListBox
            // 
            itemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            itemsListBox.FormattingEnabled = true;
            itemsListBox.ItemHeight = 15;
            itemsListBox.Location = new Point(6, 29);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(360, 724);
            itemsListBox.TabIndex = 0;
            itemsListBox.SelectedIndexChanged += itemsListBox_SelectedIndexChanged;
            // 
            // buttonAddItem
            // 
            buttonAddItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddItem.AutoSize = true;
            buttonAddItem.Location = new Point(6, 774);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(105, 53);
            buttonAddItem.TabIndex = 2;
            buttonAddItem.Text = "Add";
            buttonAddItem.UseVisualStyleBackColor = true;
            buttonAddItem.Click += buttonAddItem_Click;
            // 
            // buttonRemoveItem
            // 
            buttonRemoveItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRemoveItem.AutoSize = true;
            buttonRemoveItem.Location = new Point(117, 774);
            buttonRemoveItem.Name = "buttonRemoveItem";
            buttonRemoveItem.Size = new Size(105, 53);
            buttonRemoveItem.TabIndex = 3;
            buttonRemoveItem.Text = "Remove";
            buttonRemoveItem.UseVisualStyleBackColor = true;
            buttonRemoveItem.Click += buttonRemoveItem_Click;
            // 
            // labelItems
            // 
            labelItems.AutoSize = true;
            labelItems.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelItems.Location = new Point(6, 11);
            labelItems.Name = "labelItems";
            labelItems.Size = new Size(40, 15);
            labelItems.TabIndex = 1;
            labelItems.Text = "Items";
            // 
            // groupBoxSelectedItems1
            // 
            groupBoxSelectedItems1.Controls.Add(itemsListBox);
            groupBoxSelectedItems1.Controls.Add(labelItems);
            groupBoxSelectedItems1.Controls.Add(buttonRemoveItem);
            groupBoxSelectedItems1.Controls.Add(buttonAddItem);
            groupBoxSelectedItems1.Dock = DockStyle.Fill;
            groupBoxSelectedItems1.Location = new Point(3, 3);
            groupBoxSelectedItems1.Name = "groupBoxSelectedItems1";
            groupBoxSelectedItems1.Size = new Size(371, 835);
            groupBoxSelectedItems1.TabIndex = 4;
            groupBoxSelectedItems1.TabStop = false;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescription.Location = new Point(7, 240);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(986, 454);
            textBoxDescription.TabIndex = 11;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(6, 222);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(70, 15);
            labelDescription.TabIndex = 10;
            labelDescription.Text = "Description:";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.Location = new Point(7, 116);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(986, 103);
            textBoxName.TabIndex = 9;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(7, 98);
            labelName.Name = "labelName";
            labelName.Size = new Size(42, 15);
            labelName.TabIndex = 8;
            labelName.Text = "Name:";
            // 
            // textBoxCost
            // 
            textBoxCost.Location = new Point(61, 61);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(166, 23);
            textBoxCost.TabIndex = 7;
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Location = new Point(6, 64);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(34, 15);
            labelCost.TabIndex = 6;
            labelCost.Text = "Cost:";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(61, 34);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(166, 23);
            textBoxId.TabIndex = 5;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(7, 37);
            labelId.Name = "labelId";
            labelId.Size = new Size(21, 15);
            labelId.TabIndex = 4;
            labelId.Text = "ID:";
            // 
            // labelSelectedItem
            // 
            labelSelectedItem.AutoSize = true;
            labelSelectedItem.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSelectedItem.Location = new Point(7, 16);
            labelSelectedItem.Name = "labelSelectedItem";
            labelSelectedItem.Size = new Size(88, 15);
            labelSelectedItem.TabIndex = 0;
            labelSelectedItem.Text = "Selected Item";
            // 
            // groupBoxSelectedItems2
            // 
            groupBoxSelectedItems2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxSelectedItems2.Controls.Add(panel2);
            groupBoxSelectedItems2.Controls.Add(labelSelectedItem);
            groupBoxSelectedItems2.Controls.Add(textBoxDescription);
            groupBoxSelectedItems2.Controls.Add(labelId);
            groupBoxSelectedItems2.Controls.Add(labelCost);
            groupBoxSelectedItems2.Controls.Add(labelDescription);
            groupBoxSelectedItems2.Controls.Add(textBoxId);
            groupBoxSelectedItems2.Controls.Add(textBoxName);
            groupBoxSelectedItems2.Controls.Add(textBoxCost);
            groupBoxSelectedItems2.Controls.Add(labelName);
            groupBoxSelectedItems2.Location = new Point(380, 3);
            groupBoxSelectedItems2.Name = "groupBoxSelectedItems2";
            groupBoxSelectedItems2.Size = new Size(999, 835);
            groupBoxSelectedItems2.TabIndex = 12;
            groupBoxSelectedItems2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Location = new Point(7, 700);
            panel2.Name = "panel2";
            panel2.Size = new Size(986, 129);
            panel2.TabIndex = 12;
            // 
            // tableLayoutItemsPanel
            // 
            tableLayoutItemsPanel.ColumnCount = 2;
            tableLayoutItemsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.32558F));
            tableLayoutItemsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.6744156F));
            tableLayoutItemsPanel.Controls.Add(groupBoxSelectedItems1, 0, 0);
            tableLayoutItemsPanel.Controls.Add(groupBoxSelectedItems2, 1, 0);
            tableLayoutItemsPanel.Dock = DockStyle.Fill;
            tableLayoutItemsPanel.Location = new Point(0, 0);
            tableLayoutItemsPanel.Name = "tableLayoutItemsPanel";
            tableLayoutItemsPanel.RowCount = 1;
            tableLayoutItemsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutItemsPanel.Size = new Size(1382, 841);
            tableLayoutItemsPanel.TabIndex = 13;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutItemsPanel);
            Name = "ItemsTab";
            Size = new Size(1382, 841);
            groupBoxSelectedItems1.ResumeLayout(false);
            groupBoxSelectedItems1.PerformLayout();
            groupBoxSelectedItems2.ResumeLayout(false);
            groupBoxSelectedItems2.PerformLayout();
            tableLayoutItemsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListBox itemsListBox;
        private Button buttonRemoveItem;
        private Button buttonAddItem;
        private Label labelItems;
        private GroupBox groupBoxSelectedItems1;
        private Label labelSelectedItem;
        private Label labelDescription;
        private TextBox textBoxName;
        private Label labelName;
        private TextBox textBoxCost;
        private Label labelCost;
        private TextBox textBoxId;
        private Label labelId;
        private TextBox textBoxDescription;
        private GroupBox groupBoxSelectedItems2;
        private TableLayoutPanel tableLayoutItemsPanel;
        private Panel panel2;
    }
}
