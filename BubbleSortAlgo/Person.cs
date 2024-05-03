using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortAlgo
{
    internal class Person : IComparable<Person>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(Person? other)
        {
            return this.Name.CompareTo(other.Name);
        }

        /*
        public int CompareTo(object? obj)
        {
            return this.Id.CompareTo(((Person)obj).Id);
        }

        */


        public override string ToString()
        {
            return $"{Id} {Name}";
        }


    }
}
