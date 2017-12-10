using ConsoleUI;
using System;

namespace GraphicsEditor.Commands
{
    class PointCommand : ICommand
    {
        Application app;
        Picture picture;

        public PointCommand(Application app, Picture picture)
        {
            this.app = app;
            this.picture = picture;
        }

        public string Name { get { return "point"; } }

        public string Description
        {
            get
            {
                return "Чтобы нарисовать точку, введите: \n" + 
                    "point x y \nгде x - координата по оси Ox, y - координата по оси Oy";
            }
        }

        public string Help
        {
            get
            {
                return "Рисование точки";
            }
        }


        public string[] Synonyms
        {
            get
            {
                return new string[] { "tochka", "pnt", "точка" };
            }
        }

        public void Execute(params string[] parameters)
        {
            int numberOfParameters = 2;

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

            Point point = new Point(values[0], values[1]);

            picture.Add(point);
        }
    }
}
