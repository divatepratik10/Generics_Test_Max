using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Demo
{
    internal class GenericClassforArr<T>
    {
        public T[] arr;

        public GenericClassforArr(T[] arr)
        {
            this.arr = arr;
        }
        public void PrintArray_Elements()
        {
            foreach (var element in arr)
            {
                Console.WriteLine(element);
            }
        }
    }
}
