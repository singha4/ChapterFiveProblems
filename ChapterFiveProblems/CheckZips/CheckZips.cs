using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckZips
{
    class CheckZips
    {
        static void Main(string[] args)
        {
            int[] zips = new int[10] { 18041, 18042, 18043, 18044, 18045, 18046, 18047, 18048, 18049, 18050 };
            int checkzips;
            bool iszipcode = false;
            Console.WriteLine("Please enter a zip code");
            checkzips = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < zips.Length; ++i)
            {
                if (checkzips == zips[i])
                {
                    iszipcode = true;
                }
            }
            if (iszipcode == true)
            {
                Console.WriteLine("This zip code is correct");
            }
            else
            {
                Console.WriteLine("This zip code is wrong");
            }
        }
    }
}
