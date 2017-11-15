using System;
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

        }
    }
}