using System;
using System.Drawing;

class Rectangle
{
    int _length;
    int _width;
    public Point2D Coordinates { get; set; }


    public Color Color { get; set; }

    static int _allRectanglesCount;
    readonly int _id;

    public int Length
    {
        get { return _length; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _length = value;
        }
    }
    public int Width
    {
        get { return _width; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _width = value;
        }
    }
    public Point2D Center => new Point2D(Coordinates.X + Width / 2, Coordinates.Y + Height / 2);

    public static int AllRectanglesCount
    {
        get { return _allRectanglesCount; }
    }
    public int Id
    {
        get { return _id; }
    }

    public Rectangle()
    {
        Length = 15;
        Width = 30;
        Color = Color.Green;
    }

    public Rectangle(int length, int width, Color color, Point2D coordinates)
    {
        Length = length;
        Width = width;
        Color = color;
        _id = ++_allRectanglesCount;
    }

    public override string ToString()
    {
        return $"{Id}: (X={Center.X}; Y={Center.Y}; W={Width}; H={Length})";
    }
}