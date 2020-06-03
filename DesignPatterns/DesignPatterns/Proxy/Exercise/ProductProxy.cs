using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy.Exercise
{
    public class ProductProxy : Product
    {
        private DbContext context;

        public ProductProxy(int id, DbContext context):base(id)
        {
            this.context = context;
        }

        public override void SetName(string name)
        {
            base.SetName(name);
            context.mar
        }

    }
}
