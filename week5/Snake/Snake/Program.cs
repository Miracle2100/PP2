using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading  ;
using System.Runtime.Serialization.Formatters.Binary;
namespace Snake

{
    class Program
    {
        public static bool gameover = false;
        public static int direction = 2;

        internal static void snakeSAVE()
        {
            throw new NotImplementedException();
        }

        public static int speed = 100;
        public static Food food = new Food();
      //  public static Food1 food1 = new Food1();
        public static Snake snake = new Snake();
        public static Wall wall = new Wall();
        public static int score = 0;
        public static bool block1 = true;
        public static bool block2 = false;
        public static bool realgameover = false;
        public static void MoveSnakeThread()
        {
            while (true)
            {
                snake.draw();
                food.draw();
              //  food1.draw1();
                wall.draw();
                wall.Level();
                food.Process(wall);
                switch (direction)
                {
                    case 1:
                        snake.Move(0, -1);

                        break;
                    case 2:
                        snake.Move(0, 1);

                        break;
                    case 3:
                        snake.Move(1, 0);

                        break;
                    case 4:
                        snake.Move(-1, 0);

                        break;
                    case 5:
                        Console.Clear();
                        gameover = true;
                        Gameover();
                        break;
                    case 6:
                        snake.body.Clear();
                        snake = new Snake();
                        break;
                }



                wall.Scoremenu();
                if (snake.body[0].x < 0)
                    snake.body[0].x = 60;
                if (snake.body[0].x > 60)
                    snake.body[0].x = 0;
                if (snake.body[0].y < 0)
                    snake.body[0].y = 30;
                if (snake.body[0].y > 30)
                    snake.body[0].y = 0;
                Console.SetCursorPosition(0, 33);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Your Score: " + score);


                if (snake.Eat(food))
                {
                    food.setrandompos();
                    score += 1;
                    Console.SetCursorPosition(0, 33);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Your Score: " + score);

                    if (score == 3)
                    {
                        Console.Clear();
                        snake.NewLevel();
                        Wall.level++;
                        if (Wall.level > 2)
                        {
                            Wall.level = 1;
                            score = 0;
                        }


                    }
                }

        /*       if (snake.Eat1(food1))
                {
                    food1.setrandompos1();
                    score += 2;
                    Console.SetCursorPosition(0, 33);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Your Score: " + score);

                    if (score == 3)
                    {
                        Console.Clear();
                        snake.NewLevel();
                        Wall.level++;
                        if (Wall.level > 2)
                        {
                            Wall.level = 1;
                            score = 0;
                        }


                    }
                }*/
                if (food.Isonthewall(wall) == false || food.IsontheSnake(snake) == false)
                {
                    food.setrandompos();
                }
               /* if (food1.Isonthewall1(wall) == false || food1.IsontheSnake1(snake) == false)
                {
                    food1.setrandompos1();
                }
                */
                if (snake.D1(wall) == false || snake.D2() == false)
                {
             
                  
                    realgameover = true;
                    gameover = true;
                    Gameover();
                
                   
                }
               /* if (food1.Isonthefood(food))
                {
                    food.setrandompos();
                    food1.setrandompos1();
                }
                      */
              

                Thread.Sleep(speed);
            }
         

        }
        public static  void Gameover()
        {
           
            if (gameover)
            {

                Console.Clear();
                if (realgameover)
                {
                    Console.SetCursorPosition(14, 10);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("GGWP:)");

                }
                
                Console.SetCursorPosition(14, 13);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("USER NAME:");
                Console.SetCursorPosition(24, 13);
                string s = Console.ReadLine();
                StreamWriter ds = new StreamWriter(@"C:\Users\Аслан\source\repos\Snake\Snake\bin\Debug\levels\players points.txt",true);

                ds.WriteLine("USER:" + s + " and Score:" + score);
                ds.Close();
               


            }
        }
        public void SnakeSAVE()
        {
            FileStream fs = new FileStream(@"C:\Users\Аслан\source\repos\Snake\Snake\bin\Debug\levels\ssave.ser", FileMode.Create, FileAccess.Write);
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

        public void SnakeRESUME()
        {
            FileStream fs = new FileStream(@"C:\Users\Аслан\source\repos\Snake\Snake\bin\Debug\levels\ssave.ser", FileMode.Create, FileAccess.Read);
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
        public void WallSAVE()
        {
            FileStream sw = new FileStream(@"C:\Users\Аслан\source\repos\Snake\Snake\bin\Debug\levels\wsave.ser", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            try
            { bf.Serialize(sw, wall); }
            catch (Exception e)
            { Console.WriteLine(e.Message); }
            finally { sw.Close(); }
        }
        public void WallRESUME()
        {
            FileStream fs = new FileStream(@"C:\Users\Аслан\source\repos\Snake\Snake\bin\Debug\levels\wsave.ser", FileMode.Open, FileAccess.Read);
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
        public void FoodSAVE(Food food )
        {
            FileStream fs = new FileStream(@"C:\Users\Аслан\source\repos\Snake\Snake\bin\Debug\levels\fsave.ser", FileMode.Create, FileAccess.Write);
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


        public void FoodRESUME()
        {
            FileStream fs = new FileStream(@"C:\Users\Аслан\source\repos\Snake\Snake\bin\Debug\levels\fsave.ser", FileMode.Create, FileAccess.Read);
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

        static void Main(string[] args)
        {

           

            Console.SetWindowSize(85, 35);
            
           
            Thread t = new Thread(MoveSnakeThread);
            t.Start();
            Console.CursorVisible = false;
            while (true)
            {
                ConsoleKeyInfo but = Console.ReadKey();
                switch (but.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (!block1)
                        {
                            block1 = true;
                            
                            direction = 1;
                            block2 = false;
                        }
                      
                        break;
                    case ConsoleKey.DownArrow:
                        if (!block1)
                        {
                            block1 = true;
                            direction = 2;
                            block2 = false;
                        }
                    
                        break;
                    case ConsoleKey.RightArrow:
                        if (!block2)
                        {
                            block1 = false;
                            direction = 3;
                            block2 = true;
                        }
                    
                        
                        break;
                    case ConsoleKey.LeftArrow:
                        if (!block2)
                        {
                            block1 = false;
                            direction = 4;
                            block2 = true;
                        }
                        break;

                    case ConsoleKey.Q:
                      direction = 5;
                        break;
                    case ConsoleKey.Enter:
                        direction = 6;
                        snake.body.Clear();
                        break;
                 
                       case ConsoleKey.S:
                       
                           Serial.SAVE();
                        break;
                    case ConsoleKey.R:
                       
                            Console.Clear();
                            Serial.RESUME();
                          
                            Serial.Draw();
                        
                        break;
                }
            }
        }
    }
}