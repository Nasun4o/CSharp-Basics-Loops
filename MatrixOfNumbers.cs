using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startSum;

            for (int i = 0; i < n; i++)
            {
                startSum = i + 1;
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", startSum);
                    startSum++;
                }
                Console.WriteLine();
            }
        }
    }
}
