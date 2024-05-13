namespace ProjectProgramming.View.Panels
{
    partial class RectanglesCollisionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
            labelHeightRectangle = new Label();
            labelWidthRectangle = new Label();
            labelY = new Label();
            labelX = new Label();
            labelId = new Label();
            textBoxRectangleHeight = new TextBox();
            textBoxRectangleWidth = new TextBox();
            textBoxRectangleY = new TextBox();
            textBoxRectangleX = new TextBox();
            textBoxRectangleId = new TextBox();
            labelSelectedRectangle = new Label();
            buttonDeleteRectangle = new Button();
            buttonAddRectanlge = new Button();
            listBoxForRectangles = new ListBox();
            labelRectangles = new Label();
            RectanglesPanel = new Panel();
            SuspendLayout();
            // 
            // labelHeightRectangle
            // 
            labelHeightRectangle.AutoSize = true;
            labelHeightRectangle.Location = new Point(11, 440);
            labelHeightRectangle.Name = "labelHeightRectangle";
            labelHeightRectangle.Size = new Size(46, 15);
            labelHeightRectangle.TabIndex = 31;
            labelHeightRectangle.Text = "Height:";
            // 
            // labelWidthRectangle
            // 
            labelWidthRectangle.AutoSize = true;
            labelWidthRectangle.Location = new Point(15, 411);
            labelWidthRectangle.Name = "labelWidthRectangle";
            labelWidthRectangle.Size = new Size(42, 15);
            labelWidthRectangle.TabIndex = 30;
            labelWidthRectangle.Text = "Width:";
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Location = new Point(40, 382);
            labelY.Name = "labelY";
            labelY.Size = new Size(17, 15);
            labelY.TabIndex = 29;
            labelY.Text = "Y:";
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(40, 353);
            labelX.Name = "labelX";
            labelX.Size = new Size(17, 15);
            labelX.TabIndex = 28;
            labelX.Text = "X:";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(37, 324);
            labelId.Name = "labelId";
            labelId.Size = new Size(20, 15);
            labelId.TabIndex = 27;
            labelId.Text = "Id:";
            // 
            // textBoxRectangleHeight
            // 
            textBoxRectangleHeight.Location = new Point(63, 437);
            textBoxRectangleHeight.Name = "textBoxRectangleHeight";
            textBoxRectangleHeight.Size = new Size(100, 23);
            textBoxRectangleHeight.TabIndex = 26;
            textBoxRectangleHeight.TextChanged += textBoxRectangleHeight_TextChanged;
            // 
            // textBoxRectangleWidth
            // 
            textBoxRectangleWidth.Location = new Point(63, 408);
            textBoxRectangleWidth.Name = "textBoxRectangleWidth";
            textBoxRectangleWidth.Size = new Size(100, 23);
            textBoxRectangleWidth.TabIndex = 25;
            textBoxRectangleWidth.TextChanged += textBoxRectangleWidth_TextChanged;
            // 
            // textBoxRectangleY
            // 
            textBoxRectangleY.Location = new Point(63, 379);
            textBoxRectangleY.Name = "textBoxRectangleY";
            textBoxRectangleY.Size = new Size(100, 23);
            textBoxRectangleY.TabIndex = 24;
            textBoxRectangleY.TextChanged += textBoxRectangleY_TextChanged;
            // 
            // textBoxRectangleX
            // 
            textBoxRectangleX.Location = new Point(63, 350);
            textBoxRectangleX.Name = "textBoxRectangleX";
            textBoxRectangleX.Size = new Size(100, 23);
            textBoxRectangleX.TabIndex = 23;
            textBoxRectangleX.TextChanged += textBoxRectangleX_TextChanged;
            // 
            // textBoxRectangleId
            // 
            textBoxRectangleId.Location = new Point(63, 321);
            textBoxRectangleId.Name = "textBoxRectangleId";
            textBoxRectangleId.Size = new Size(100, 23);
            textBoxRectangleId.TabIndex = 22;
            textBoxRectangleId.KeyPress += TextBoxDisable;
            // 
            // labelSelectedRectangle
            // 
            labelSelectedRectangle.AutoSize = true;
            labelSelectedRectangle.Location = new Point(9, 300);
            labelSelectedRectangle.Name = "labelSelectedRectangle";
            labelSelectedRectangle.Size = new Size(109, 15);
            labelSelectedRectangle.TabIndex = 21;
            labelSelectedRectangle.Text = "Selected Rectangle:";
            // 
            // buttonDeleteRectangle
            // 
            buttonDeleteRectangle.BackColor = System.Drawing.Color.White;
            buttonDeleteRectangle.FlatStyle = FlatStyle.Flat;
            buttonDeleteRectangle.ForeColor = SystemColors.Window;
            buttonDeleteRectangle.Image = Properties.Resources.deleteRectangle;
            buttonDeleteRectangle.Location = new Point(159, 244);
            buttonDeleteRectangle.Margin = new Padding(0);
            buttonDeleteRectangle.Name = "buttonDeleteRectangle";
            buttonDeleteRectangle.Size = new Size(57, 47);
            buttonDeleteRectangle.TabIndex = 20;
            buttonDeleteRectangle.UseVisualStyleBackColor = false;
            buttonDeleteRectangle.Click += buttonDeleteRectangle_Click;
            // 
            // buttonAddRectanlge
            // 
            buttonAddRectanlge.BackColor = System.Drawing.Color.White;
            buttonAddRectanlge.FlatStyle = FlatStyle.Flat;
            buttonAddRectanlge.ForeColor = SystemColors.Window;
            buttonAddRectanlge.Image = (Image)resources.GetObject("buttonAddRectanlge.Image");
            buttonAddRectanlge.Location = new Point(28, 244);
            buttonAddRectanlge.Margin = new Padding(0);
            buttonAddRectanlge.Name = "buttonAddRectanlge";
            buttonAddRectanlge.Size = new Size(57, 43);
            buttonAddRectanlge.TabIndex = 19;
            buttonAddRectanlge.UseVisualStyleBackColor = false;
            buttonAddRectanlge.Click += buttonAddRectanlge_Click;
            // 
            // listBoxForRectangles
            // 
            listBoxForRectangles.FormattingEnabled = true;
            listBoxForRectangles.ItemHeight = 15;
            listBoxForRectangles.Location = new Point(9, 54);
            listBoxForRectangles.Name = "listBoxForRectangles";
            listBoxForRectangles.Size = new Size(284, 184);
            listBoxForRectangles.TabIndex = 18;
            listBoxForRectangles.SelectedIndexChanged += listBoxForRectangles_SelectedIndexChanged;
            // 
            // labelRectangles
            // 
            labelRectangles.AutoSize = true;
            labelRectangles.Location = new Point(9, 36);
            labelRectangles.Name = "labelRectangles";
            labelRectangles.Size = new Size(67, 15);
            labelRectangles.TabIndex = 17;
            labelRectangles.Text = "Rectangles:";
            // 
            // RectanglesPanel
            // 
            RectanglesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RectanglesPanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglesPanel.Location = new Point(299, 25);
            RectanglesPanel.Name = "RectanglesPanel";
            RectanglesPanel.Size = new Size(490, 488);
            RectanglesPanel.TabIndex = 16;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelHeightRectangle);
            Controls.Add(labelWidthRectangle);
            Controls.Add(labelY);
            Controls.Add(labelX);
            Controls.Add(labelId);
            Controls.Add(textBoxRectangleHeight);
            Controls.Add(textBoxRectangleWidth);
            Controls.Add(textBoxRectangleY);
            Controls.Add(textBoxRectangleX);
            Controls.Add(textBoxRectangleId);
            Controls.Add(labelSelectedRectangle);
            Controls.Add(buttonDeleteRectangle);
            Controls.Add(buttonAddRectanlge);
            Controls.Add(listBoxForRectangles);
            Controls.Add(labelRectangles);
            Controls.Add(RectanglesPanel);
            Name = "RectanglesCollisionControl";
            Size = new Size(798, 538);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeightRectangle;
        private Label labelWidthRectangle;
        private Label labelY;
        private Label labelX;
        private Label labelId;
        private TextBox textBoxRectangleHeight;
        private TextBox textBoxRectangleWidth;
        private TextBox textBoxRectangleY;
        private TextBox textBoxRectangleX;
        private TextBox textBoxRectangleId;
        private Label labelSelectedRectangle;
        private Button buttonDeleteRectangle;
        private Button buttonAddRectanlge;
        private ListBox listBoxForRectangles;
        private Label labelRectangles;
        private Panel RectanglesPanel;
    }
}
