using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace minmax
{

    class program
    {

        static void Main(string[] args)
        {
            FileStream newfile = new FileStream(@"C:\test\m.txt", FileMode.Open, FileAccess.Read);//100 , 345 , 444 , 222 , 623, 535 , 54
            StreamReader sd = new StreamReader(newfile);

            string af = sd.ReadLine();

            string[] num = af.Split(' ', ',');
            int max = int.Parse(num[0]);
            int min = int.Parse(num[0]);
            for (int i = 0; i < num.Length; i++)
            {
                 
                if (int.Parse(num[i]) > max)
                    max = int.Parse(num[i]);
                if (int.Parse(num[i]) < min)
                    min = int.Parse(num[i]);
            }
            Console.WriteLine($"min = {min}\nmax = {max}");//54 , 623 
            Console.ReadKey();

        }




        
    }
    }



