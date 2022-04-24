using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Demo
{
    internal class FindMaxbyArrSort<T>
    {
        public T[] values;
        public FindMaxbyArrSort(T[] values)
        {
            this.values = values;
        }

        public T[] SortArray()
        {
            Array.Sort(this.values);
            return values;
        }

        public T FindMaxValue()
        {
            SortArray();
            int LastIndex = values.Length - 1;
            return values[LastIndex];
        }

        public void PrintMax()
        {
            var max = FindMaxValue();
            Console.WriteLine("Max Value = "+max);
        }
    }
}
