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
            Console.WriteLine("Enter choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            int[] intarrr = { 10, 34, 65 };
            double[] doublearr = { 11.22, 33.21, 43.42 };
            char[] chararr = { 'a', 'b', 'c', 'd', 'e', };
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Size of Array : ");
                    int size = Convert.ToInt32(Console.ReadLine());
                    int[] intarr = new int[size];
                    Console.WriteLine("Enter Array Elements : ");
                    for (int i = 0; i < size; i++)
                    {
                        intarr[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    PrintArray.PrintArray_Elements(intarr);
                    Console.WriteLine("\n");
                    PrintArray.PrintArray_Elements(intarrr);
                    Console.WriteLine("\n");
                    PrintArray.PrintArray_Elements(doublearr);
                    Console.WriteLine("\n");
                    PrintArray.PrintArray_ele(10);
                    Console.WriteLine("\n");
                    PrintArray.PrintArray_ele(20, 30);
                    Console.WriteLine("\n");
                    PrintArray.PrintArray_ele(40, 50, 60);
                    Console.WriteLine("\n");
                    PrintArray.Print_Array(chararr);
                    break;

                case 2:
                    GenericPrintArray.PrintArry_Elements<int>(intarrr);
                    GenericPrintArray.PrintArry_Elements<double>(doublearr);
                    GenericPrintArray.PrintArry_Elements<char>(chararr);  
                    break;

                case 3:
                    //new GenericClassforArr<int,string>(intarrr).PrintArray_Elements();
                    GenericClassforArr<int,string> intobj = new GenericClassforArr<int,string>(intarrr);
                    intobj.PrintArray_Elements();
                    intobj.Test("Tested");
                    //new GenericClassforArr<double>(doublearr).PrintArray_Elements(); 
                    //GenericClassforArr<char> charobj = new GenericClassforArr<char>(chararr);
                    //charobj.PrintArray_Elements();
                    break;

                case 4:
                    int x = 32, y = 73, z = 12;
                    Console.WriteLine("{0} is having max value, out of {1}, {2}, {3}.",FindMax.FindINTMax(x,y,z),x,y,z); 
                    break;

                
            } 
             
            Console.ReadLine();
        }
    }
}
