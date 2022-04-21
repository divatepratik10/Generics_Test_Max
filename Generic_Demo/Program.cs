using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic Method Programme.");
            Console.WriteLine("Enter Size of Array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int [] intarr = new int[size];
            Console.WriteLine("Enter Array Elements : ");
            for(int i = 0;i<size;i++)
            {
                intarr[i] = Convert.ToInt32(Console.ReadLine());
            }
            double[] doublearr = { 11.22, 33.21, 43.42 };
            char[] chararr = { 'a', 'b', 'c', 'd', 'e', };
            PrintArray.PrintArray_Elements(intarr);
            Console.WriteLine("\n");
            PrintArray.PrintArray_Elements(doublearr);
            Console.WriteLine("\n");
            PrintArray.PrintArray_ele(10);
            Console.WriteLine("\n");
            PrintArray.PrintArray_ele(20,30);
            Console.WriteLine("\n");
            PrintArray.PrintArray_ele(40,50,60);
            Console.WriteLine("\n");
            PrintArray.Print_Array(chararr);
            Console.ReadLine();
        }
    }
}
