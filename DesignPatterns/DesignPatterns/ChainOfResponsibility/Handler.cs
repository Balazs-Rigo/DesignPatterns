using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class Handler
    {
        private Handler next;

        public Handler(Handler next)
        {
            this.next = next;
        }

        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
                return;

            if (next != null)
                next.Handle(request);
        }

        public abstract bool DoHandle(HttpRequest request);
    }
}
