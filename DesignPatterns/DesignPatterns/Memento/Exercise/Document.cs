using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento.Exercise
{
    class Document
    {
        private string content;
        private string fontName;
        private int fontSize;

        public DocumentState CreateState()
        {
            return new DocumentState(this.content,this.fontName,this.fontSize);
        }

        public void Restore(DocumentState memento)
        {
            this.content = memento.getContent();
            this.fontSize = memento.getFontSize();
            this.fontName = memento.getFontName();
        }

        public string getContent()
        {
            return content;
        }

        public void SetContent(string content)
        {
            this.content = content;
        }

        public string GetFontName(string fontName)
        {
            return fontName;
        }

        public void SetFontName(string fontName)
        {
            this.fontName = fontName;
        }

        public int GetFontSize()
        {
            return fontSize;
        }

        public void SetFontSize(int fontSize)
        {
            this.fontSize = fontSize;
        }

        public override string ToString()
        {
            return "Document{" +
                "content='" + content + '\'' +
                ", fontName='" + fontName + '\'' +
                ", fontSize=" + fontSize +
                '}';
        }
    }
}
