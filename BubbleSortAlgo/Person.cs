using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortAlgo
{
    internal class Person : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(object? obj)
        {
            return this.Id.CompareTo(((Person)obj).Id);
        }


        public override string ToString()
        {
            return $"{Id} {Name}";
        }


    }
}
