using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.Exercise
{
    public class MainDecorator : IAbstractArtefact
    {
        private IAbstractArtefact artefact;

        public MainDecorator(IAbstractArtefact artefact)
        {
            this.artefact = artefact;
        }
        public string Render()
        {
            return artefact.Render()+" [Main]";
        }
    }
}
