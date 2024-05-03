namespace BubbleSortAlgo
{
     class Program
    {
        static void Main(string[] args)
        {
            // Object[] ara = new object[] {4,35,67,2,3,7,3,7,8};
            // this code is only for the declared data types not for the derived data types
            // for derived data types we have to use generics 

            Object[] ara = new object[] {"pple","zapple","Apple","Banaana" };
            /*
            SortArray sortArr = new SortArray();

            sortArr.BubbleSort(ara);


            foreach (var obj in ara)
            {
                Console.WriteLine(obj);
            }
            */

            Person[] arr = new Person[]
            {
                new Person{ Id= 123, Name ="Rahim"},
                 new Person{ Id= 145, Name ="Karim"},
                  new Person{ Id=10 , Name ="Jalal"},
                   new Person{ Id= 23, Name ="Rafiq"},
            };
            // For derived comparison one must be use the IComparable interface! means generics

            SortArray<Person> sorAr = new SortArray<Person>();
            sorAr.BubbleSort(arr);

            foreach(var obj in arr)
            {
                Console.WriteLine(obj);
            }

            SortArray<Object> sss = new SortArray<Object>();

            sss.BubbleSort(ara);

            foreach (var obj in ara)
            {
                Console.WriteLine(obj);
            }

            // we achive this by system.object type
            // by this system.object type C# manage to inherit all those datatypes

            // Now achive same functionality by using generics !
            // and ofcourse generics is better than system.obj type procedure


        }
    }

   

}
