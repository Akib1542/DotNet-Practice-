using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProj
{
    internal interface GenericInterfaceCreate<T>
    {
        bool isEqual(T val1, T val2);
    }
}
