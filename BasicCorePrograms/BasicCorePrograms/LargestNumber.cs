﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LargestNumber
    {
        public void FindLargestNumber()
        {
            int a, b, c;
            Console.WriteLine("largest among three numbers:");
            //reading inputs
            Console.WriteLine("Enter value for a :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for c:");
            c = Convert.ToInt32(Console.ReadLine());

            //finding largest among three numbers
            if ((a > b) && (a > c))
            {
                Console.WriteLine("{0} is largest number", a);
            }
            else if ((b > a) && (b > c))
            {
                Console.WriteLine("{0} is largest number", b);
            }
            else if ((c > a) && (c > b))
            {
                Console.WriteLine("{0} is largest number", c);
            }
            else
                Console.WriteLine("{0} is constat number", a, b, c);
            {

            }
            }
        }
}
