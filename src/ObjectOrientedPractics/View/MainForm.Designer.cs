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
            tabControlMainForm = new TabControl();
            tabPageItems = new TabPage();
            itemsTab = new View.Tabs.ItemsTab();
            tabPage2 = new TabPage();
            tabControlMainForm.SuspendLayout();
            tabPageItems.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMainForm
            // 
            tabControlMainForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlMainForm.Controls.Add(tabPageItems);
            tabControlMainForm.Controls.Add(tabPage2);
            tabControlMainForm.Location = new Point(0, 0);
            tabControlMainForm.Name = "tabControlMainForm";
            tabControlMainForm.SelectedIndex = 0;
            tabControlMainForm.Size = new Size(1031, 645);
            tabControlMainForm.TabIndex = 0;
            // 
            // tabPageItems
            // 
            tabPageItems.Controls.Add(itemsTab);
            tabPageItems.Location = new Point(4, 24);
            tabPageItems.Name = "tabPageItems";
            tabPageItems.Padding = new Padding(3);
            tabPageItems.Size = new Size(1023, 617);
            tabPageItems.TabIndex = 0;
            tabPageItems.Text = "Items";
            tabPageItems.UseVisualStyleBackColor = true;
            // 
            // itemsTab
            // 
            itemsTab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            itemsTab.Location = new Point(3, 3);
            itemsTab.Name = "itemsTab";
            itemsTab.Size = new Size(1017, 611);
            itemsTab.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1023, 617);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 645);
            Controls.Add(tabControlMainForm);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            tabControlMainForm.ResumeLayout(false);
            tabPageItems.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMainForm;
        private TabPage tabPageItems;
        private TabPage tabPage2;
        private View.Tabs.ItemsTab itemsTab;
    }
}
