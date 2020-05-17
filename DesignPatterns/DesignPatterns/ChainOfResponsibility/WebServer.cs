using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public class WebServer
    {
        private Handler handler;

        public WebServer(Handler handler)
        {
            this.handler = handler;
        }

        public void Handle(HttpRequest request)
        {
            handler.Handle(request);
        }

    }
}
