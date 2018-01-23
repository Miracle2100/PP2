using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class pr1
    {

        public string name;
        public string lastname;
        public double GPA;
        public pr1()
        {
            name = "Rustem";
            lastname = "Kaipzhan";
            GPA = 4;
     

        }
        public pr1 ( string name , string lastname , double GPA)
        {
            this.name = name;
            this.lastname = lastname;
            this.GPA = GPA;



        }
        public override string ToString()
        {
            return "First name :" + name + "\n" + "Last name  :" + lastname + "\n" + "GPA        :" + GPA;

        }


    }
    class pr2
    {
        static void Main(string[] args)
        {
            pr1 Student = new pr1();
            pr1 Student1 = new pr1("KAIPZHAN","RUSTEM" , 4);
            Console.WriteLine(Student);
            Console.WriteLine(Student1);
            Console.ReadKey();

        }
    };

}
