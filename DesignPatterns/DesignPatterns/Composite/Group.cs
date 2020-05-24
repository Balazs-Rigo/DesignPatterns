using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    public class Group : IComponent
    {
        private List<IComponent> components = new List<IComponent>();

        public void Add(IComponent shape)
        {
            components.Add(shape);
        }
        public void Move()
        {
            foreach (var component in components)
                component.Move();
        }

        public void Render()
        {
            foreach (var component in components)
                component.Render();
        }
    }
}
