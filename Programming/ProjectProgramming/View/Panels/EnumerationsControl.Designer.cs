namespace ProjectProgramming.View.Panels
{
    partial class EnumerationsControl
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
            IntLabel = new Label();
            TextBoxValue = new TextBox();
            ValuesListBox = new ListBox();
            ValueLabel = new Label();
            EnumsListBox = new ListBox();
            EnumLabel = new Label();
            SuspendLayout();
            // 
            // IntLabel
            // 
            IntLabel.AutoSize = true;
            IntLabel.Location = new Point(320, 10);
            IntLabel.Name = "IntLabel";
            IntLabel.Size = new Size(55, 15);
            IntLabel.TabIndex = 11;
            IntLabel.Text = "Int Value:";
            // 
            // TextBoxValue
            // 
            TextBoxValue.Location = new Point(320, 28);
            TextBoxValue.Name = "TextBoxValue";
            TextBoxValue.Size = new Size(100, 23);
            TextBoxValue.TabIndex = 10;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(162, 28);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(121, 199);
            ValuesListBox.TabIndex = 9;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Location = new Point(162, 10);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(81, 15);
            ValueLabel.TabIndex = 8;
            ValueLabel.Text = "Choose value:";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Color", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" });
            EnumsListBox.Location = new Point(4, 28);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(120, 199);
            EnumsListBox.TabIndex = 7;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // EnumLabel
            // 
            EnumLabel.AutoSize = true;
            EnumLabel.Location = new Point(3, 10);
            EnumLabel.Name = "EnumLabel";
            EnumLabel.Size = new Size(121, 15);
            EnumLabel.TabIndex = 6;
            EnumLabel.Text = "Choose enumeration:";
            // 
            // EnumerationsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(IntLabel);
            Controls.Add(TextBoxValue);
            Controls.Add(ValuesListBox);
            Controls.Add(ValueLabel);
            Controls.Add(EnumsListBox);
            Controls.Add(EnumLabel);
            Name = "EnumerationsControl";
            Size = new Size(756, 266);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IntLabel;
        private TextBox TextBoxValue;
        private ListBox ValuesListBox;
        private Label ValueLabel;
        private ListBox EnumsListBox;
        private Label EnumLabel;
    }
}
