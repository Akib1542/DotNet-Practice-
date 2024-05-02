using test.Math;
using static test.practice;

namespace test
{
    internal class Program
    {

        static void Main(string[] args)
        {
			try
			{
               
                var number = "12345";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
                Console.WriteLine("Hello, We are not in try catch!");

            }
            catch (Exception)
			{
                Console.WriteLine("The number could never be converted to a byte!");
            }

            person name = new person();
            name.firstName = "Ali Haider";
            name.lastName = "Akib";
            name.Introduce();


            Calculator c1 = new Calculator();
            double first, second;

            first= double.Parse(Console.ReadLine());
            char experssion = char.Parse(Console.ReadLine());
            second = double.Parse(Console.ReadLine());


            switch(experssion)
            {
                case '+':
                    Console.WriteLine(c1.Add(first, second));
                    break;

                case '-':
                    Console.WriteLine(c1.Substract(first, second));
                    break;

                case '*':
                    Console.WriteLine(c1.Multiply(first, second));
                    break;

                case '/':
                    Console.WriteLine(c1.Division(first, second));
                    break;

                default:
                    Console.WriteLine("Invalid day of experssion");
                    break;

            }


            genericPractice example = new genericPractice();

            // Calling the generic method with different data types
            int maxInt = example.Max(5, 10);
            double maxDouble = example.Max(3.5, 7.8);
            string maxString = example.Max("apple", "orange");

            Console.WriteLine($"Max int: {maxInt}");
            Console.WriteLine($"Max double: {maxDouble}");
            Console.WriteLine($"Max string: {maxString}");



        }
    }



}
