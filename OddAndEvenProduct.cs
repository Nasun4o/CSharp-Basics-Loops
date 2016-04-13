﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            string[] userInput = Console.ReadLine().Split(' ');
            int[] nums = new int[userInput.Length];
            int oddProduct = 1;
            int evenProduct = 1;
            int index = 1;
            for (int i = 0; i < userInput.Length; i++)
            {
                nums[i] = int.Parse(userInput[i]);
                if (index % 2 == 1)
                {
                    oddProduct *= nums[i];
                }
                else
                {
                    evenProduct *= nums[i];
                }
                index++;
            }
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes\r\nproduct = {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("no\r\nodd_product = {0}\r\neven_product = {1}", oddProduct, evenProduct);
            }
        }
    }
}