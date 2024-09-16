namespace ProjectProgramming.View.Panels
{
    partial class RectanglesControl
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
            middleYTextBox = new TextBox();
            middleXTextBox = new TextBox();
            middleYLabel = new Label();
            middleXLabel = new Label();
            idLabel = new Label();
            idTextBox = new TextBox();
            buttonRectangle = new Button();
            RectanglesListBox = new ListBox();
            textBoxColor = new TextBox();
            labelColor = new Label();
            textBoxLength = new TextBox();
            labelWidth = new Label();
            textBoxWidth = new TextBox();
            labelLength = new Label();
            SuspendLayout();
            // 
            // middleYTextBox
            // 
            middleYTextBox.Enabled = false;
            middleYTextBox.Location = new Point(233, 219);
            middleYTextBox.Name = "middleYTextBox";
            middleYTextBox.Size = new Size(100, 23);
            middleYTextBox.TabIndex = 27;
            // 
            // middleXTextBox
            // 
            middleXTextBox.Enabled = false;
            middleXTextBox.Location = new Point(233, 171);
            middleXTextBox.Name = "middleXTextBox";
            middleXTextBox.Size = new Size(100, 23);
            middleXTextBox.TabIndex = 26;
            // 
            // middleYLabel
            // 
            middleYLabel.AutoSize = true;
            middleYLabel.Location = new Point(233, 201);
            middleYLabel.Name = "middleYLabel";
            middleYLabel.Size = new Size(57, 15);
            middleYLabel.TabIndex = 25;
            middleYLabel.Text = "Middle Y:";
            // 
            // middleXLabel
            // 
            middleXLabel.AutoSize = true;
            middleXLabel.Location = new Point(233, 153);
            middleXLabel.Name = "middleXLabel";
            middleXLabel.Size = new Size(57, 15);
            middleXLabel.TabIndex = 24;
            middleXLabel.Text = "Middle X:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(233, 248);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(20, 15);
            idLabel.TabIndex = 23;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(233, 266);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(100, 23);
            idTextBox.TabIndex = 22;
            idTextBox.KeyPress += TextBoxDisable;
            // 
            // buttonRectangle
            // 
            buttonRectangle.Location = new Point(233, 374);
            buttonRectangle.Name = "buttonRectangle";
            buttonRectangle.Size = new Size(100, 23);
            buttonRectangle.TabIndex = 21;
            buttonRectangle.Text = "Find";
            buttonRectangle.UseVisualStyleBackColor = true;
            buttonRectangle.Click += buttonRectangle_Click;
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Location = new Point(5, 18);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(222, 379);
            RectanglesListBox.TabIndex = 14;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(233, 124);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(100, 23);
            textBoxColor.TabIndex = 17;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(233, 106);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(39, 15);
            labelColor.TabIndex = 20;
            labelColor.Text = "Color:";
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new Point(233, 36);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new Size(100, 23);
            textBoxLength.TabIndex = 15;
            textBoxLength.TextChanged += textBoxLength_TextChanged;
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Location = new Point(233, 62);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(42, 15);
            labelWidth.TabIndex = 19;
            labelWidth.Text = "Width:";
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(233, 80);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(100, 23);
            textBoxWidth.TabIndex = 16;
            textBoxWidth.TextChanged += textBoxWidth_TextChanged;
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(233, 18);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(47, 15);
            labelLength.TabIndex = 18;
            labelLength.Text = "Length:";
            // 
            // RectanglesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(middleYTextBox);
            Controls.Add(middleXTextBox);
            Controls.Add(middleYLabel);
            Controls.Add(middleXLabel);
            Controls.Add(idLabel);
            Controls.Add(idTextBox);
            Controls.Add(buttonRectangle);
            Controls.Add(RectanglesListBox);
            Controls.Add(textBoxColor);
            Controls.Add(labelColor);
            Controls.Add(textBoxLength);
            Controls.Add(labelWidth);
            Controls.Add(textBoxWidth);
            Controls.Add(labelLength);
            Name = "RectanglesControl";
            Size = new Size(338, 414);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox middleYTextBox;
        private TextBox middleXTextBox;
        private Label middleYLabel;
        private Label middleXLabel;
        private Label idLabel;
        private TextBox idTextBox;
        private Button buttonRectangle;
        private ListBox RectanglesListBox;
        private TextBox textBoxColor;
        private Label labelColor;
        private TextBox textBoxLength;
        private Label labelWidth;
        private TextBox textBoxWidth;
        private Label labelLength;
    }
}
