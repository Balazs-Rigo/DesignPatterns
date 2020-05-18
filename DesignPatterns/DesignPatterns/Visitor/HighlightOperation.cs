using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    public class HighlightOperation : Operation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("highlighting-heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("highlighting-anchor");
        }
    }
}
