using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento.Exercise
{
    class DocumentState
    {
        private readonly string content;
        private readonly string fontName;
        private readonly int fontSize;

        public DocumentState(string content, string fontName, int fontSize)
        {
            this.content = content;
            this.fontName = fontName;
            this.fontSize = fontSize;
        }

        public string getContent()
        {
            return this.content;
        }

        public string getFontName()
        {
            return this.fontName;
        }

        public int getFontSize()
        {
            return this.fontSize;
        }
    }
}
