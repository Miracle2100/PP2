using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    [Serializable]
    class Serial
    {
        public static Program p;
        public static Snake snake;
        public static Wall wall;
        public static Food food;

        public static void SAVE()
        {
            p.FoodSAVE( );
            p.SnakeSAVE();
            p.WallSAVE();
        }
        public static void RESUME()
        {
            p.FoodRESUME();
            p.WallRESUME();
            p.SnakeRESUME();
        }
        public static  void Draw()
        {
           
          snake.draw();
            wall.draw();
            food.draw();
          
        }
    }
}
