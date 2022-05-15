using System;
using System.Collections.Generic;
using System.Text;

namespace FlipCoin
{
    public class Program
    {
        static void Main()
        {
            int count = 0;
            int tails = 0;
            int heads = 0;
            while (count < 100)
            {
                Random random = new Random();
                int result = random.Next(0,2);
                if (result == 1)
                {
                    Console.WriteLine("Tails");
                    tails = tails+1;
                    count = count + 1;
                }
                else if (result == 0)
                {
                    Console.WriteLine("Heads");
                    heads = heads + 1;
                    count = count + 1;
                }
            }
            Console.WriteLine("Heads percentage =" + heads + ",Tails percentage =" + tails + ",Counts =" + count);
            Console.ReadLine();
        }
    }
}
