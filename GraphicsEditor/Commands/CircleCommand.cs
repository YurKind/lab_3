﻿using System;
using ConsoleUI;

namespace GraphicsEditor.Commands
{
    internal class CircleCommand : ICommand
    {
        Application app;
        Picture picture;

        public CircleCommand(Application app, Picture picture)
        {
            this.app = app;
            this.picture = picture;
        }

        public string Name
        {
            get
            {
                return "circle";
            }
        }

        public string Description
        {
            get
            {
                return "Чтобы нарисовать круг, введите: \n" +
                    "circle x y r\nгде x - координата центра по оси Ox, y - координата центра по оси Oy, r - радиус";
            }
        }

        public string Help
        {
            get
            {
                return "Рисование круга";
            }
        }

        public string[] Synonyms
        {
            get
            {
                return new string[] { "krug", "crcl" };
            }
        }

        public void Execute(params string[] parameters)
        {
            if (Circle.NumberOfParameters != parameters.Length)
            {
                Console.WriteLine($"Введено неверное число параметров, требуемое количество: {Circle.NumberOfParameters}");
                return;
            }

            float[] values = new float[Circle.NumberOfParameters];
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

            Circle circle = new Circle(values[0], values[1], values[2]);

            picture.Add(circle);
        }
    }
}