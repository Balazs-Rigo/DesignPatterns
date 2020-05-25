using DesignPatterns.Adapter.avaFilter;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class CaramelFilter : IFilter
    {
        private Caramel caramel;

        public CaramelFilter(Caramel caramel)
        {
            this.caramel = caramel;
        }
        public void Apply(Image image)
        {
            caramel.Init();
            caramel.Render(image);
        }
    }
}
