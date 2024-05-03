using System.Collections;

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

            /*-----------------------------------------------*/

            Salaries salaries = new Salaries();

            //ArrayList salaryList = salaries.GetSalary();
            List<int> salaryList = salaries.GetSalary();

            Console.WriteLine(salaryList.Count);
            float salary;

            salary =salaryList[1];
            salary *= 2;

            Console.WriteLine(salary);


        }
    }

    public class Salaries
    {
        //ArrayList _salary = new ArrayList();

        public Salaries()
        {
            _salary.Add(12546);
            _salary.Add(23556);
            _salary.Add(54454);
        }
        List<int> _salary = new List<int> ();

        public List<int> GetSalary()
        {
            return _salary;
        }




    }
}
