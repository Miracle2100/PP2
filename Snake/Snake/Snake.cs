﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Snake
{
    [Serializable]
    class Snake
    {
        public static  List<Point> body;
        public static char sign1, sign2;
        public static ConsoleColor color;
        public static Snake snake = new Snake();
        public Snake()
        {
            int x = 2;
            int y = 4;
            sign1 = (char)x;
            sign2 = (char)y;
            color = ConsoleColor.Cyan;
            body = new List<Point>();
            body.Add(new Point(14, 24));
            body.Add(new Point(15, 24));
            body.Add(new Point(16, 24));



        }
        public static void draw()
        {
            int i = 0;
            foreach(Point p in body)
            {if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(p.x, p.y);
                    Console.Write(sign1);
                }

                else
                {
                    Console.ForegroundColor = color;
                    Console.SetCursorPosition(p.x, p.y);
                    Console.Write(sign2);
                }
                i++;




            }



        }
        public  void  NewLevel()
        {

            for ( int i = 0; i <= body.Count - 1; i++)
            {
                body[i].x = 0;
                body[i].y = 0;
            }
            body[0].x = 1;
            body[0].y = 1;
        }

        public void Move(int dx, int dy)
        { 
            
                Console.SetCursorPosition(body[body.Count - 1].x, body[body.Count - 1].y);
                Console.Write(' ');
                for (int i = body.Count - 1; i > 0; i--)
                {
                    body[i].x = body[i - 1].x;
                    body[i].y = body[i - 1].y;



                }
                body[0].x = body[0].x + dx;
                body[0].y = body[0].y + dy;

            

        }
        public bool  Eat()
        {
            if (body[0].x == Food.loc.x & body[0].y == Food.loc.y)
            {
                body.Add(new Point(body[body.Count - 1].x, body[body.Count - 1].y));
                return true;
            }

                return false;

        }
        public bool Eat1()
        {
            if (body[0].x == BigFood.loc.x && body[0].y == BigFood.loc.y)
            {
                body.Add(new Point(body[body.Count - 1].x, body[body.Count - 1].y));
                body.Add(new Point(body[body.Count - 1].x, body[body.Count - 1].y));
                body.Add(new Point(body[body.Count - 1].x, body[body.Count - 1].y));

                return true;
            }
             return false;
        }
      /*  public bool Eat1(Food1 f)
        {
            if (body[0].x == f.loc1.x && body[0].y == f.loc1.y)
            {
                body.Add(new Point(body[body.Count - 1].x, body[body.Count - 1].y));
                return true;

            }
            else return false;
        }*/
        public bool D1()
        {  for ( int i = 0; i < Wall.body.Count; i++)
            {
                if (body[0].x == Wall.body[i].x && body[0].y == Wall.body[i].y)
                
                    
                    return false;
                
            }
            return true;

        }
        public bool D2()
        {
            for (int i = 1; i < body.Count; i++)
                if (body[0].x == body[i].x && body[0].y == body[i].y)
                
                   
                    return false; 
            return true;

        }
        public static void SnakeSAVE()
        {
            FileStream fs = new FileStream(@"C:\Snake\Snake\bin\Debug\levels\ssave.ser", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                bf.Serialize(fs, snake);

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

        public static void SnakeRESUME()
        {
            FileStream fs = new FileStream(@"C:\Snake\Snake\bin\Debug\levels\ssave.ser", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                Snake s = bf.Deserialize(fs) as Snake;
                snake = s;
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
