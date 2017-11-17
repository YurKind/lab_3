using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    public static class CommandService
    {
        public static float[] GetCommandValues(string[] parameters, int numberOfParameters)
        {
            int possablyBadIndex = 0;
            float[] values = new float[numberOfParameters];

            try
            {
                if (parameters.Length != numberOfParameters)
                {
                    throw new IndexOutOfRangeException();
                }

                for (int i = 0; i < values.Length; i++)
                {
                    possablyBadIndex = i;
                    values[i] = float.Parse(parameters[i]);
                }

                if (values[0] < 0 || values[1] < 0)
                {
                    Console.WriteLine("Значения должны быть положительными");
                    throw new FormatException();
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
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException("Введено неверное число параметров. Требуемое число параметров: "
                    + numberOfParameters);
            }
            return values;
        }
    }
}
