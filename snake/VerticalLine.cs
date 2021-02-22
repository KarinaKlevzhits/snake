using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine : Figure
    {
        
        public VerticalLine(int x, int yup, int ydown, char symbol)
        {
            pList = new List<Point>();
            for (int y=yup; y != ydown; y++)
            {
                Point p = new Point(x,y, symbol);
                pList.Add(p);
            }
        }
       
     
    }
}
