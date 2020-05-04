using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    class EditorState
    {
        private readonly string content;

        public EditorState(string content)
        {
            this.content = content;
        }

        public string GetContent()
        {
            return content;
        }
    }
}
