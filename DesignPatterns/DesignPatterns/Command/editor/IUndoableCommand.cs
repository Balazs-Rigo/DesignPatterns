using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.editor
{
    public interface IUndoableCommand : ICommand
    {
        void Unexecute();
    }
}
