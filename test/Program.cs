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
            }        }
    }
}
