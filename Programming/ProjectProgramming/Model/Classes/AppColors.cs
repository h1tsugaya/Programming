using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class AppColors
{
    public static readonly System.Drawing.Color Default = System.Drawing.Color.White;
    public static readonly System.Drawing.Color Invalid = System.Drawing.Color.LightPink;
    public static readonly System.Drawing.Color Danger = System.Drawing.Color.FromArgb(127, 255, 127, 127);
    public static readonly System.Drawing.Color Success = System.Drawing.Color.FromArgb(127, 127, 255, 127);
    public static readonly System.Drawing.Color Autumn = ColorTranslator.FromHtml("#e29c45");
    public static readonly System.Drawing.Color Spring = ColorTranslator.FromHtml("#559c45");
}