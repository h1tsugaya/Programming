namespace ProjectProgramming.View.Panels
{
    partial class MoviesControl
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
            SuspendLayout();
            // 
            // buttonMovies
            // 
            buttonMovies.Location = new Point(272, 372);
            buttonMovies.Name = "buttonMovies";
            buttonMovies.Size = new Size(100, 23);
            buttonMovies.TabIndex = 23;
            buttonMovies.Text = "Find";
            buttonMovies.UseVisualStyleBackColor = true;
            buttonMovies.TextChanged += buttonMovies_Click;
            buttonMovies.Click += buttonMovies_Click;
            // 
            // textBoxRating
            // 
            textBoxRating.Location = new Point(272, 217);
            textBoxRating.Name = "textBoxRating";
            textBoxRating.Size = new Size(100, 23);
            textBoxRating.TabIndex = 22;
            textBoxRating.TextChanged += textBoxRating_TextChanged;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(272, 173);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(100, 23);
            textBoxGenre.TabIndex = 21;
            textBoxGenre.TextChanged += textBoxGenre_TextChanged;
            // 
            // textBoxYearRelease
            // 
            textBoxYearRelease.Location = new Point(272, 125);
            textBoxYearRelease.Name = "textBoxYearRelease";
            textBoxYearRelease.Size = new Size(100, 23);
            textBoxYearRelease.TabIndex = 20;
            textBoxYearRelease.TextChanged += textBoxYearRelease_TextChanged;
            // 
            // textBoxDuration
            // 
            textBoxDuration.Location = new Point(272, 78);
            textBoxDuration.Name = "textBoxDuration";
            textBoxDuration.Size = new Size(100, 23);
            textBoxDuration.TabIndex = 19;
            textBoxDuration.TextChanged += textBoxDuration_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(272, 34);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 18;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // labelRating
            // 
            labelRating.AutoSize = true;
            labelRating.Location = new Point(272, 199);
            labelRating.Name = "labelRating";
            labelRating.Size = new Size(44, 15);
            labelRating.TabIndex = 17;
            labelRating.Text = "Rating:";
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(272, 151);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(41, 15);
            labelGenre.TabIndex = 16;
            labelGenre.Text = "Genre:";
            // 
            // labelReleaseYear
            // 
            labelReleaseYear.AutoSize = true;
            labelReleaseYear.Location = new Point(272, 104);
            labelReleaseYear.Name = "labelReleaseYear";
            labelReleaseYear.Size = new Size(71, 15);
            labelReleaseYear.TabIndex = 15;
            labelReleaseYear.Text = "Year release:";
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Location = new Point(272, 60);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(56, 15);
            labelDuration.TabIndex = 14;
            labelDuration.Text = "Duration:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(272, 16);
            labelName.Name = "labelName";
            labelName.Size = new Size(42, 15);
            labelName.TabIndex = 13;
            labelName.Text = "Name:";
            // 
            // listBoxMovies
            // 
            listBoxMovies.FormattingEnabled = true;
            listBoxMovies.ItemHeight = 15;
            listBoxMovies.Location = new Point(38, 19);
            listBoxMovies.Name = "listBoxMovies";
            listBoxMovies.Size = new Size(222, 379);
            listBoxMovies.TabIndex = 12;
            listBoxMovies.SelectedIndexChanged += listBoxMovies_SelectedIndexChanged;
            // 
            // MoviesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonMovies);
            Controls.Add(textBoxRating);
            Controls.Add(textBoxGenre);
            Controls.Add(textBoxYearRelease);
            Controls.Add(textBoxDuration);
            Controls.Add(textBoxName);
            Controls.Add(labelRating);
            Controls.Add(labelGenre);
            Controls.Add(labelReleaseYear);
            Controls.Add(labelDuration);
            Controls.Add(labelName);
            Controls.Add(listBoxMovies);
            Name = "MoviesControl";
            Size = new Size(410, 414);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMovies;
        private TextBox textBoxRating;
        private TextBox textBoxGenre;
        private TextBox textBoxYearRelease;
        private TextBox textBoxDuration;
        private TextBox textBoxName;
        private Label labelRating;
        private Label labelGenre;
        private Label labelReleaseYear;
        private Label labelDuration;
        private Label labelName;
        private ListBox listBoxMovies;
    }
}
