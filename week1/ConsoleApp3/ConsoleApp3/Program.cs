

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            if (p < 2)
            {
                Console.WriteLine(p + " is not prime");
                Console.ReadKey();
            }
            else
            {
                bool isprime = true;
                for (int i = 2; i <= Math.Sqrt(p); i++)
                    if (p % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                if (isprime)
                {
                    Console.WriteLine(p + " is prime ");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(p + " is not prime");
                    Console.ReadKey();
                }

            }

        }
    }
}
