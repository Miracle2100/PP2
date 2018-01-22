using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class pr1
    {
        string yourname, yourlastname;
        double G;
        public pr1()
        {
            Console.WriteLine("Write your first name : ");
            yourname = Console.ReadLine();
            Console.WriteLine("Write your last name  : ");
            yourlastname = Console.ReadLine();
            Console.WriteLine("Write your GPA        : ");
            G = double.Parse(Console.ReadLine());
            Console.Clear();
        }
        public override string ToString()
        {
            return "First name :" + yourname + "\n" + "Last name  :" + yourlastname + "\n" + "GPA        :" + G;

        }


    }
    class pr2
    {
        static void Main(string[] args)
        {
            pr1 Student = new pr1();
            Console.WriteLine(Student);
            Console.ReadKey();

        }
    }

}
