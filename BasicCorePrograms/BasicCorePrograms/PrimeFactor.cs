using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PrimeFactor
    {
        public void FindPrimeFactor()
        {
            int number, b;
            Console.WriteLine("Enter the number to find prime factor:");
            number = Convert.ToInt32(Console.ReadLine());
            for (b = 1; b <= number; b++)
            {
                if (number % b == 0)
                {
                    Console.WriteLine("{0} is the prime factor of {1}", b, number);
                }
            }
        }
    }
}
