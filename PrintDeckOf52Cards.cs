using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDeckOf52Cards
{
    class PrintDeckOf52Cards
    {
        static void Main(string[] args)
        {
            string[] faces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            char[] suits = new char[] { '\u2663', '\u2666', '\u2665', '\u2660' };

            for (int i = 0; i < faces.Length; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    Console.WriteLine("{0}{1}", faces[i] , suits[j]);
             
                }
                Console.WriteLine();
            }
        }
    }
}
