using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator
{
    public class TextBox : UIControl
    {
        private string Content;

        public string GetContent()
        {
            return Content;
        }

        public void SetContent(string content)
        {
            this.Content = content;
            NotifyEventHandlers();
        }
    }
}
