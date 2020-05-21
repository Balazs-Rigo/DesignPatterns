using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.Exercise
{
    public abstract class AbstractUndoableCommand : IUndoableCommand
    {
        protected VideoEditor videoEditor;
        protected History history;

        public AbstractUndoableCommand(VideoEditor videoEditor, History history)
        {
            this.videoEditor = videoEditor;
            this.history = history;
        }
        public void Execute()
        {
            this.DoExecute();
            this.history.Push(this);
        }
        protected abstract void DoExecute();
        protected abstract void DoUndo();

        public IUndoableCommand Undo()
        {
            this.DoUndo();
            return this.history.Pop();
        }
    }
}
