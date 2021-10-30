using System;
using task1;
using task2;
using task3;

namespace Homework1
{
    class Program
    {
        delegate void method();
        static void Main(string[] args)
        {
            string[] items = { "Read data from a file", "Calculate the root of a number", "Get a page Yandex.ru", "Exit" };
            method[] methods = new method[] { FileReader.ReadFile, RootCalculator.CalculateRoot, HTMLImporter.ImportHTML, ConsoleMenu.Exit };
            ConsoleMenu menu = new ConsoleMenu(items);
            int menuResult;
            do
            {
                menuResult = menu.PrintMenu();
                methods[menuResult]();
                Console.WriteLine("Press \"Enter\" to continue");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    continue;
                }
            } while (menuResult != items.Length - 1);
        }
    }
}
