using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Template
{
    public class TransferMoneyTask : Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Transfer Money!");
        }
    }
}
