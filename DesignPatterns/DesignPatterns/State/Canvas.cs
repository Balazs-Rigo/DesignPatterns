using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public class Canvas
    {
        private Tool currentTool;

        public void MouseDown()
        {
            currentTool.MouseDown();
        }

        public void MouseUp()
        {
            currentTool.MouseUp();
        }

        public Tool GetCurrentTool()
        {
            return currentTool;
        }

        public void SetCurrentTool(Tool currentTool)
        {
            this.currentTool = currentTool;
        }
    }
}
