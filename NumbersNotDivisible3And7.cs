using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumbersNotDivisible3And7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int num = 1;
        for (int i = 0; i < n; i++)
        {
            if ((num % 3 != 0) && (num % 7 != 0))
            {
                Console.Write(num);
                if (i < n - 1)
                {
                    Console.Write(" ");
                }
            }
            num++;
        }
        Console.WriteLine();
    }
}