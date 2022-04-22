using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Demo
{
    internal class GenericPrintArray
    {
        public static void PrintArry_Elements<T>(T[] arr)
        {
            Console.WriteLine("Array elemnts are : ");
            foreach(var element in arr)
            {
                Console.WriteLine(element + " ");
            }
        }
    }
}
