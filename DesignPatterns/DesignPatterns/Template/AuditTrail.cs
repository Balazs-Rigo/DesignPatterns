using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Template
{
    public class AuditTrail
    {
        public void Record()
        {
            Console.WriteLine("Audit!");
        }
    }
}
