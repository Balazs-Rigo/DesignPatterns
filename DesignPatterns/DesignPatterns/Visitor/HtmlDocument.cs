using System.Collections.Generic;

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    public class HtmlDocument
    {
        private List<HtmlNode> nodes = new List<HtmlNode>();

        public void Add(HtmlNode node)
        {
            nodes.Add(node);
        }

        public void Execute(Operation operation)
        {
            foreach (var node in nodes)
            {
                node.Execute(operation);
            }
        }
    }
}
