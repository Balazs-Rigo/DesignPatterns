using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.Exercise
{
    public class VideoEditor
    {
        private float contrast = 0.5f;
        private string text;

        public void SetText(string text)
        {
            this.text = text;
        }

        public void RemoveText()
        {
            this.text = "";
        }

        public float GetContrast()
        {
            return contrast;
        }

        public void SetContrast(float contrast)
        {
            this.contrast = contrast;
        }

        public override string ToString()
        {
            return "VideoEditor{" +
                "contrast=" + contrast +
                ", text='" + text + '\'' +
                '}'; ;
        }
    }
}
