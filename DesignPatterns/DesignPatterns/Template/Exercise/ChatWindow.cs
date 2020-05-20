using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Template.Exercise
{
    public class ChatWindow : Window
    {
        protected override void OnClosed()
        {
            Console.WriteLine("Disconnection from the server.....");
        }

    }
}
