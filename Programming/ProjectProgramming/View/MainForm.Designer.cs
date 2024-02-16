namespace ProjectProgramming
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
            TabControl = new TabControl();
            tabPage1 = new TabPage();
            EnumGroupBox = new GroupBox();
            IntLabel = new Label();
            TextBoxValue = new TextBox();
            ValuesListBox = new ListBox();
            ValueLabel = new Label();
            EnumsListBox = new ListBox();
            EnumLabel = new Label();
            TabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            EnumGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPage1);
            TabControl.Location = new Point(12, 12);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(776, 426);
            TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(EnumGroupBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // EnumGroupBox
            // 
            EnumGroupBox.Controls.Add(IntLabel);
            EnumGroupBox.Controls.Add(TextBoxValue);
            EnumGroupBox.Controls.Add(ValuesListBox);
            EnumGroupBox.Controls.Add(ValueLabel);
            EnumGroupBox.Controls.Add(EnumsListBox);
            EnumGroupBox.Controls.Add(EnumLabel);
            EnumGroupBox.Location = new Point(6, 6);
            EnumGroupBox.Name = "EnumGroupBox";
            EnumGroupBox.Size = new Size(756, 386);
            EnumGroupBox.TabIndex = 0;
            EnumGroupBox.TabStop = false;
            EnumGroupBox.Text = "Enumerations";
            // 
            // IntLabel
            // 
            IntLabel.AutoSize = true;
            IntLabel.Location = new Point(323, 19);
            IntLabel.Name = "IntLabel";
            IntLabel.Size = new Size(55, 15);
            IntLabel.TabIndex = 5;
            IntLabel.Text = "Int Value:";
            // 
            // TextBoxValue
            // 
            TextBoxValue.Location = new Point(323, 37);
            TextBoxValue.Name = "TextBoxValue";
            TextBoxValue.Size = new Size(100, 23);
            TextBoxValue.TabIndex = 4;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(165, 37);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(121, 199);
            ValuesListBox.TabIndex = 3;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Location = new Point(165, 19);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(81, 15);
            ValueLabel.TabIndex = 2;
            ValueLabel.Text = "Choose value:";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Color", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" });
            EnumsListBox.Location = new Point(7, 37);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(120, 199);
            EnumsListBox.TabIndex = 1;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // EnumLabel
            // 
            EnumLabel.AutoSize = true;
            EnumLabel.Location = new Point(6, 19);
            EnumLabel.Name = "EnumLabel";
            EnumLabel.Size = new Size(121, 15);
            EnumLabel.TabIndex = 0;
            EnumLabel.Text = "Choose enumeration:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TabControl);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            TabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            EnumGroupBox.ResumeLayout(false);
            EnumGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage tabPage1;
        private GroupBox EnumGroupBox;
        private Label EnumLabel;
        private ListBox EnumsListBox;
        private ListBox ValuesListBox;
        private Label ValueLabel;
        private Label IntLabel;
        private TextBox TextBoxValue;
    }
}