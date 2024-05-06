using System;

namespace delegates
{
    internal class Program
    {
        delegate void LogDel(string text, DateTime datetime);

        static void Main(string[] args)
        {
            LogDel logdel = new LogDel(LogTextToScreen);

            Console.WriteLine("Name: ");
            var name = Console.ReadLine();

            logdel(name, DateTime.Now);
            Console.ReadKey();
        }

         static void LogTextToScreen(string text, DateTime datetime)
        {
            Console.WriteLine($"{datetime}: {text}");
        }
    }
}
