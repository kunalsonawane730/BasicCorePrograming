using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class EvenorOdd
    {
        public void CheckEvenorOdd()
        {
            int number, remainder;
            Console.WriteLine("Enter number to check even or odd:");
            number = Convert.ToInt32(Console.ReadLine());
            remainder = number % 2;
            if (remainder == 0)
                Console.WriteLine("{0} is an even number:", number);
            else
                Console.WriteLine("{0} is an odd number:", number);
        }
    }
}
