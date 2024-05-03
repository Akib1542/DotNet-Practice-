namespace GenericProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var ab = new GenericMerge<int>();


            // Console.WriteLine(ab.isEqual("aa", "bb"));
            //Console.WriteLine(ab.isEqual(1, 2));
            // ab.print(new List<string> { "aa", "bb", "vv", "cc" });

            Console.WriteLine(ab.isEqual(1, 2));
            ab.print(new List<int> { 333, 334, 444, 666 });
        }
    }
}
