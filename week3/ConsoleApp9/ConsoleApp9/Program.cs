using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFarManager
{
    class Program
    {

        static void showState(DirectoryInfo cur, int pos)
        {
            FileSystemInfo[] infos = cur.GetFileSystemInfos();

            for (int i = 0; i < infos.Length; i++)
            {
                if (i == pos)
                    Console.BackgroundColor = ConsoleColor.White;
                else
                    Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(infos[i].Name);
           
           
                
            }


        }

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int pos = 0;

            DirectoryInfo dir = new DirectoryInfo(@"C:\test");

            while (true)
            {
                Console.Clear();
                showState(dir, pos);

                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        pos--;
                        if (pos < 0)
                            pos = dir.GetFileSystemInfos().Length - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        pos++;
                        if (pos >= dir.GetFileSystemInfos().Length)
                            pos = 0;
                        break;
                    case ConsoleKey.Enter:
                        FileSystemInfo f = dir.GetFileSystemInfos()[pos];
                        if (f.GetType() == typeof(DirectoryInfo))
                        {
                            dir = new DirectoryInfo(f.FullName);
                            pos = 0;
                        }
                        else
                        {
                            FileStream t = new FileStream(f.FullName, FileMode.Open, FileAccess.Read);
                                StreamReader s = new StreamReader(t);
                            Console.Clear();
                            Console.WriteLine(s.ReadToEnd());
                            ConsoleKeyInfo knopka = Console.ReadKey();

                            while (knopka.Key != ConsoleKey.Q)
                            {
                                knopka = Console.ReadKey();
                            }
                        }
                        break;
                    case ConsoleKey.Escape:
                        dir = dir.Parent;
                        break;
                }
            }
        }
    }
}