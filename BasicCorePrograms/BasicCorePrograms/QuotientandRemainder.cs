using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class QuotientandRemainder
    {
        public void CalculateQuotientandRemainder()
        {
            Console.WriteLine("Enter number for Dividend:");
            int Dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number fir Divisor:");
            int Divisor = Convert.ToInt32(Console.ReadLine());
            int Quotient = Dividend / Divisor;
            int Remainder = Dividend % Divisor;
            Console.WriteLine("Quotient =" + Quotient);
            Console.WriteLine("Remainder =" + Remainder);
        }
    }
}
