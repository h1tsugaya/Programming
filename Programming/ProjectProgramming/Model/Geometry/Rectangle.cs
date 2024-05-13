using System;
using System.Drawing;

/// <summary>
/// Представляет прямоугольник.
/// </summary>
class Rectangle
{
    int _height;
    int _width;
    public Point2D Coordinates { get; set; }

    public Color Color { get; set; }

    static int _allRectanglesCount;
    readonly int _id;

    /// <summary>
    /// Получает высоту прямоугольника.
    /// </summary>
    public int Height
    {
        get { return _height; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _height = value;
        }
    }

    /// <summary>
    /// Получает ширину прямоугольника.
    /// </summary>
    public int Width
    {
        get { return _width; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _width = value;
        }
    }

    /// <summary>
    /// Получает координаты центра прямоугольника.
    /// </summary>
    public Point2D Center => new Point2D(Coordinates.X + Width / 2, Coordinates.Y + Height / 2);


    /// <summary>
    /// Получает общее количество прямоугольников.
    /// </summary>
    public static int AllRectanglesCount
    {
        get { return _allRectanglesCount; }
    }

    /// <summary>
    /// Получает идентификатор прямоугольника.
    /// </summary>
    public int Id
    {
        get { return _id; }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса Rectangle со значениями по умолчанию.
    /// </summary>
    public Rectangle()
    {
        Height = 15;
        Width = 30;
        Color = Color.Green;
        Coordinates = new Point2D(10, 10);
        _id = ++_allRectanglesCount;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса Rectangle с указанными параметрами.
    /// </summary>
    /// <param name="height">Высота прямоугольника.</param>
    /// <param name="width">Ширина прямоугольника.</param>
    /// <param name="color">Цвет прямоугольника.</param>
    /// <param name="coordinates">Координаты прямоугольника.</param>
    public Rectangle(int height, int width, Color color, Point2D coordinates)
    {
        Height = height;
        Width = width;
        Color = color;
        Coordinates = coordinates;
        _id = ++_allRectanglesCount;
    }

    /// <summary>
    /// Возвращает строковое представление прямоугольника.
    /// </summary>
    /// <returns>Строковое представление прямоугольника.</returns>
    public override string ToString()
    {
        return $"{Id}: (X={Center.X}; Y={Center.Y}; W={Width}; H={Height})";
    }
}