/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food1
    {
        public char sign1;
        public ConsoleColor color1;
        public Point loc1;
        public Food1()
        {
            int a = 1;
            sign1 = (char)a;
            color1 = ConsoleColor.DarkCyan;
            setrandompos1();
        }
        public void setrandompos1()
        {
            int x = new Random().Next(0, 59);
            int y = new Random().Next(0, 29);
            loc1 = new Point(x, y);

        }
        public void draw1()
        {
            Console.ForegroundColor = color1;
            Console.SetCursorPosition(loc1.x, loc1.y);
            Console.Write(sign1);
        }

        public bool Isonthewall1(Wall w)
        {
            for (int i = 1; i < w.body.Count; i++)
                if (loc1.x == w.body[i].x && loc1.y == w.body[i].y)
                    return false;
            return true;
        }
        public bool IsontheSnake1(Snake s)
        {
            for (int i = 1; i < s.body.Count; i++)
                if (loc1.x == s.body[i].x && loc1.y == s.body[i].y)
                    return false;
            return true;
        }
       public bool Isonthefood ( Food f)
        { 
           if ( loc1.x == f.loc.x && loc1.y == f.loc.y)
            {
                return true;
            }return false;
        }
    }
}
*/