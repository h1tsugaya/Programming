using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Статический класс для определения цветов приложения.
/// </summary>
static class AppColors
{
    /// <summary>
    /// Цвет по умолчанию.
    /// </summary>
    public static readonly System.Drawing.Color Default = System.Drawing.Color.White;

    /// <summary>
    /// Недопустимый цвет.
    /// </summary>
    public static readonly System.Drawing.Color Invalid = System.Drawing.Color.LightPink;

    /// <summary>
    /// Цвет опасности.
    /// </summary>
    public static readonly System.Drawing.Color Danger = System.Drawing.Color.FromArgb(127, 255, 127, 127);

    /// <summary>
    /// Цвет успешного действия.
    /// </summary>
    public static readonly System.Drawing.Color Success = System.Drawing.Color.FromArgb(127, 127, 255, 127);

    /// <summary>
    /// Осенний цвет.
    /// </summary>
    public static readonly System.Drawing.Color Autumn = ColorTranslator.FromHtml("#e29c45");

    /// <summary>
    /// Весенний цвет.
    /// </summary>
    public static readonly System.Drawing.Color Spring = ColorTranslator.FromHtml("#559c45");
}