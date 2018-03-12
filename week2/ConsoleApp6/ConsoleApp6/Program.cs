using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp6
{

    
    class Program
    {
        public static bool IsPrime(double  f)
        {  
            for ( int i = 2; i <= Math.Sqrt(f); i++)
            {
                if (f % i == 0)
                {
                    return false;
                   
                }
                return true;
            }

        }

        
        static void Main(string[] args)
        {
            FileStream f = new FileStream(@"C:\test\t.txt", FileMode.Open, FileAccess.Read);//45 11 7 57 84 100 5
            StreamReader d = new StreamReader(f);
           
            string s = d.ReadLine();
            f.Close();
            d.Close();
            string[] num = s.Split(' ');
            int min = int.Parse(num[0]);
            z
            Console.WriteLine($"min prime num = {min}");//5
           
            FileStream fds  = new FileStream(@"C:\test\t.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fds);
            sw.WriteLine(min);
      
          
            sw.Close();
        }
          
    }
    
}
