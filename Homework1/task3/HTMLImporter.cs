using System;
using System.Net.Http;

namespace task3
{
    public static class HTMLImporter
    {
        static readonly HttpClient client = new HttpClient();
        public static async void ImportHTML()
        {
            try
            {
                string responseBody = await client.GetStringAsync("https://yandex.ru");
                int n = 1000;
                while (n < responseBody.Length)
                {
                    string partBody = responseBody.Substring(n - 1000, n);
                    Console.WriteLine(partBody);
                    Console.WriteLine("Double-click on the \"Space bar\" to get the next fragment");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Spacebar)
                    {
                        n += 1000;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine("The page ended");
            }
            catch (HttpRequestException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
