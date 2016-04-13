using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string result = string.Empty;
            while (n >= 1)
            {
                int remainder = (int)(n % 2);
                n /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("{0}",result);
        }
    }
}
