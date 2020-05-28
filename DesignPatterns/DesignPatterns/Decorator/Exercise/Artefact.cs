using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.Exercise
{
    public class Artefact : IAbstractArtefact
    {
        private string name;
        public Artefact(string name)
        {
            this.name = name;
        }

        public string Render()
        {
            return name;
        }
    }
}
