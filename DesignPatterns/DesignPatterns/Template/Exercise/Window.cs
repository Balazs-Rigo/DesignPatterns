using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DesignPatterns.Template.Exercise
{
    public abstract class Window
    {
        public void Close()
        {
            this.OnClosing();
            Console.WriteLine("Removing the window from the screen");
            this.OnClosed();
        }

        protected void OnClosing()
        {
            Console.WriteLine("On closing....");
        }

        protected virtual void OnClosed()
        {
            Console.WriteLine("On closed....");
        }
    }
}
