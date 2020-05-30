using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight
{
    public class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> icons = new Dictionary<PointType, PointIcon>();

        public PointIcon getPointIcon(PointType type)
        {
            if (!icons.ContainsKey(type))
            {
                var icon = new PointIcon(type, null);
                icons.Add(type,icon);
            }
            return icons[type];
        }
    }
}
