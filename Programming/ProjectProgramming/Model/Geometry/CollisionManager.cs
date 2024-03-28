using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Model
{
    static class CollisionManager
    {
        static public bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double differenceX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double halfLatitude = Math.Abs(rectangle1.Width + rectangle2.Width) / 2;
            double differenceY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            double halfLength = Math.Abs(rectangle1.Length + rectangle2.Length) / 2;
            return differenceX < halfLatitude && differenceY < halfLength;
        }

        static public bool IsCollision(Ring ring1, Ring ring2)
        {
            double hypotenuse = Math.Sqrt(Math.Pow(Math.Abs(ring1.Center.X - ring2.Center.X), 2) + Math.Pow(Math.Abs(ring1.Center.Y - ring2.Center.Y), 2));
            double sumOfExternalRadii = ring1.ExternalRadius + ring2.ExternalRadius;
            return hypotenuse < sumOfExternalRadii;
        }
    }
}
