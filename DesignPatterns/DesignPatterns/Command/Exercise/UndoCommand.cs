using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.Exercise
{
    public class UndoCommand : ICommand
    {
        private History history;

        public UndoCommand(History history)
        {
            this.history = history;
        }
        public void Execute()
        {
            if (this.history.Size() > 0)
                this.history.Pop().Undo();
        }
    }
}
