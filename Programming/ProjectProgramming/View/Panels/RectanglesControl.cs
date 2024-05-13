using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectProgramming.View.Panels
{
    public partial class RectanglesControl : UserControl
    {
        List<Rectangle> _rectangles;
        Rectangle _currentRectangle;

        public RectanglesControl()
        {
            InitializeComponent();
            CustomMethods.TextBoxClassesRectangles = new TextBox[6] {   idTextBox,
                                                                        textBoxColor,
                                                                        textBoxWidth,
                                                                        textBoxLength,
                                                                        middleXTextBox,
                                                                        middleYTextBox };
        }
        private int FindItemWithMaxValue<T>(List<T> classList, Func<T, double> getValue) where T : class
        {
            if (classList.Count < 1) return -1;

            int index = 0;
            double maxValue = getValue(classList[0]);
            for (int i = 0; i < classList.Count; i++)
            {
                if (getValue(classList[i]) > maxValue)
                {
                    maxValue = getValue(classList[i]);
                    index = i;
                }
            }
            return index;
        }
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    if (ListBoxClassesRectangles.SelectedItem == null) return;
            //    _currentRectangle = (Rectangle)ListBoxClassesRectangles.SelectedItem;
            //    UpdateRectangleInfo(_currentRectangle, ListBoxClassesRectangles.SelectedIndex);
        }
        private void TextBoxClassesRectanglesColor_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;
            if (CustomMethods.TryGetEnumValue<Color>(textBoxColor.Text, out Color value))
            {
                _currentRectangle.Color = value;
                textBoxColor.BackColor = AppColors.Default;
            }
            else
            {
                textBoxColor.BackColor = AppColors.Invalid;
            }
        }

        private void textBoxLength_TextChanged(object sender, EventArgs e)
        {

            //TextBoxSizeRectangleHandler(TextBoxClassesRectanglesLength, "length");
        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {
            //TextBoxSizeRectangleHandler(TextBoxClassesRectanglesWidth, "width");
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindItemWithMaxValue(_rectangles, (rectangle) => rectangle.Width);
        }
        private void TextBoxDisable(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
