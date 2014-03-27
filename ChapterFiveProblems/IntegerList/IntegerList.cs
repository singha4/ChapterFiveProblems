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
            int[] grades = new int[5];

            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(grades);
                
            }
        }
    }
}
