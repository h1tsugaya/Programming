using ProjectProgramming.Model;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace ProjectProgramming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void SeasonHandleControl_SeasonChanged(object sender, View.Panels.SeasonChangedEventArgs e)
        {
            SetBackColor(e.Season == Seasons.Autumn ? AppColors.Autumn : AppColors.Spring);
        }

        private void SetBackColor(System.Drawing.Color color)
        {
            EnumGroupBox.BackColor = color;
            ParsingGroupBox.BackColor = color;
            SeasonGroupBox.BackColor = color;
            this.BackColor = color;
        }

        private void TextBoxDisable(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}