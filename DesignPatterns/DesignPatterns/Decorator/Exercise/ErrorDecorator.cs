using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.Exercise
{
    public class ErrorDecorator : IAbstractArtefact
    {
        private IAbstractArtefact artefact;

        public ErrorDecorator(IAbstractArtefact artefact)
        {
            this.artefact = artefact;
        }
        public string Render()
        {
            var mainIcon = artefact.Render();
            return mainIcon + " [Error]";
        }
    }
}
