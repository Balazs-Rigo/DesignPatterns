using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy.Exercise
{
    public class Product
    {
        private int id;
        private string name;

        public Product(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public virtual void SetName(string name)
        {
            this.name = name;
        }
    }
}
