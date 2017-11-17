using System;
using ConsoleUI;
using DrawablesUI;
using GraphicsEditor.Commands;

namespace GraphicsEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var picture = new Picture();
            var ui = new DrawableGUI(picture);
            var app = new Application();

            app.AddCommand(new PointCommand(app, picture));
            app.AddCommand(new LineCommand(app, picture));
            app.AddCommand(new CircleCommand(app, picture));
            app.AddCommand(new EllipseCommand(app, picture));
            app.AddCommand(new RemoveCommand(app, picture));
            app.AddCommand(new ListCommand(app, picture));
            app.AddCommand(new ExplainCommand(app));
            app.AddCommand(new HelpCommand(app));
            app.AddCommand(new ExitCommand(app));

            picture.Changed += ui.Refresh;
            ui.Start();
            app.Run(Console.In);
            ui.Stop();
        }
    }
}
