using ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor.Commands
{
    class RemoveCommand : ICommand
    {
        Application app;
        Picture picture;

        public RemoveCommand(Application app, Picture picture)
        {
            this.app = app;
            this.picture = picture;
        }

        public string Name
        {
            get
            {
                return "remove";
            }
        }

        public string Description
        {
            get
            {
                return "Чтобы удалить нарисованную фигуру введите:\n"
                    + "remove x1, x2, ...\n"
                    + "где x1, x2 - индексы фигур";
            }
        }

        public string Help
        {
            get
            {
                return "Удаление нарисованных фигур";
            }
        }

        public string[] Synonyms
        {
            get
            {
                return new string[] { "rm", "delete" };
            }
        }

        public void Execute(params string[] parameters)
        {
            if (parameters.Length == 0)
            {
                Console.WriteLine("Для того, чтобы удалить фигуры, необходимо указать их идексы");
                return;
            }

            float[] values = new float[parameters.Length];
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

            Array.Sort(values);

            int possablyBadIndex = 0;
            try
            {
                for (int i = 0; i < values.Length; i++)
                {
                    possablyBadIndex = i;
                    picture.Shapes.RemoveAt((int)(values[i]) - i);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Фигуры с индексом " + values[possablyBadIndex] + " не существует");
                return;
            }
        }
    }
}
