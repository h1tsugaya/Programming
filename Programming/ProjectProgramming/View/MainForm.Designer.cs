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
            seasonHandleControl1 = new View.Panels.SeasonHandleControl();
            EnumGroupBox = new GroupBox();
            enumerationsControl1 = new View.Panels.EnumerationsControl();
            ParsingGroupBox = new GroupBox();
            weekdayParsingControl1 = new View.Panels.WeekdayParsingControl();
            TabPageClasses = new TabPage();
            groupBoxMovies = new GroupBox();
            groupBoxRectangles = new GroupBox();
            rectanglesControl1 = new View.Panels.RectanglesControl();
            TabPageRectangles = new TabPage();
            rectanglesCollisionControl1 = new View.Panels.RectanglesCollisionControl();
            moviesControl1 = new View.Panels.MoviesControl();
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
            SeasonGroupBox.Controls.Add(seasonHandleControl1);
            SeasonGroupBox.Location = new Point(329, 278);
            SeasonGroupBox.Name = "SeasonGroupBox";
            SeasonGroupBox.Size = new Size(433, 134);
            SeasonGroupBox.TabIndex = 2;
            SeasonGroupBox.TabStop = false;
            SeasonGroupBox.Text = "Season Handle";
            // 
            // seasonHandleControl1
            // 
            seasonHandleControl1.Location = new Point(6, 22);
            seasonHandleControl1.Name = "seasonHandleControl1";
            seasonHandleControl1.Size = new Size(433, 122);
            seasonHandleControl1.TabIndex = 0;
            seasonHandleControl1.SeasonChanged += SeasonHandleControl_SeasonChanged;
            // 
            // EnumGroupBox
            // 
            EnumGroupBox.Controls.Add(enumerationsControl1);
            EnumGroupBox.Location = new Point(6, 6);
            EnumGroupBox.Name = "EnumGroupBox";
            EnumGroupBox.Size = new Size(756, 266);
            EnumGroupBox.TabIndex = 0;
            EnumGroupBox.TabStop = false;
            EnumGroupBox.Text = "Enumerations";
            // 
            // enumerationsControl1
            // 
            enumerationsControl1.Location = new Point(2, 22);
            enumerationsControl1.Name = "enumerationsControl1";
            enumerationsControl1.Size = new Size(756, 238);
            enumerationsControl1.TabIndex = 0;
            // 
            // ParsingGroupBox
            // 
            ParsingGroupBox.Controls.Add(weekdayParsingControl1);
            ParsingGroupBox.Location = new Point(8, 278);
            ParsingGroupBox.Name = "ParsingGroupBox";
            ParsingGroupBox.Size = new Size(305, 134);
            ParsingGroupBox.TabIndex = 1;
            ParsingGroupBox.TabStop = false;
            ParsingGroupBox.Text = "WeekdayParsing";
            // 
            // weekdayParsingControl1
            // 
            weekdayParsingControl1.Location = new Point(6, 22);
            weekdayParsingControl1.Name = "weekdayParsingControl1";
            weekdayParsingControl1.Size = new Size(305, 122);
            weekdayParsingControl1.TabIndex = 0;
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
            groupBoxMovies.Controls.Add(moviesControl1);
            groupBoxMovies.Location = new Point(352, 3);
            groupBoxMovies.Name = "groupBoxMovies";
            groupBoxMovies.Size = new Size(410, 414);
            groupBoxMovies.TabIndex = 8;
            groupBoxMovies.TabStop = false;
            groupBoxMovies.Text = "Movies";
            // 
            // groupBoxRectangles
            // 
            groupBoxRectangles.Controls.Add(rectanglesControl1);
            groupBoxRectangles.Location = new Point(8, 3);
            groupBoxRectangles.Name = "groupBoxRectangles";
            groupBoxRectangles.Size = new Size(338, 414);
            groupBoxRectangles.TabIndex = 7;
            groupBoxRectangles.TabStop = false;
            groupBoxRectangles.Text = "Rectangles";
            // 
            // rectanglesControl1
            // 
            rectanglesControl1.Location = new Point(0, 0);
            rectanglesControl1.Name = "rectanglesControl1";
            rectanglesControl1.Size = new Size(338, 414);
            rectanglesControl1.TabIndex = 0;
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
            // moviesControl1
            // 
            moviesControl1.Location = new Point(-29, 0);
            moviesControl1.Name = "moviesControl1";
            moviesControl1.Size = new Size(410, 414);
            moviesControl1.TabIndex = 0;
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
            EnumGroupBox.ResumeLayout(false);
            ParsingGroupBox.ResumeLayout(false);
            TabPageClasses.ResumeLayout(false);
            groupBoxMovies.ResumeLayout(false);
            groupBoxRectangles.ResumeLayout(false);
            TabPageRectangles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage TabPageEnums;
        private GroupBox EnumGroupBox;
        private GroupBox ParsingGroupBox;
        private GroupBox SeasonGroupBox;
        private TabPage TabPageClasses;
        private GroupBox groupBoxRectangles;
        private GroupBox groupBoxMovies;
        private TabPage TabPageRectangles;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.WeekdayParsingControl weekdayParsingControl1;
        private View.Panels.SeasonHandleControl seasonHandleControl1;
        private View.Panels.EnumerationsControl enumerationsControl1;
        private View.Panels.RectanglesControl rectanglesControl1;
        private View.Panels.MoviesControl moviesControl1;
    }
}