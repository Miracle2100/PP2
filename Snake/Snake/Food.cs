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
        public static char sign;
        public static ConsoleColor color;
        public static Point loc;
       
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

            if (Isonthewall() == false || IsontheSnake() == false)
            {
                setrandompos();

            }



        }
        public static void draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(loc.x, loc.y);

            Console.Write(sign);

        }
       
        public bool Isonthewall()
        {
            for (int i = 1; i < Wall.body.Count; i++)
                if (loc.x == Wall.body[i].x && loc.y == Wall.body[i].y)
                    return false;
            return true;
        }
        public bool IsontheSnake()
        {
            for (int i = 1; i < Snake.body.Count; i++)
                if (loc.x == Snake.body[i].x && loc.y == Snake.body[i].y)
                    return false;
            return true;
        }
        public bool Isonthefood()
        {
            if (loc.x == BigFood.loc.x && loc.y == BigFood.loc.y)
                return false;
            else return true;

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

        public void save()
        {
            FileStream fs = new FileStream(@"C:\Snake\Snake\bin\Debug\levels\fsave.ser", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                bf.Serialize(fs, this);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }

        }


        public static void FoodRESUME()
        {
            FileStream fs = new FileStream(@"C:\Snake\Snake\bin\Debug\levels\fsave.ser", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                Food s = bf.Deserialize(fs) as Food;
                food = s;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
