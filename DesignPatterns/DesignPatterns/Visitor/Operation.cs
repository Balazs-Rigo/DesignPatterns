using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    public interface Operation
    {
        void Apply(HeadingNode heading);
        void Apply(AnchorNode anchor);
    }
}
