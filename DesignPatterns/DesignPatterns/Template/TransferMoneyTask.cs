using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Template
{
    public class TransferMoneyTask : Task
    {
        public override void DoExecute()
        {
            Console.WriteLine("Transfer Money!");
        }
    }
}
