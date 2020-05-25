using DesignPatterns.Adapter.avaFilter;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class CaramelAdapter : Caramel, IFilter
    {
        public void Apply(Image image)
        {
            Init();
            Render(image);
        }
    }
}
