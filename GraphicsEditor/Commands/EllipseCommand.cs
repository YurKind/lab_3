﻿using System;
using ConsoleUI;

namespace GraphicsEditor.Commands
{
    internal class EllipseCommand : ICommand
    {
        private Application app;
        Picture picture;

        public EllipseCommand(Application app, Picture picture)
        {
            this.app = app;
            this.picture = picture;
        }

        public string Name
        {
            get
            {
                return "ellipse";
            }
        }

        public string Description
        {
            get
            {
                return "Чтобы нарисовать эллипс, введите: \n" +
                    "ellipse x y l1 l2 t\nгде x - координата центра по оси Ox, y - координата центра по оси Oy,\n"
                    + "    l1 - размер вертикальной оси эллипса, l2 - размер горизонтальной оси эллипса, t - угол поворота эллипса";
            }
        }

        public string Help
        {
            get
            {
                return "Рисование эллипса";
            }
        }

        public string[] Synonyms
        {
            get
            {
                return new string[] { "ll", "elps" };
            }
        }

        public void Execute(params string[] parameters)
        {
            float[] values = new float[5];
            try
            {
                values = CommandProcessor.GetCommandValues(parameters, 5);
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
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            Ellipse elipse = new Ellipse(values[0], values[1], values[2], values[3], values[4]);

            picture.Add(elipse);
        }
    }
}