using DrawablesUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    class Circle : Ellipse
    {
        private PointF center = new PointF();
        private float radius;
        private const int numberOfParameters = 3;

        public static new int NumberOfParameters
        {
            get { return numberOfParameters; }
        }

        public Circle(float x, float y, float radius) : base(x, y, radius * 2, radius * 2, rotateAngle: 0)
        {
            center.X = x;
            center.Y = y;
            this.radius = radius;
        }

        public override string ToString()
        {
            return $"Круг(Точка ({center.X}, {center.Y}), Радиус = {radius}";
        }
    }
}
