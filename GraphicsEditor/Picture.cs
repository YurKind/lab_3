using System;
using System.Collections.Generic;
using DrawablesUI;

namespace GraphicsEditor
{
    public class Picture : IDrawable
    {
        public List<IDrawable> Shapes { get; } = new List<IDrawable>();
        private readonly object lockObject = new object();

        public event Action Changed;

        public void Remove(IDrawable shape)
        {
            lock (lockObject)
            {
                Shapes.Remove(shape);
            }
        }

        public void RemoveAt(int index)
        {
            lock (lockObject)
            {
                Shapes.RemoveAt(index);
                if (Changed != null)
                    Changed();
            }
        }

        public void Add(IDrawable shape)
        {
            lock (lockObject)
            {
                Shapes.Add(shape);
                if (Changed != null)
                    Changed();
            }
        }

        public void Add(int index, IDrawable shape)
        {
            lock (lockObject)
            {
                Shapes.Insert(index, shape);
                if (Changed != null)
                    Changed();
            }
        }

        public void Draw(IDrawer drawer)
        {
            lock (lockObject)
            {
                foreach (var shape in Shapes)
                {
                    shape.Draw(drawer);
                }
            }
        }
    }
}