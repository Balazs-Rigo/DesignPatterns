using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace DesignPatterns.Composite.Exercise
{
    public class Team : Resource
    {
        private List<Resource> resources = new List<Resource>();

        public void Add(Resource resource)
        {
            resources.Add(resource);
        }
        public override void Deploy()
        {
            foreach (var resource in resources)
                resource.Deploy();
        }
    }
}
