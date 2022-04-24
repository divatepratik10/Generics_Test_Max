using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Demo
{
    internal class GenericFindMax <T> where T : IComparable
    {
        public T first, second, third;
        public GenericFindMax(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public static T FindTMax(T first, T second, T third)
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
                return default;
            }
        }

        public void TestMaximum()
        {
            T MaxValua = FindTMax(first, second, third);
            Console.WriteLine("Max Value : " +MaxValua);
        }
    }
}
