using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight
{
    public class PointService
    {
        private PointIconFactory iconFactory;

        public PointService(PointIconFactory iconFactory)
        {
            this.iconFactory = iconFactory;
        }

        public List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            var point = new Point(1,2,iconFactory.getPointIcon(PointType.CAFE));
            points.Add(point);

            return points;
       
        }
        
    }
}
