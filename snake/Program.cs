using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.SetBufferSize( 80, 25 );

            HorizontalLine up_line = new HorizontalLine(0,78,0,'*');
            HorizontalLine down_line = new HorizontalLine(0, 78, 24,'*');
            VerticalLine left_line = new VerticalLine(0, 24, 0,'*');
            VerticalLine right_line = new VerticalLine(0, 24, 78,'*');
            up_line.Drow();
            down_line.Drow();
            left_line.Drow();
            right_line.Drow();
   
     
            Point p = new Point(4, 5, '*');
            p.Draw();

        }
    }
}
