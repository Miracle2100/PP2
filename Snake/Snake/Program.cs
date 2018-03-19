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
        public static BigFood bigfood = new BigFood();
        public static Wall wall = new Wall();
        public static int score = 0;
        public static bool block1 = true;
        public static bool block2 = false;
        public static bool realgameover = false;
        public static bool bigfoodexists = false;
        public static int z = -1;
  
        public static void MoveSnakeThread()
        {
            while (true)
            {
                Snake.draw();
                Food.draw();
                //  food1.draw1();
                Wall.draw();
               

                wall.Level();
                food.Process(wall);
                z++;
                z %= 60;
                if (z == 59 && bigfoodexists == false)
                { BigFood.draw();
                    bigfoodexists = true;
                }

             
               
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
                 

                }



                wall.Scoremenu();
                if (Snake.body[0].x < 0)
                    Snake.body[0].x = 60;
                if (Snake.body[0].x > 60)
                    Snake.body[0].x = 0;
                if (Snake.body[0].y < 0)
                    Snake.body[0].y = 30;
                if (Snake.body[0].y > 30)
                    Snake.body[0].y = 0;
                Console.SetCursorPosition(0, 33);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Your Score: " + score);


                if (snake.Eat())
                {
                    
                    score += 1;
                    Console.SetCursorPosition(0, 33);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Your Score: " + score);

                }
                if (snake.Eat1())
                {

                    score += 3;
                    Console.SetCursorPosition(0, 33);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Your Score: " + score);
                    bigfoodexists = false;
                }
                if (score > 7)
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
                
               
            
                if ( bigfood.IsontheSnake() == false || bigfood.Isonthewall() ==false)
                { bigfood.setrandompos();
                   
                }
                if (snake.D1() == false || snake.D2() == false)
                {
             
                  
                    realgameover = true;
                    gameover = true;
                    Gameover();
                
                   
                }
                if (food.Isonthefood() == false )
                {
                    food.setrandompos();
                }
                if (bigfood.Isonthefood() == false)
                { bigfood.setrandompos();
                   
                }

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
                
                StreamWriter ds = new StreamWriter(@"C:\Snake\Snake\bin\Debug\levels\players points.txt", true);

                ds.WriteLine("USER:" + s + " and Score:" + score);

                ds.Close();
                ConsoleKeyInfo f = Console.ReadKey();
               

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

                        gameover = true;
                        Gameover();
                        break;
                    case ConsoleKey.Enter:
                        Snake.body.Clear();
                        snake = new Snake(); 
                        break;
                 
                    case ConsoleKey.S:
                        //Serial.SAVE();


                        food.save();
                        
                        /*FileStream fs = new FileStream(@"food.ser", FileMode.Create, FileAccess.Write);
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(fs, food);
                        fs.Close();*/
                        Console.WriteLine("Done");
                        Console.ReadKey();
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