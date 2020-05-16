using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator
{
    public class ListBox : UIControl
    {
        private string Selection;

        public string GetSelection()
        {
            return Selection;
        }

        public void SetSelection(string selection)
        {
            this.Selection = selection;
            NotifyEventHandlers();
        }
    }
}
