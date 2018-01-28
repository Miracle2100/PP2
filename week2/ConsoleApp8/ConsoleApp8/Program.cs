using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{class Complex
    {

        public int x, y;


        public Complex()
        {

            x = 1;
            y = 1;

        }
            public Complex(int a , int b)
        {
             x = a;
             y = b; 
          }
            
        public int GCD( int a , int b)
        {
            if (b == 0)
                return a;

            return GCD(b, a % b);

        }
        public void abbreviate( )
        {

            int d = GCD(x, y);
            x /= d;
            y /= d;

        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex n = new Complex();
            n.y = c1.y * c2.y;
            n.x = c1.x * n.y / c1.y + c2.x * n.y / c2.y;
        
            n.abbreviate();
            return n;


        }
        public override string ToString()
        {
            if (y == 1)
                return x+".0";
            else return x + "/" + y;
        }




    }
    class program
    {public static void Main(string[] args)
        {

            Complex a = new Complex(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Complex b = new Complex(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Complex n = a + b;
            Console.WriteLine(a + "+" + b + "=" + n);
            Console.ReadKey();

        }




    }





}