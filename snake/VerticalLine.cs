using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine:Figure
    {
        
        public VerticalLine(int yup, int ydown, int x, char symbol)
        {
            pList = new List<Point>();
            for (int y=yup; y != ydown; y++)
            {
                Point p = new Point(y, x, symbol);
                pList.Add(p);
            }
        }
       
     
    }
}
