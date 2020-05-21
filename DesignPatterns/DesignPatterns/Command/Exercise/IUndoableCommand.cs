using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.Exercise
{
    public interface IUndoableCommand : ICommand
    {
        void Undo();
    }
}
