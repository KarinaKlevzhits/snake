using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.SetWindowSize(40, 18);
            Console.SetBufferSize(40, 18);
            


            HorizontalLine up_line = new HorizontalLine(0,38,0,'*');
            HorizontalLine down_line = new HorizontalLine(0, 38, 18,'*');
            VerticalLine left_line = new VerticalLine(0, 18, 0,'*');
            VerticalLine right_line = new VerticalLine(0, 17, 38,'*');
            up_line.Draw();
            down_line.Draw();
            left_line.Draw();
            right_line.Draw();
   
     
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            while (true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
              
                }
            }
            Thread.Sleep(100);
            snake.Move();
            
           
        }
    }
}
