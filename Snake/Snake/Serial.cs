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
        
        public static void SAVE()
        {
            Food.FoodSAVE();
            Snake.SnakeSAVE();
            Wall.WallSAVE();
            BigFood.FoodSAVE();
      }
        public static  void RESUME()
        {
            Food.FoodRESUME();
            Snake.SnakeRESUME();
            Wall.WallRESUME();
            BigFood.FoodRESUME();

        }
        public static void Draw()
        {
           
          Snake.draw();
           Wall.draw();
            Food.draw();
            BigFood.draw();
        }
    }
}
