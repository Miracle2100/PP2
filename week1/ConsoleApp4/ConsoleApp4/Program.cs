using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class Circle
    {
        public int radius;
        public double area;
        public int diametr;
        public double length;


        public Circle()
        {
            radius = 2;
        }
        public Circle(int R)
        {
            radius = R;
        }
        public void findArea()
        {
            area = 3.14 * radius * radius;
        }
        public void findLength()
        {
            length = 2 * 3.14 * radius;
        }
        public void findDiametr()
        {
            diametr = 2 * radius;
        }
        public override string ToString()
        {
            return radius + "\n" + area + "\n" + length + "\n" + diametr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle s = new Circle(int.Parse(Console.ReadLine()));
            s.findArea();
            s.findLength();
            s.findDiametr();

            Console.WriteLine(s);

            Console.ReadKey();

        }
    }
}