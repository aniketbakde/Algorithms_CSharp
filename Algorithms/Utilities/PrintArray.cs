using System;
using System.Collections.Generic;

namespace Algorithms.Utilities
{
    public class PrintArray<T>
    {
        public PrintArray(IEnumerable<T> array)
        {
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
