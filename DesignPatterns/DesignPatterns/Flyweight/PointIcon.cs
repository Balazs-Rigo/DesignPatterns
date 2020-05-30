using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace DesignPatterns.Flyweight
{
    public class PointIcon
    {
        private readonly PointType type;
        private readonly byte[] icon;

        public PointIcon(PointType type, byte[] icon)
        {
            this.type = type;
            this.icon = icon;
        }

        public PointType GetPointType()
        {
            return type;
        }
    }
}
