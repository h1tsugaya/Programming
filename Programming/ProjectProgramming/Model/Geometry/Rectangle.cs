using System;
using System.Drawing;

class Rectangle
{
    int _height;
    int _width;
    public Point2D Coordinates { get; set; }

    public Color Color { get; set; }

    static int _allRectanglesCount;
    readonly int _id;

    public int Height
    {
        get { return _height; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _height = value;
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
        Height = 15;
        Width = 30;
        Color = Color.Green;
        Coordinates = new Point2D(10, 10);
        _id = ++_allRectanglesCount;
    }

    public Rectangle(int height, int width, Color color, Point2D coordinates)
    {
        Height = height;
        Width = width;
        Color = color;
        Coordinates = coordinates;
        _id = ++_allRectanglesCount;
    }

    public override string ToString()
    {
        return $"{Id}: (X={Center.X}; Y={Center.Y}; W={Width}; H={Height})";
    }
}