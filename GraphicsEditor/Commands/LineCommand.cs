using ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                return new string[] { "otrezok", "ln" };
            }
        }

        public void Execute(params string[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
