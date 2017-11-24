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
            int possablyBadIndex = 0;
            float[] values = new float[parameters.Length];

            try
            {
                for (int i = 0; i < values.Length; i++)
                {
                    possablyBadIndex = i;
                    values[i] = float.Parse(parameters[i]);

                    if (values[i] < 0)
                    {
                        Console.WriteLine("Значения должны быть положительными");
                        throw new FormatException();
                    }
                }
            }
            catch (FormatException)
            {
                throw new FormatException("Значение: " + parameters[possablyBadIndex] + " введено некорректно");
            }
            catch (OverflowException)
            {
                throw new OverflowException("Значение: " + parameters[possablyBadIndex] + " слишком велико");
            }
            return values;
        }
    }
}
