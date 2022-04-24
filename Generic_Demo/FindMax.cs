using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Demo
{
    internal class FindMax
    {
        public static int FindINTMax(int first, int second, int third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("First is having maximum value.");
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("Second is having maximum value.");
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(first) > 0)
            {
                Console.WriteLine("Third is having maximum value.");
                return third;
            }
            else
            {
                Console.WriteLine("Something Went Wrong.....");
                return 0;
            }
        }

        public static float FindFLOATMax(float first, float second, float third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("First is having maximum value.");
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("Second is having maximum value.");
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(first) > 0)
            {
                Console.WriteLine("Third is having maximum value.");
                return third;
            }
            else
            {
                Console.WriteLine("Something Went Wrong.....");
                return 0.00F;
            }
        }

        public static string FindStringMax(string first, string second, string third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("First is having maximum value.");
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("Second is having maximum value.");
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(first) > 0)
            {
                Console.WriteLine("Third is having maximum value.");
                return third;
            }
            else
            {
                Console.WriteLine("Something Went Wrong.....");
                return null;
            }
        }
    }
}
