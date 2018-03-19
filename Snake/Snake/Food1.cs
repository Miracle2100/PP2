using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
namespace Snake
{
    [Serializable]
    class BigFood


    {
        
        public static char sign;
        public static ConsoleColor color;
        public static Point loc;
        public static BigFood food = new BigFood();
        

    


        public BigFood()
        {
            int x = 1;

            sign = (char)x;
            color = ConsoleColor.DarkCyan;
            setrandompos();
        }
        public void setrandompos()
        {
                    int x = new Random().Next(0, 59);
                    int y = new Random().Next(0, 29);
                    loc = new Point(x, y);
            
                

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
        public bool Isonthefood()
        {
            if (loc.x == Food.loc.x && loc.y == Food.loc.y)
                return false;
            else return true;

        }
        public bool IsontheSnake()
        {
            for (int i = 1; i < Snake.body.Count; i++)
                if (loc.x == Snake.body[i].x && loc.y == Snake.body[i].y)
                    return false;
            return true;
        }
       
        public static void FoodSAVE()
        {
            FileStream fs = new FileStream(@"C:\Snake\Snake\bin\Debug\levels\f1save.ser", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                bf.Serialize(fs, food);

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
                ;
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
