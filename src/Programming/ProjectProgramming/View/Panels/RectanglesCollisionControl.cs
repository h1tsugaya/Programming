using ProjectProgramming.Model;
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
    public partial class RectanglesCollisionControl : UserControl
    {
        bool _isProgrammaticChange = false;
        List<Rectangle> _intersecting = new List<Rectangle>();
        List<Panel> _rectanglePanels;
        List<Rectangle> _rectangles;
        Rectangle _currentRectangle;

        public RectanglesCollisionControl()
        {
            InitializeComponent();

            CustomMethods.TextBoxRectangles = new TextBox[5] { textBoxRectangleId,
                                                                textBoxRectangleWidth,
                                                                textBoxRectangleHeight,
                                                                textBoxRectangleX,
                                                                textBoxRectangleY };

            _rectangles = new List<Rectangle>();
            _rectanglePanels = new List<Panel>();
        }

        private void TextBoxDisable(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        void textBoxRectangleX_TextChanged(object sender, EventArgs e)
        {
            TextBoxCoordinatesHandler(textBoxRectangleX, "x");
        }
        void textBoxRectangleY_TextChanged(object sender, EventArgs e)
        {
            TextBoxCoordinatesHandler(textBoxRectangleY, "y");
        }
        void textBoxRectangleWidth_TextChanged(object sender, EventArgs e)
        {
            TextBoxSizeRectangleHandler(textBoxRectangleWidth, "width");
        }
        void textBoxRectangleHeight_TextChanged(object sender, EventArgs e)
        {
            TextBoxSizeRectangleHandler(textBoxRectangleHeight, "height");
        }

        private void buttonAddRectanlge_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = RectangleFactory.Randomize(RectanglesPanel, 150, 150);
            _rectangles.Add(rectangle);
            listBoxForRectangles.Items.Add(rectangle);
            Panel panel = InitialPanel(rectangle);
            panel.BackColor = AppColors.Success;
            _rectanglePanels.Add(panel);
            RectanglesPanel.Controls.Add(panel);
            FindCollisions(rectangle);
        }
        private void buttonDeleteRectangle_Click(object sender, EventArgs e)
        {
            if (listBoxForRectangles.SelectedItem == null && listBoxForRectangles.SelectedIndex == -1) return;
            Rectangle rectangle = (Rectangle)listBoxForRectangles.SelectedItem;
            int selectedIndex = listBoxForRectangles.SelectedIndex;
            _rectangles.Remove(rectangle);
            listBoxForRectangles.Items.Remove(rectangle);
            ClearRectangleInfo();
            _rectanglePanels.RemoveAt(selectedIndex);
            RectanglesPanel.Controls.RemoveAt(selectedIndex);
            FindCollisions(rectangle);
        }
        /// <summary>
        /// Resizing a rectangle
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="dimensionType">"width" or "height"</param>
        private void listBoxForRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxForRectangles.SelectedItem == null) return;
            _currentRectangle = (Rectangle)listBoxForRectangles.SelectedItem;
            UpdateRectangleInfo(_currentRectangle, listBoxForRectangles.SelectedIndex);
        }
        void TextBoxSizeRectangleHandler(TextBox textBox, string dimensionType)
        {
            if (_currentRectangle == null || _isProgrammaticChange) return;
            try
            {
                int value = int.Parse(textBox.Text);
                switch (dimensionType)
                {
                    case "width":
                        _currentRectangle.Width = value;
                        break;
                    case "height":
                        _currentRectangle.Height = value;
                        break;
                    default: throw new ArgumentException("Non-existent argument value.");
                }
                ListBoxSelectedRectangleUpdate();

                textBox.BackColor = AppColors.Default;
            }
            catch (Exception)
            {
                textBox.BackColor = AppColors.Invalid;
            }
        }
        /// <summary>
        /// Moving a rectangle
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="coordinateType">"x" or "y"</param>
        void TextBoxCoordinatesHandler(TextBox textBox, string coordinateType)
        {
            if (_currentRectangle == null || _isProgrammaticChange) return;
            try
            {
                int coordinate = int.Parse(textBox.Text);
                switch (coordinateType)
                {
                    case "x":
                        _currentRectangle.Coordinates = new Point2D(coordinate, _currentRectangle.Coordinates.Y);
                        break;
                    case "y":
                        _currentRectangle.Coordinates = new Point2D(_currentRectangle.Coordinates.X, coordinate);
                        break;
                    default: throw new ArgumentException("Non-existent argument value.");
                }
                ListBoxSelectedRectangleUpdate();
                textBox.BackColor = AppColors.Default;
            }
            catch (Exception)
            {
                textBox.BackColor = AppColors.Invalid;
            }
        }
        void ListBoxSelectedRectangleUpdate()
        {
            int indexRectangles = listBoxForRectangles.Items.IndexOf(_currentRectangle);
            listBoxForRectangles.Items.RemoveAt(indexRectangles);
            listBoxForRectangles.Items.Insert(indexRectangles, _currentRectangle);
            listBoxForRectangles.SelectedIndex = indexRectangles;
            Panel panel = InitialPanel(_currentRectangle);
            panel.BackColor = AppColors.Success;
            _rectanglePanels[indexRectangles] = panel;
            RectanglesPanel.Controls.Clear();
            RectanglesPanel.Controls.AddRange(_rectanglePanels.ToArray());
            FindCollisions(_currentRectangle);
        }

        void FindCollisions(Rectangle rectangle)
        {
            // Создаём копию списка, чтобы из-за изменения во время выполнения цикла, не появлялась ошибка
            List<Rectangle> intersecting = new List<Rectangle>(_intersecting);
            // Перебираем ранее пересекающиеся прямоугольники со всеми прямоугольниками,
            foreach (Rectangle e in intersecting)
            {
                if (listBoxForRectangles.Items.IndexOf(e) == -1) continue;
                bool isRemove = true;
                foreach (Rectangle r in _rectangles)
                {
                    if (e != r && CollisionManager.IsCollision(e, r))
                    {
                        isRemove = false;
                        break;
                    }
                }
                if (isRemove)
                {
                    _intersecting.Remove(e);
                    _rectanglePanels[listBoxForRectangles.Items.IndexOf(e)].BackColor = AppColors.Success;
                }
            }
            if (_intersecting.Contains(rectangle)) _intersecting.Remove(rectangle);
            if (!_rectangles.Contains(rectangle)) return;

            bool flag = false;
            foreach (Rectangle r in _rectangles)
            {
                if (rectangle != r && CollisionManager.IsCollision(rectangle, r))
                {
                    if (!_intersecting.Contains(r)) _intersecting.Add(r);
                    _rectanglePanels[listBoxForRectangles.Items.IndexOf(r)].BackColor = AppColors.Danger;
                    flag = true;
                }
            }
            if (flag)
            {
                _intersecting.Add(rectangle);
                _rectanglePanels[listBoxForRectangles.Items.IndexOf(rectangle)].BackColor = AppColors.Danger;
            }
        }
        void UpdateRectangleInfo(Rectangle rectangle, int selectedIndex)
        {
            _isProgrammaticChange = true;
            textBoxRectangleId.Text = rectangle.Id.ToString();
            textBoxRectangleX.Text = rectangle.Coordinates.X.ToString();
            textBoxRectangleY.Text = rectangle.Coordinates.Y.ToString();
            textBoxRectangleWidth.Text = rectangle.Width.ToString();
            textBoxRectangleHeight.Text = rectangle.Height.ToString();
            listBoxForRectangles.SelectedIndex = selectedIndex;
            _isProgrammaticChange = false;
        }
        Panel InitialPanel(Rectangle rectangle)
        {
            Panel panel = new Panel();
            panel.Location = new Point((int)rectangle.Coordinates.X, (int)rectangle.Coordinates.Y);
            panel.Width = rectangle.Width;
            panel.Height = rectangle.Height;
            return panel;
        }
        void ClearRectangleInfo()
        {
            foreach (TextBox tb in CustomMethods.TextBoxRectangles)
            {
                tb.Clear();
                tb.BackColor = AppColors.Default;
            }
        }
    }
}
