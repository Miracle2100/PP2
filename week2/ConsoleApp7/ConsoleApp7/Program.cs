using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStackExample
{
    class Program
    {

        static void showStackTree(string path)
        {
            Stack<DirectoryInfo> myS = new Stack<DirectoryInfo>();
            DirectoryInfo dir = new DirectoryInfo(path);
            myS.Push(dir);

            while (myS.Count > 0)
            {
                DirectoryInfo cur = myS.Pop();
                foreach (DirectoryInfo d in cur.GetDirectories())
                {
                    Console.WriteLine(d.Name);
                    myS.Push(d);
                }

                foreach (FileInfo f in cur.GetFiles())
                {
                    Console.WriteLine(f.Name);
                }
            }

        }


        static void Main(string[] args)
        {
            showStackTree(@"C:\test");

            

            Console.ReadKey();
        }
    }
}