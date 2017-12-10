using ConsoleUI;
using System;

namespace GraphicsEditor.Commands
{
    class LineCommand : ICommand
    {
        Application app;
        Picture picture;

        public LineCommand(Application app, Picture picture)
        {
            this.app = app;
            this.picture = picture;
        }


        public string Name
        {
            get
            {
                return "line";
            }
        }

        public string Description
        {
            get
            {
                return "Чтобы нарисовать отрезок, введите: \n" +
                    "line x1 y1 x2 y2\nгде x1 - координата начала отрезка по оси Ox, y1 - координата начала отрезка по оси Oy\n"
                    + "    x2 - координата конца отрезка по оси Ox, y2 - координата конца отрезка по оси Oy";
            }
        }

        public string Help
        {
            get
            {
                return "Рисование отрезка";
            }
        }

        public string[] Synonyms
        {
            get
            {
                return new string[] { "otrezok", "ln", "линия", "отрезок" };
            }
        }

        public void Execute(params string[] parameters)
        {
            int numberOfParameters = 4;

            if (numberOfParameters != parameters.Length)
            {
                Console.WriteLine($"Введено неверное число параметров, требуемое количество: {numberOfParameters}");
                return;
            }

            float[] values = new float[numberOfParameters];
            try
            {
                values = CommandProcessor.GetCommandValues(parameters);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            Line line = new Line(values[0], values[1], values[2], values[3]);

            picture.Add(line);
        }
    }
}
