using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy.Exercise
{
    public class DbContext
    {
        private Dictionary<int, Product> updatedObjects = new Dictionary<int, Product>();

        public Product GetProduct(int id)
        {
            // Automatically generate SQL statements
            // to read the product with the given ID.
            Console.WriteLine("SELECT * FROM products WHERE product_id = %d \n", id);

            var product = new ProductProxy(id, this);
            product.SetName("Product 1");

            return product;
        }

        public void SaveChanges()
        {
            foreach (var updateObject in updatedObjects.Values)
               // Console.WriteLine("UPDATE products SET name = '%s' WHERE product_id = %d \n",updatedObjects[]);

            updatedObjects.Clear();
        }

        public void MarkAsChanged(Product product)
        {
            updatedObjects.Add(product.getId(),product);
        }
    }
}
