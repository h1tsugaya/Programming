namespace ProjectProgramming.View.Panels
{
    partial class WeekdayParsingControl
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
            ResultLabel = new Label();
            ParseButton = new Button();
            WeekdayTextBox = new TextBox();
            ParsingLabel = new Label();
            SuspendLayout();
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(3, 66);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(0, 15);
            ResultLabel.TabIndex = 7;
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(162, 29);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(75, 24);
            ParseButton.TabIndex = 6;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // WeekdayTextBox
            // 
            WeekdayTextBox.Location = new Point(3, 29);
            WeekdayTextBox.Name = "WeekdayTextBox";
            WeekdayTextBox.Size = new Size(153, 23);
            WeekdayTextBox.TabIndex = 5;
            // 
            // ParsingLabel
            // 
            ParsingLabel.AutoSize = true;
            ParsingLabel.Location = new Point(3, 10);
            ParsingLabel.Name = "ParsingLabel";
            ParsingLabel.Size = new Size(125, 15);
            ParsingLabel.TabIndex = 4;
            ParsingLabel.Text = "Type value for parsing:";
            // 
            // WeekdayParsingControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ResultLabel);
            Controls.Add(ParseButton);
            Controls.Add(WeekdayTextBox);
            Controls.Add(ParsingLabel);
            Name = "WeekdayParsingControl";
            Size = new Size(305, 134);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ResultLabel;
        private Button ParseButton;
        private TextBox WeekdayTextBox;
        private Label ParsingLabel;
    }
}
