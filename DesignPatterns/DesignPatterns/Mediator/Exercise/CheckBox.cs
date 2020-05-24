using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.Exercise
{
    public class CheckBox : UIControl
    {
        private bool isChecked;

        public bool IsChecked()
        {
            return this.isChecked;
        }

        public void SetCheked(bool isChecked)
        {
            this.isChecked = isChecked;
            this.NotifyEventHandler();
        }
    }
}
