using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
   
            }
            Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3}", nums.Min() , nums.Max() , nums.Sum(), nums.Average());
        }
    }

