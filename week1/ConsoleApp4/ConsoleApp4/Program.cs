
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    using static Math;
    class circle
    {
        double r, S, C, d;//radius , area , circumference , diameter
        public circle()
        {
            Console.WriteLine("Radius :");
            r = double.Parse(Console.ReadLine());
            S = PI * r * r;
            C = 2 * PI * r;
            d = 2 * r;
        }
        public override string ToString()
        {
            return "Area :" + S + "\n" + "Circumference :" + C + "\n" + "diameter :" + d;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            circle Solution = new circle();
            Console.WriteLine(Solution);
            Console.ReadKey();
        }
    }
}


