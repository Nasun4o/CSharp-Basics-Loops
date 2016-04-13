using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbersGivenRange
{
    class RandomNumbersGivenRange
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            Random randomNum = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", randomNum.Next(min, max));
            }
            Console.WriteLine();
        }
    }
}
