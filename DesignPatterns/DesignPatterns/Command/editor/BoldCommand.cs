using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.editor
{
    public class BoldCommand : IUndoableCommand
    {
        private string prevContent;
        private HtmlDocument document;
        private History history;

        public BoldCommand(HtmlDocument document, History history)
        {
            this.document = document;
            this.history = history;
        }

        public void Execute()
        {
            prevContent = document.getContent();
            document.makeBold();
            history.Push(this);
        }

        public void Unexecute()
        {
            document.SetContent(prevContent);
        }
    }
}
