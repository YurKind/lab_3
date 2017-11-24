using DrawablesUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    class Ellipse : IDrawable
    {
        private PointF center = new PointF();
        private SizeF size = new SizeF();
        private float rotateAngle;
        private const int numberOfParameters = 5;

        public static int NumberOfParameters
        {
            get { return numberOfParameters; }
        }

        public Ellipse(float x, float y, float width, float height, float rotateAngle)
        {
            center.X = x;
            center.Y = y;
            size.Width = width;
            size.Height = height;
            this.rotateAngle = rotateAngle;
        }

        public void Draw(IDrawer drawer)
        {
            drawer.DrawEllipseArc(center, size, rotate: rotateAngle);
        }

        public override string ToString()
        {
            return $"Эллипс(Точка ({center.X}, {center.Y})" +
                $" Высота = {size.Height}, Ширина = {size.Width}, Угол поворота = {rotateAngle})";
        }
    }
}
