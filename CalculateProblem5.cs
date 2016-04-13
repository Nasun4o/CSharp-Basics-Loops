using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateProblem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            Decimal nFactorial = 1;
            Decimal s = 1;
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
                s += (nFactorial / (decimal)Math.Pow(x, i));
            }
            Console.WriteLine("{0:F5}", s);
        }
    }
}
