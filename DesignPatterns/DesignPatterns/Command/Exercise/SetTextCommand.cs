using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.Exercise
{
    public class SetTextCommand : AbstractUndoableCommand
    {
        private string text;

        public SetTextCommand(string text, VideoEditor videoEditor, History history)
            : base(videoEditor, history)
        {
            this.text = text;
        }

        public void Undo()
        {
            this.videoEditor.RemoveText();
        }
        protected override void DoExecute()
        {
            this.videoEditor.SetText(this.text);
        }
    }
}
