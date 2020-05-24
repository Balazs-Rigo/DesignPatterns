using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.Exercise
{
    public class TextBox : UIControl
    {
        private string content;

        public string GetContent()
        {
            return this.content;
        }

        public void SetContent(string content)
        {
            this.content = content;
            this.NotifyEventHandler();
        }

        public bool IsEmpty()
        {
            return this.content == null || string.IsNullOrWhiteSpace(this.content);
        }
    }
}
