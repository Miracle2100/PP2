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
        static bool isPrime(int n)
        {
            for (int j = 2; j < Math.Sqrt(n); j++)
            
                if (n % j == 0)
                    return false;
                    return true; 
            
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
            for (int i = 0; i < num.Length; i++)
            {

                if (min > int.Parse(num[i]) && isPrime(int.Parse(num[i])))
                    min = int.Parse(num[i]);
               
           
            }
            Console.WriteLine($"min prime num = {min}");//5
           
            FileStream fds  = new FileStream(@"C:\test\t.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fds);
            sw.WriteLine(min);
      
          
            sw.Close();
        }
          
    }
    
}
