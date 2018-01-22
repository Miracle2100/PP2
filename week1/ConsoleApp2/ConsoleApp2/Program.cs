using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Rectangle
    {
        int w, h, S, P;//width , height , area , perimetre
        public Rectangle()
        {

            Console.WriteLine("Width :");
            w = int.Parse(Console.ReadLine());//4 , 3
            Console.WriteLine("Height:");
            h = int.Parse(Console.ReadLine());//5 , 2
            S = w * h;//20 , 6
            P = 2 * (w + h);//18 , 10
        }
        public override string ToString()
        {
            return "Area : " + S + " \n" + "Perimetre:" + P;
        }





    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle Solution = new Rectangle();
            Console.WriteLine(Solution);
            Console.ReadKey();
        }
    }

}


