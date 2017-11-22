using DrawablesUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    class Line : IDrawable
    {
        PointF start = new PointF();
        PointF end = new PointF();

        public Line(float x1, float y1, float x2, float y2)
        {
            start.X = x1;
            start.Y = y1;
            end.X = x2;
            end.Y = y2;
        }

        public void Draw(IDrawer drawer)
        {
            drawer.DrawLine(start, end);
        }

        public override string ToString()
        {
            return $"Линия (Точка ({start.X}, {start.Y}), Точка ({end.X}, {end.Y}))";
        }
    }
}
