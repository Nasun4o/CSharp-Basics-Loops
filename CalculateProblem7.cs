using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CalculateProblem7
{
    class CalculateProblem7
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int diff = n - k;
            BigInteger nFactorial = 1;
            BigInteger kFactorial = 1;
            BigInteger diffFactoriacl = 1;
            bool run = true;
            while (run)
            {
                if (n == 1)
                {
                    run = false;

                } 
                if (n > 1)
                {
                    nFactorial *= n;
                    n--;
                }
                if (k >1)
                {
                    kFactorial *= k;
                    k--;
                }
                if (diff > 1)
                {
                    diffFactoriacl *= diff;
                    diff--;
                }
            }
            Console.WriteLine("{0}", nFactorial / (kFactorial * diffFactoriacl));

        }
    }
}
