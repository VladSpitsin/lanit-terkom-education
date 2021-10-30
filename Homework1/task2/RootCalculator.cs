using System;

namespace task2
{
    public static class RootCalculator
    {
        public static void CalculateRoot()
        {
            //Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            int number = Int32.Parse(Console.ReadLine());
            double result;
            try 
            {
                result = Math.Sqrt(number);
                Console.WriteLine(result);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
