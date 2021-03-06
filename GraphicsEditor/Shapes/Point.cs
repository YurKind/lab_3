﻿using DrawablesUI;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace GraphicsEditor
{
    class Point : IDrawable
    {
        private PointF pointf = new PointF();

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