using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.editor
{
    public class HtmlDocument
    {
        private string content;

        public void makeBold()
        {
            content = "<b>" + content + "</b>";
        }

        public string getContent()
        {
            return content;
        }

        public void SetContent(string content)
        {
            this.content = content;
        }
    }
}
