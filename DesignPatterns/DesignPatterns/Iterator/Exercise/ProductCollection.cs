using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace DesignPatterns.Iterator.Exercise
{
    public class ProductCollection
    {
        private List<Product> products = new List<Product>();

        public void Add(Product product)
        {
            products.Add(product);
        }        
    }
}
