using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Demo
{
    internal class PrintArray
    {
        public static void PrintArray_Elements(int[] arr)
        {
            foreach(int element in arr)
            {
                Console.WriteLine(element);
            }
        }
        public static void PrintArray_Elements(double[] arr)
        {
            foreach(double element in arr)
            {
                Console.WriteLine(element);
            }
        }

        public static void PrintArray_ele(params int[] arr)
        {
            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }
        }

        public static void Print_Array(char[] arr)
        {
            foreach(char element in arr)
            {
                Console.WriteLine((char)element);
            }
        }

    }
}
