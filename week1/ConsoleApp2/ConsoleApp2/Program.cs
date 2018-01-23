using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Rectangle
        
    {
        public int width;
        public int height;
        public int area;
        public int perimeter;

      

        public Rectangle()
        {
            width = 3;
            height = 2;


        }
        public Rectangle(int h, int w)
        {
            width = w;
            height = h;
                 
        }
        public void Area()
        {


            area = width * height;
        }
        public void Perimeter()
        {


            perimeter = 2 * (width + height);
        }
        
        public override string ToString()
        {
            return "Area : " + area + " \n" + "Perimetre:" + perimeter;
        }   





    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());//height
            int b = int.Parse(Console.ReadLine());//width
            Rectangle solution = new Rectangle(a, b);
            solution.Area();
            solution.Perimeter();
            Console.WriteLine(solution);
            Console.ReadKey();
        }
    }

}


