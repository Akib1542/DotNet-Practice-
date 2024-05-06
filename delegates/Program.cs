using System;

namespace delegates
{
    internal class Program
    {
        delegate void LogDel(string text, DateTime datetime);

        static void Main(string[] args)
        {
            Log log = new Log();

            LogDel logdel = new LogDel(log.LogTextToScreen) ;

            Console.WriteLine("Name: ");
            var name = Console.ReadLine();

            logdel(name, DateTime.Now);
            Console.ReadKey();
        }

       
    }

    public class Log()
    {
        public void LogTextToScreen(string text, DateTime datetime)
        {
            Console.WriteLine($"{datetime}: {text}");
        }
    }
}
