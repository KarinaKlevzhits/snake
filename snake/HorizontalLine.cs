using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorizontalLine
    {
        List<Point> pList;
        public HorizontalLine(int xleft,int xreight,int y,char symbol)
        {
            pList = new List<Point>();
           for(int x=xleft;x!=xreight;x++)
            {
                Point p = new Point(x, y, symbol);
                pList.Add(p);
            }
        }
        public void Drow()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
