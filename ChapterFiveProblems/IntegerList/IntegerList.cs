using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegerList
{
    class IntegerList
    {
        static void Main(string[] args)
        {
            int[] integers = new int[5] { 5, 6, 7, 8, 9 };

            for (int i = 0; i < integers.Length; i++)
            {
                Array.Sort(integers);
                Array.Reverse(integers);
                Console.WriteLine("{0}", integers[i]);
                
            }
        }
    }
}
