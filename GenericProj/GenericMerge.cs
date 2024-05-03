using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProj
{
    internal class GenericMerge<T> : GenericInterfaceCreate<T> 
    {
        public bool isEqual(T val1, T val2)
        {
            return val1.Equals(val2);
        }

        public void print(List<T> list)
        {
            foreach (T val in list)
            {
                Console.WriteLine(val);
            }
        }
    }
}
