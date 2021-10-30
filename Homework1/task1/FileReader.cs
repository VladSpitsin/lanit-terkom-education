using System;
using System.IO;

namespace task1
{
    public static class FileReader
    {
        public static void ReadFile()
        {
            //Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            string path = Console.ReadLine();
            string line;
            try 
            {
                using StreamReader sr = new StreamReader(path);
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
