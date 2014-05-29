using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeliveryCharges
{
    class DeliveryCharges
    {
        static void Main(string[] args)
        {
            int[] zip = new int[10] { 18042, 56487, 54568, 69874, 88754, 65658, 64231, 32548, 75486, 25487 };
            double[] Price = new double[10] { 1.50, 2.46, 5.87, 6.87, 6.24, 3.54, 8.45, 4.23, 5.23, 7.45 };
            int index = -1;
            Console.Write("Enter one of the zip codes listed: ");
            String input = Console.ReadLine();
            int n = Convert.ToInt32(input);
            Console.WriteLine();

            for (int i = 0; i < zip.Length; i++)
            {
                if (n == zip[i])
                {
                    index++;
                    Console.WriteLine("The cost of your delivery is {0}", Price[i].ToString("C"));
                }
            }

            if (index == -1)
            {
                Console.WriteLine("The zip code you have entered is not valid");
            }
        }
    }
}
