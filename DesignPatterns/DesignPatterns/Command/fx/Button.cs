using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.fx
{
    public class Button
    {
        private string label;
        private ICommand command;

        public Button(ICommand command)
        {
            this.command = command;
        }

        public void Click()
        {
            command.Execute();
        }

        public string getLabel()
        {
            return label;
        }

        public void SetLabel(string label)
        {
            this.label = label;
        }
    }
}
