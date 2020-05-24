using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace DesignPatterns.Mediator.Exercise
{
    public class UIControl
    {
        private List<IEventHandler> eventHandlers = new List<IEventHandler>();

        public void AddEventHandler(IEventHandler handler)
        {
            this.eventHandlers.Add(handler);
        }

        public void NotifyEventHandler()
        {
            List<IEventHandler>.Enumerator var1 = this.eventHandlers.GetEnumerator();

            while (var1.MoveNext())
            {
                IEventHandler handler = var1.Current;
                handler.Handle();
            }
        }
    }
}
