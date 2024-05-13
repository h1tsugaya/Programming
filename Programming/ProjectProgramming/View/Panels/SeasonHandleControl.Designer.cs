namespace ProjectProgramming.View.Panels
{
    partial class SeasonHandleControl
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
            SeasonButton = new Button();
            SeasonComboBox = new ComboBox();
            SeasonLabel = new Label();
            SuspendLayout();
            // 
            // SeasonButton
            // 
            SeasonButton.Location = new Point(188, 28);
            SeasonButton.Name = "SeasonButton";
            SeasonButton.Size = new Size(85, 24);
            SeasonButton.TabIndex = 5;
            SeasonButton.Text = "Go!";
            SeasonButton.UseVisualStyleBackColor = true;
            SeasonButton.Click += SeasonButton_Click;
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Location = new Point(3, 28);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(179, 23);
            SeasonComboBox.TabIndex = 4;
            // 
            // SeasonLabel
            // 
            SeasonLabel.AutoSize = true;
            SeasonLabel.Location = new Point(3, 9);
            SeasonLabel.Name = "SeasonLabel";
            SeasonLabel.Size = new Size(89, 15);
            SeasonLabel.TabIndex = 3;
            SeasonLabel.Text = "Choose season:";
            // 
            // SeasonHandleControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SeasonButton);
            Controls.Add(SeasonComboBox);
            Controls.Add(SeasonLabel);
            Name = "SeasonHandleControl";
            Size = new Size(433, 134);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SeasonButton;
        private ComboBox SeasonComboBox;
        private Label SeasonLabel;
    }
}
