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
            TabPageEnums = new TabPage();
            SeasonGroupBox = new GroupBox();
            SeasonButton = new Button();
            SeasonComboBox = new ComboBox();
            SeasonLabel = new Label();
            EnumGroupBox = new GroupBox();
            IntLabel = new Label();
            TextBoxValue = new TextBox();
            ValuesListBox = new ListBox();
            ValueLabel = new Label();
            EnumsListBox = new ListBox();
            EnumLabel = new Label();
            ParsingGroupBox = new GroupBox();
            ResultLabel = new Label();
            ParseButton = new Button();
            WeekdayTextBox = new TextBox();
            ParsingLabel = new Label();
            TabPageClasses = new TabPage();
            groupBoxMovies = new GroupBox();
            buttonMovies = new Button();
            textBoxRating = new TextBox();
            textBoxGenre = new TextBox();
            textBoxYearRelease = new TextBox();
            textBoxDuration = new TextBox();
            textBoxName = new TextBox();
            labelRating = new Label();
            labelGenre = new Label();
            labelReleaseYear = new Label();
            labelDuration = new Label();
            labelName = new Label();
            listBoxMovies = new ListBox();
            groupBoxRectangles = new GroupBox();
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
            TabPageRectangles = new TabPage();
            rectanglesCollisionControl1 = new View.Panels.RectanglesCollisionControl();
            TabControl.SuspendLayout();
            TabPageEnums.SuspendLayout();
            SeasonGroupBox.SuspendLayout();
            EnumGroupBox.SuspendLayout();
            ParsingGroupBox.SuspendLayout();
            TabPageClasses.SuspendLayout();
            groupBoxMovies.SuspendLayout();
            groupBoxRectangles.SuspendLayout();
            TabPageRectangles.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(TabPageEnums);
            TabControl.Controls.Add(TabPageClasses);
            TabControl.Controls.Add(TabPageRectangles);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(806, 566);
            TabControl.TabIndex = 0;
            // 
            // TabPageEnums
            // 
            TabPageEnums.Controls.Add(SeasonGroupBox);
            TabPageEnums.Controls.Add(EnumGroupBox);
            TabPageEnums.Controls.Add(ParsingGroupBox);
            TabPageEnums.Location = new Point(4, 24);
            TabPageEnums.Name = "TabPageEnums";
            TabPageEnums.Padding = new Padding(3);
            TabPageEnums.Size = new Size(798, 538);
            TabPageEnums.TabIndex = 0;
            TabPageEnums.Text = "Enums";
            TabPageEnums.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            SeasonGroupBox.Controls.Add(SeasonButton);
            SeasonGroupBox.Controls.Add(SeasonComboBox);
            SeasonGroupBox.Controls.Add(SeasonLabel);
            SeasonGroupBox.Location = new Point(329, 278);
            SeasonGroupBox.Name = "SeasonGroupBox";
            SeasonGroupBox.Size = new Size(433, 134);
            SeasonGroupBox.TabIndex = 2;
            SeasonGroupBox.TabStop = false;
            SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonButton
            // 
            SeasonButton.Location = new Point(195, 38);
            SeasonButton.Name = "SeasonButton";
            SeasonButton.Size = new Size(85, 24);
            SeasonButton.TabIndex = 2;
            SeasonButton.Text = "Go!";
            SeasonButton.UseVisualStyleBackColor = true;
            SeasonButton.Click += SeasonButton_Click;
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Location = new Point(10, 38);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(179, 23);
            SeasonComboBox.TabIndex = 1;
            // 
            // SeasonLabel
            // 
            SeasonLabel.AutoSize = true;
            SeasonLabel.Location = new Point(10, 19);
            SeasonLabel.Name = "SeasonLabel";
            SeasonLabel.Size = new Size(89, 15);
            SeasonLabel.TabIndex = 0;
            SeasonLabel.Text = "Choose season:";
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
            EnumGroupBox.Size = new Size(756, 266);
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
            // ParsingGroupBox
            // 
            ParsingGroupBox.Controls.Add(ResultLabel);
            ParsingGroupBox.Controls.Add(ParseButton);
            ParsingGroupBox.Controls.Add(WeekdayTextBox);
            ParsingGroupBox.Controls.Add(ParsingLabel);
            ParsingGroupBox.Location = new Point(8, 278);
            ParsingGroupBox.Name = "ParsingGroupBox";
            ParsingGroupBox.Size = new Size(305, 134);
            ParsingGroupBox.TabIndex = 1;
            ParsingGroupBox.TabStop = false;
            ParsingGroupBox.Text = "WeekdayParsing";
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(6, 75);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(0, 15);
            ResultLabel.TabIndex = 3;
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(165, 38);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(75, 24);
            ParseButton.TabIndex = 2;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // WeekdayTextBox
            // 
            WeekdayTextBox.Location = new Point(6, 38);
            WeekdayTextBox.Name = "WeekdayTextBox";
            WeekdayTextBox.Size = new Size(153, 23);
            WeekdayTextBox.TabIndex = 1;
            // 
            // ParsingLabel
            // 
            ParsingLabel.AutoSize = true;
            ParsingLabel.Location = new Point(6, 19);
            ParsingLabel.Name = "ParsingLabel";
            ParsingLabel.Size = new Size(125, 15);
            ParsingLabel.TabIndex = 0;
            ParsingLabel.Text = "Type value for parsing:";
            // 
            // TabPageClasses
            // 
            TabPageClasses.Controls.Add(groupBoxMovies);
            TabPageClasses.Controls.Add(groupBoxRectangles);
            TabPageClasses.Location = new Point(4, 24);
            TabPageClasses.Name = "TabPageClasses";
            TabPageClasses.Size = new Size(798, 538);
            TabPageClasses.TabIndex = 1;
            TabPageClasses.Text = "Classes";
            TabPageClasses.UseVisualStyleBackColor = true;
            // 
            // groupBoxMovies
            // 
            groupBoxMovies.Controls.Add(buttonMovies);
            groupBoxMovies.Controls.Add(textBoxRating);
            groupBoxMovies.Controls.Add(textBoxGenre);
            groupBoxMovies.Controls.Add(textBoxYearRelease);
            groupBoxMovies.Controls.Add(textBoxDuration);
            groupBoxMovies.Controls.Add(textBoxName);
            groupBoxMovies.Controls.Add(labelRating);
            groupBoxMovies.Controls.Add(labelGenre);
            groupBoxMovies.Controls.Add(labelReleaseYear);
            groupBoxMovies.Controls.Add(labelDuration);
            groupBoxMovies.Controls.Add(labelName);
            groupBoxMovies.Controls.Add(listBoxMovies);
            groupBoxMovies.Location = new Point(352, 3);
            groupBoxMovies.Name = "groupBoxMovies";
            groupBoxMovies.Size = new Size(410, 414);
            groupBoxMovies.TabIndex = 8;
            groupBoxMovies.TabStop = false;
            groupBoxMovies.Text = "Movies";
            // 
            // buttonMovies
            // 
            buttonMovies.Location = new Point(234, 375);
            buttonMovies.Name = "buttonMovies";
            buttonMovies.Size = new Size(100, 23);
            buttonMovies.TabIndex = 11;
            buttonMovies.Text = "Find";
            buttonMovies.UseVisualStyleBackColor = true;
            buttonMovies.Click += buttonMovies_Click;
            // 
            // textBoxRating
            // 
            textBoxRating.Location = new Point(234, 220);
            textBoxRating.Name = "textBoxRating";
            textBoxRating.Size = new Size(100, 23);
            textBoxRating.TabIndex = 10;
            textBoxRating.TextChanged += textBoxRating_TextChanged;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(234, 176);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(100, 23);
            textBoxGenre.TabIndex = 9;
            textBoxGenre.TextChanged += textBoxGenre_TextChanged;
            // 
            // textBoxYearRelease
            // 
            textBoxYearRelease.Location = new Point(234, 128);
            textBoxYearRelease.Name = "textBoxYearRelease";
            textBoxYearRelease.Size = new Size(100, 23);
            textBoxYearRelease.TabIndex = 8;
            textBoxYearRelease.TextChanged += textBoxYearRelease_TextChanged;
            // 
            // textBoxDuration
            // 
            textBoxDuration.Location = new Point(234, 81);
            textBoxDuration.Name = "textBoxDuration";
            textBoxDuration.Size = new Size(100, 23);
            textBoxDuration.TabIndex = 7;
            textBoxDuration.TextChanged += textBoxDuration_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(234, 37);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 6;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // labelRating
            // 
            labelRating.AutoSize = true;
            labelRating.Location = new Point(234, 202);
            labelRating.Name = "labelRating";
            labelRating.Size = new Size(44, 15);
            labelRating.TabIndex = 5;
            labelRating.Text = "Rating:";
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(234, 154);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(41, 15);
            labelGenre.TabIndex = 4;
            labelGenre.Text = "Genre:";
            // 
            // labelReleaseYear
            // 
            labelReleaseYear.AutoSize = true;
            labelReleaseYear.Location = new Point(234, 107);
            labelReleaseYear.Name = "labelReleaseYear";
            labelReleaseYear.Size = new Size(71, 15);
            labelReleaseYear.TabIndex = 3;
            labelReleaseYear.Text = "Year release:";
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Location = new Point(234, 63);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(56, 15);
            labelDuration.TabIndex = 2;
            labelDuration.Text = "Duration:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(234, 19);
            labelName.Name = "labelName";
            labelName.Size = new Size(42, 15);
            labelName.TabIndex = 1;
            labelName.Text = "Name:";
            // 
            // listBoxMovies
            // 
            listBoxMovies.FormattingEnabled = true;
            listBoxMovies.ItemHeight = 15;
            listBoxMovies.Location = new Point(0, 22);
            listBoxMovies.Name = "listBoxMovies";
            listBoxMovies.Size = new Size(222, 379);
            listBoxMovies.TabIndex = 0;
            listBoxMovies.SelectedIndexChanged += listBoxMovies_SelectedIndexChanged;
            // 
            // groupBoxRectangles
            // 
            groupBoxRectangles.Controls.Add(middleYTextBox);
            groupBoxRectangles.Controls.Add(middleXTextBox);
            groupBoxRectangles.Controls.Add(middleYLabel);
            groupBoxRectangles.Controls.Add(middleXLabel);
            groupBoxRectangles.Controls.Add(idLabel);
            groupBoxRectangles.Controls.Add(idTextBox);
            groupBoxRectangles.Controls.Add(buttonRectangle);
            groupBoxRectangles.Controls.Add(RectanglesListBox);
            groupBoxRectangles.Controls.Add(textBoxColor);
            groupBoxRectangles.Controls.Add(labelColor);
            groupBoxRectangles.Controls.Add(textBoxLength);
            groupBoxRectangles.Controls.Add(labelWidth);
            groupBoxRectangles.Controls.Add(textBoxWidth);
            groupBoxRectangles.Controls.Add(labelLength);
            groupBoxRectangles.Location = new Point(8, 3);
            groupBoxRectangles.Name = "groupBoxRectangles";
            groupBoxRectangles.Size = new Size(338, 414);
            groupBoxRectangles.TabIndex = 7;
            groupBoxRectangles.TabStop = false;
            groupBoxRectangles.Text = "Rectangles";
            // 
            // middleYTextBox
            // 
            middleYTextBox.Enabled = false;
            middleYTextBox.Location = new Point(234, 220);
            middleYTextBox.Name = "middleYTextBox";
            middleYTextBox.Size = new Size(100, 23);
            middleYTextBox.TabIndex = 13;
            middleYTextBox.KeyPress += TextBoxDisable;
            // 
            // middleXTextBox
            // 
            middleXTextBox.Enabled = false;
            middleXTextBox.Location = new Point(234, 172);
            middleXTextBox.Name = "middleXTextBox";
            middleXTextBox.Size = new Size(100, 23);
            middleXTextBox.TabIndex = 12;
            middleXTextBox.KeyPress += TextBoxDisable;
            // 
            // middleYLabel
            // 
            middleYLabel.AutoSize = true;
            middleYLabel.Location = new Point(234, 202);
            middleYLabel.Name = "middleYLabel";
            middleYLabel.Size = new Size(57, 15);
            middleYLabel.TabIndex = 11;
            middleYLabel.Text = "Middle Y:";
            // 
            // middleXLabel
            // 
            middleXLabel.AutoSize = true;
            middleXLabel.Location = new Point(234, 154);
            middleXLabel.Name = "middleXLabel";
            middleXLabel.Size = new Size(57, 15);
            middleXLabel.TabIndex = 10;
            middleXLabel.Text = "Middle X:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(234, 249);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(20, 15);
            idLabel.TabIndex = 9;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(234, 267);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(100, 23);
            idTextBox.TabIndex = 8;
            idTextBox.KeyPress += TextBoxDisable;
            // 
            // buttonRectangle
            // 
            buttonRectangle.Location = new Point(234, 375);
            buttonRectangle.Name = "buttonRectangle";
            buttonRectangle.Size = new Size(100, 23);
            buttonRectangle.TabIndex = 7;
            buttonRectangle.Text = "Find";
            buttonRectangle.UseVisualStyleBackColor = true;
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Location = new Point(6, 19);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(222, 379);
            RectanglesListBox.TabIndex = 0;
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(234, 125);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(100, 23);
            textBoxColor.TabIndex = 3;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(234, 107);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(39, 15);
            labelColor.TabIndex = 6;
            labelColor.Text = "Color:";
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new Point(234, 37);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new Size(100, 23);
            textBoxLength.TabIndex = 1;
            textBoxLength.TextChanged += textBoxLength_TextChanged;
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Location = new Point(234, 63);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(42, 15);
            labelWidth.TabIndex = 5;
            labelWidth.Text = "Width:";
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(234, 81);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(100, 23);
            textBoxWidth.TabIndex = 2;
            textBoxWidth.TextChanged += textBoxWidth_TextChanged;
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(234, 19);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(47, 15);
            labelLength.TabIndex = 4;
            labelLength.Text = "Length:";
            // 
            // TabPageRectangles
            // 
            TabPageRectangles.Controls.Add(rectanglesCollisionControl1);
            TabPageRectangles.Location = new Point(4, 24);
            TabPageRectangles.Name = "TabPageRectangles";
            TabPageRectangles.Size = new Size(798, 538);
            TabPageRectangles.TabIndex = 2;
            TabPageRectangles.Text = "Rectangles";
            TabPageRectangles.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Location = new Point(0, 0);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(798, 538);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 566);
            Controls.Add(TabControl);
            Name = "MainForm";
            Text = "Main Form";
            TabControl.ResumeLayout(false);
            TabPageEnums.ResumeLayout(false);
            SeasonGroupBox.ResumeLayout(false);
            SeasonGroupBox.PerformLayout();
            EnumGroupBox.ResumeLayout(false);
            EnumGroupBox.PerformLayout();
            ParsingGroupBox.ResumeLayout(false);
            ParsingGroupBox.PerformLayout();
            TabPageClasses.ResumeLayout(false);
            groupBoxMovies.ResumeLayout(false);
            groupBoxMovies.PerformLayout();
            groupBoxRectangles.ResumeLayout(false);
            groupBoxRectangles.PerformLayout();
            TabPageRectangles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage TabPageEnums;
        private GroupBox EnumGroupBox;
        private Label EnumLabel;
        private ListBox EnumsListBox;
        private ListBox ValuesListBox;
        private Label ValueLabel;
        private Label IntLabel;
        private TextBox TextBoxValue;
        private GroupBox ParsingGroupBox;
        private Label ResultLabel;
        private Button ParseButton;
        private TextBox WeekdayTextBox;
        private Label ParsingLabel;
        private GroupBox SeasonGroupBox;
        private Button SeasonButton;
        private ComboBox SeasonComboBox;
        private Label SeasonLabel;
        private TabPage TabPageClasses;
        private TextBox textBoxColor;
        private TextBox textBoxWidth;
        private GroupBox groupBoxRectangles;
        private Label labelColor;
        private Label labelWidth;
        private Label labelLength;
        private Button buttonRectangle;
        private ListBox RectanglesListBox;
        private TextBox textBoxLength;
        private GroupBox groupBoxMovies;
        private ListBox listBoxMovies;
        private Label labelReleaseYear;
        private Label labelDuration;
        private Label labelName;
        private Button buttonMovies;
        private TextBox textBoxRating;
        private TextBox textBoxGenre;
        private TextBox textBoxYearRelease;
        private TextBox textBoxDuration;
        private TextBox textBoxName;
        private Label labelRating;
        private Label labelGenre;
        private Label idLabel;
        private TextBox idTextBox;
        private TextBox middleYTextBox;
        private TextBox middleXTextBox;
        private Label middleYLabel;
        private Label middleXLabel;
        private TabPage TabPageRectangles;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
    }
}