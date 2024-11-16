namespace ObjectOrientedPractics.View.Tabs
{
    partial class AddDiscountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelPercentDiscount = new Label();
            labelCategory = new Label();
            comboBoxDiscountCategory = new ComboBox();
            buttonOk = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelPercentDiscount
            // 
            labelPercentDiscount.AutoSize = true;
            labelPercentDiscount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPercentDiscount.Location = new Point(12, 9);
            labelPercentDiscount.Name = "labelPercentDiscount";
            labelPercentDiscount.Size = new Size(117, 17);
            labelPercentDiscount.TabIndex = 0;
            labelPercentDiscount.Text = "Percent Discount:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(12, 44);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(58, 15);
            labelCategory.TabIndex = 1;
            labelCategory.Text = "Category:";
            // 
            // comboBoxDiscountCategory
            // 
            comboBoxDiscountCategory.FormattingEnabled = true;
            comboBoxDiscountCategory.Location = new Point(76, 41);
            comboBoxDiscountCategory.Name = "comboBoxDiscountCategory";
            comboBoxDiscountCategory.Size = new Size(285, 23);
            comboBoxDiscountCategory.TabIndex = 2;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(157, 89);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(99, 44);
            buttonOk.TabIndex = 3;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(262, 89);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(99, 44);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // AddDiscountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 168);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(comboBoxDiscountCategory);
            Controls.Add(labelCategory);
            Controls.Add(labelPercentDiscount);
            Name = "AddDiscountForm";
            Text = "AddDiscountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPercentDiscount;
        private Label labelCategory;
        private ComboBox comboBoxDiscountCategory;
        private Button buttonOk;
        private Button buttonCancel;
    }
}