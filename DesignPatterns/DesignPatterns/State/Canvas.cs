using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public class Canvas
    {
        private ITool currentTool;

        public void MouseDown()
        {
            currentTool.MouseDown();
        }

        public void MouseUp()
        {
            currentTool.MouseUp();
        }

        public ITool GetCurrentTool()
        {
            return currentTool;
        }

        public void SetCurrentTool(ITool currentTool)
        {
            this.currentTool = currentTool;
        }
    }
}
