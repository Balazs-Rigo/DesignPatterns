using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.Exercise
{
    public class SetContrastCommand : AbstractUndoableCommand
    {
        private float prevContrast;
        private float contrast;

        public SetContrastCommand(float contrast, VideoEditor videoEditor, History history)
            : base(videoEditor, history)
        {
            this.prevContrast = videoEditor.GetContrast();
            this.contrast = contrast;
        }
        protected override void DoExecute()
        {
            this.videoEditor.SetContrast(this.contrast);
        }

        public void DoUndo()
        {
            this.videoEditor.SetContrast(this.prevContrast);
        }
    }
}
