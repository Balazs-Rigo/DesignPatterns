using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    public interface HtmlNode
    {
        void Execute(Operation operation);
    }
}
