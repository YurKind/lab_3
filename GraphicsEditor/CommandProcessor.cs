using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    public static class CommandProcessor
    {
        public static float[] GetCommandValues(string[] parameters)
        {
            float[] values = new float[parameters.Length];

            for (int i = 0; i < values.Length; i++)
            {
                try
                {
                    values[i] = float.Parse(parameters[i]);
                }
                catch (FormatException)
                {
                    throw new FormatException("Значение: " + parameters[i] + " введено некорректно");
                }
                catch (OverflowException)
                {
                    throw new OverflowException("Значение: " + parameters[i] + " слишком велико");
                }
            }

            return values;
        }
    }
}
