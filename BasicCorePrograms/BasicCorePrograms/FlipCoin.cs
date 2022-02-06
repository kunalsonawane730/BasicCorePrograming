using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class FlipCoin
    {
        public void FlipCoinPercentage()
        {
            int tailcount = 0;
            int headcount = 0;
            Console.WriteLine("Enter number to know how many times to flip coin");
            int numoftimes = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 1; i <= numoftimes; i++)
            {
                double randomvalue = random.NextDouble();
                if (randomvalue < 0.5)
                    tailcount++;
                else
                    headcount++;
            }
            Console.WriteLine("Number of tails is " + tailcount + " out of " + numoftimes);
            Console.WriteLine("Number of heads is " + headcount + " out of " + numoftimes);

            double tailPercent = (double)(tailcount * 100) / numoftimes;
            Console.WriteLine("Tails Percentage: " + tailPercent);
            double headPercent = (double)(headcount * 100) / numoftimes;
            Console.WriteLine("Heads Percentage: " + headPercent);
        }
    }
}
