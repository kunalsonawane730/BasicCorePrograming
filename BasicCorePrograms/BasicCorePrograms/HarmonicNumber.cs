using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class HarmonicNumber
    {
        public void FindHarmonicNumber()
        {
            Console.WriteLine("Enter number of terms");
            int num = Convert.ToInt32(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("1/{0} +", i);
                sum += 1 / i;
            }
            Console.WriteLine("\nThe sum of the series is {0}", sum);
        }
    }
}
