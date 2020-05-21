using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.Exercise
{
    public class VideoFrameCommand : IUndoableCommand
    {
        private string prevContent;
        private VideoEditor video;
        private History history;

        public VideoFrameCommand(VideoEditor video, History history)
        {
            this.video = video;
            this.history = history;

        }
        public void Execute()
        {
            prevContent = video.GetText();
            video.SetText("Uj frame");
            history.Push(this);
        }

        public void Unexecute()
        {
            video.SetText(prevContent);
        }
    }
}
