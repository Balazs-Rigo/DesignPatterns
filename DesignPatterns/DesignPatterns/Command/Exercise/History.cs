using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.Exercise
{
    public class History
    {
        private Stack<IUndoableCommand> commands = new Stack<IUndoableCommand>();

        public void Push(IUndoableCommand command)
        {
            commands.Push(command);
        }

        public IUndoableCommand Pop()
        {
            if (commands.Count > 0)
                return commands.Pop();

            throw new InvalidOperationException("Nincs már több elem!");
        }

        public int Size()
        {
            return this.commands.Count;
        }
    }
}
