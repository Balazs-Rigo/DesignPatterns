using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.Exercise
{
    public class Button : UIControl
    {
        private bool isEnabled;

        public bool IsEnabled()
        {
            return this.isEnabled;
        }

        public void SetEnabled(bool enabled)
        {
            this.isEnabled = enabled;
            this.NotifyEventHandler();
        }
    }
}
