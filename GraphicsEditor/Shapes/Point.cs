using DrawablesUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    class Point : IDrawable
    {
        private PointF pointf = new PointF();
        private const int numberOfParameters = 2;

        public static int NumberOfParameters
        {
            get { return numberOfParameters; }
        }

        public Point(float x, float y)
        {
            pointf.X = x;
            pointf.Y = y;
        }

        public void Draw(IDrawer drawer)
        {
            drawer.DrawPoint(pointf);
        }

        public override string ToString()
        {
            return $"Точка ({pointf.X}, {pointf.Y})";
        }
    }
}