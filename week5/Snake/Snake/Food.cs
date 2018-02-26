using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
namespace Snake
{
    [Serializable]
    class Food
    {
        public char sign;
        public ConsoleColor color;
        public Point loc;
    
        public Food()
        {
           int x = 3;

            sign = (char)x;
            color = ConsoleColor.Red;
            setrandompos();
        }
        public void setrandompos()
        {
            int x = new Random().Next(0, 59);
            int y = new Random().Next(0, 29);
            loc = new Point(x, y);
            
        }
        public void draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(loc.x, loc.y);

            Console.Write(sign);

        }
       
        public bool Isonthewall( Wall w)
        {
            for (int i = 1; i < w.body.Count; i++)
                if (loc.x == w.body[i].x && loc.y == w.body[i].y)
                    return false;
            return true;
        }
        public bool IsontheSnake(Snake s)
        {
            for (int i = 1; i < s.body.Count; i++)
                if (loc.x == s.body[i].x && loc.y == s.body[i].y)
                    return false;
            return true;
        }
        public void Process(Wall wall)
        {
            int a = Program.score;
            int aa = Wall.level;
            string ss = "LEVEL " + aa;
           
            Console.SetCursorPosition(65, 3);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(ss);


            Console.SetCursorPosition(32, 32);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("ENTER- new game");
            Console.SetCursorPosition(32, 33);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Q- quit the game");
        }
    }
}
