namespace GenericProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var ab = new GenericMerge<string>();

           
           Console.WriteLine(ab.isEqual("aa", "bb"));
            //Console.WriteLine(ab.isEqual(1, 2));
        }
    }
}
