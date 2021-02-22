using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorizontalLine : Figure
    {
        
        public HorizontalLine(int xleft,int xright,int y,char symbol)
        {
            pList = new List<Point>();
           for(int x=xleft;x!=xright;x++)
            {
                Point p = new Point(x, y, symbol);
                pList.Add(p);
            }
        }
      
    }
}
