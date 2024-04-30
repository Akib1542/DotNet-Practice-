namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var numeber = "1234";
                byte x = Convert.ToByte(numeber);
                Console.WriteLine(x);
                Console.WriteLine("Code run without exception!");


            }
            catch (Exception)
            {

                Console.WriteLine("The number could not be converted to a byte!");
            }
                    

        }
    }
}
