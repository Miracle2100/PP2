using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Snake
{
    [Serializable]
    class Wall
    {
        public static int level = 1;
        public static List<Point> body;
        public static  char sign;
        public static ConsoleColor color;
        public static Wall wall = new Wall();
        public  Wall()
        {
            int x = 5;

            sign = (char)x;
            color = ConsoleColor.Green;
            body = new List<Point>();
        }
       

        public void Level()
        {
            body.Clear();
            string path = string.Format(@"levels\level{0}.txt", level);
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            int i = 0;
            int row = 0;
            while (i < 20)
            {
                string line = sr.ReadLine();
                for (int col = 0; col < line.Length; col++)
                {
                    if (line[col] == '#')
                    {
                        body.Add(new Point(col, row));
                    }
                    if (line[col] == '=')
                        body.Add(new Point(col, row));
                   
                }
                i++;
                row++;
            }
        }
        public static void  draw()
        {
            Console.ForegroundColor = color;
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }


        }
        public void Scoremenu()
        {

            List<Point> score;
            score = new List<Point>();
            for (int j = 0; j < 13; j++)
            {
                score.Add(new Point(j, 32));
                score.Add(new Point(j, 34));
            }
            for (int j = 32; j < 35; j++)
                score.Add(new Point(13, j));

            int i = 0;
            foreach (Point p in score)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write('.');
                i++;
            }
        }
        public static void WallSAVE()
        {
            FileStream sw = new FileStream(@"C:\Snake\Snake\bin\Debug\levels\wsave.ser", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            try
            { bf.Serialize(sw, wall); }
            catch (Exception e)
            { Console.WriteLine(e.Message); }
            finally { sw.Close(); }
        }
        public static void WallRESUME()
        {
            FileStream fs = new FileStream(@"C:\Snake\Snake\bin\Debug\levels\wsave.ser", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                Wall s = bf.Deserialize(fs) as Wall;
                wall = s;
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
