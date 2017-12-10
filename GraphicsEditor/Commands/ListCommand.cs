using ConsoleUI;
using System;

namespace GraphicsEditor.Commands
{
    class ListCommand : ICommand
    {
        Application app;
        Picture picture;

        public ListCommand(Application app, Picture picture)
        {
            this.app = app;
            this.picture = picture;
        }

        public string Name
        {
            get
            {
                return "list";
            }
        }

        public string Description
        {
            get
            {
                return "Выводит список всех фигур на рисунке (с указанием индекса и всех параметров)";
            }
        }

        public string Help
        {
            get
            {
                return "Вывод списка фигур";
            }
        }

        public string[] Synonyms
        {
            get
            {
                return new string[] { "ls", "lst", "лист", "список" };
            }
        }

        public void Execute(params string[] parameters)
        {
            if (picture.Length < 1)
            {
                Console.WriteLine("Список фигур пуст");

                return;
            }

            for (int i = 0; i < picture.Length; i++)
            {
                Console.WriteLine($"[{i}] {picture[i]}");
            }
        }
    }
}
