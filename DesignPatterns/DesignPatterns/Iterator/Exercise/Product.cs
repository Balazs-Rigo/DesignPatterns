using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator.Exercise
{
    public class Product
    {
        private int Id;
        private string name;

        public Product(int id, string name)
        {
            this.Id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return "Product{" +
            "id=" + Id +
            ", name='" + name + '\'' +
            '}';
        }
    }
}
