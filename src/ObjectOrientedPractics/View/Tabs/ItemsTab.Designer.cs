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
            groupBoxSelectedItems = new GroupBox();
            textBoxDescription = new TextBox();
            labelDescription = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            textBoxCost = new TextBox();
            labelCost = new Label();
            textBoxId = new TextBox();
            labelId = new Label();
            labelSelectedItem = new Label();
            groupBoxSelectedItems.SuspendLayout();
            SuspendLayout();
            // 
            // itemsListBox
            // 
            itemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            itemsListBox.FormattingEnabled = true;
            itemsListBox.ItemHeight = 15;
            itemsListBox.Location = new Point(6, 35);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(360, 394);
            itemsListBox.TabIndex = 0;
            itemsListBox.SelectedIndexChanged += itemsListBox_SelectedIndexChanged;
            // 
            // buttonAddItem
            // 
            buttonAddItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddItem.AutoSize = true;
            buttonAddItem.Location = new Point(6, 446);
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
            buttonRemoveItem.Location = new Point(117, 446);
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
            labelItems.Location = new Point(6, 17);
            labelItems.Name = "labelItems";
            labelItems.Size = new Size(40, 15);
            labelItems.TabIndex = 1;
            labelItems.Text = "Items";
            // 
            // groupBoxSelectedItems
            // 
            groupBoxSelectedItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxSelectedItems.Controls.Add(textBoxDescription);
            groupBoxSelectedItems.Controls.Add(labelDescription);
            groupBoxSelectedItems.Controls.Add(textBoxName);
            groupBoxSelectedItems.Controls.Add(labelName);
            groupBoxSelectedItems.Controls.Add(textBoxCost);
            groupBoxSelectedItems.Controls.Add(labelCost);
            groupBoxSelectedItems.Controls.Add(textBoxId);
            groupBoxSelectedItems.Controls.Add(labelId);
            groupBoxSelectedItems.Controls.Add(labelSelectedItem);
            groupBoxSelectedItems.Controls.Add(itemsListBox);
            groupBoxSelectedItems.Controls.Add(labelItems);
            groupBoxSelectedItems.Controls.Add(buttonRemoveItem);
            groupBoxSelectedItems.Controls.Add(buttonAddItem);
            groupBoxSelectedItems.Location = new Point(0, 0);
            groupBoxSelectedItems.Name = "groupBoxSelectedItems";
            groupBoxSelectedItems.Size = new Size(984, 507);
            groupBoxSelectedItems.TabIndex = 4;
            groupBoxSelectedItems.TabStop = false;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescription.Location = new Point(372, 245);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(606, 109);
            textBoxDescription.TabIndex = 11;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(372, 227);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(70, 15);
            labelDescription.TabIndex = 10;
            labelDescription.Text = "Description:";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.Location = new Point(372, 121);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(606, 103);
            textBoxName.TabIndex = 9;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(372, 103);
            labelName.Name = "labelName";
            labelName.Size = new Size(42, 15);
            labelName.TabIndex = 8;
            labelName.Text = "Name:";
            // 
            // textBoxCost
            // 
            textBoxCost.Location = new Point(441, 67);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(166, 23);
            textBoxCost.TabIndex = 7;
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Location = new Point(375, 70);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(34, 15);
            labelCost.TabIndex = 6;
            labelCost.Text = "Cost:";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(441, 41);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(166, 23);
            textBoxId.TabIndex = 5;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(375, 44);
            labelId.Name = "labelId";
            labelId.Size = new Size(21, 15);
            labelId.TabIndex = 4;
            labelId.Text = "ID:";
            // 
            // labelSelectedItem
            // 
            labelSelectedItem.AutoSize = true;
            labelSelectedItem.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSelectedItem.Location = new Point(375, 19);
            labelSelectedItem.Name = "labelSelectedItem";
            labelSelectedItem.Size = new Size(88, 15);
            labelSelectedItem.TabIndex = 0;
            labelSelectedItem.Text = "Selected Item";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxSelectedItems);
            Name = "ItemsTab";
            Size = new Size(984, 507);
            groupBoxSelectedItems.ResumeLayout(false);
            groupBoxSelectedItems.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListBox itemsListBox;
        private Button buttonRemoveItem;
        private Button buttonAddItem;
        private Label labelItems;
        private GroupBox groupBoxSelectedItems;
        private Label labelSelectedItem;
        private Label labelDescription;
        private TextBox textBoxName;
        private Label labelName;
        private TextBox textBoxCost;
        private Label labelCost;
        private TextBox textBoxId;
        private Label labelId;
        private TextBox textBoxDescription;
    }
}
