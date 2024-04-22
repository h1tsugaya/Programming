using System.Drawing;
using System;
using ProjectProgramming;
using System.Windows.Forms;

static class RectangleFactory
{
    static Random _random = new Random();
    static public Rectangle Randomize(Panel PanelRectangles, int maxHeight, int maxWidth)
    {
        int height = _random.Next(15, maxHeight);
        int width = _random.Next(15, maxWidth);
        return new Rectangle(height, width, Color.Orange, new Point2D(_random.Next(16, PanelRectangles.Size.Width - 16 - maxWidth), _random.Next(16, PanelRectangles.Size.Height - 16 - maxHeight)));
    }
}