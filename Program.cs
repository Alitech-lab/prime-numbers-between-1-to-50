using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers_between_1_to_50
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool isPrime = true;
            Console.WriteLine("Prim Number:");
            for (int i = 2; i <= 50; i++)
            {
                for (int j = 2; j <= 50; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;

                    }

                }
                if (isPrime)
                {
                    Console.WriteLine("\t" + i);
                }
                isPrime = true;
            }
            Console.ReadKey();
        }
    }
}
