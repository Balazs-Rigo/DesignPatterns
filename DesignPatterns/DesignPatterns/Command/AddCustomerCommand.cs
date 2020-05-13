using DesignPatterns.Command.fx;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatterns.Command
{
    public class AddCustomerCommand : ICommand
    {
        private CustomerService service;

        public AddCustomerCommand(CustomerService service)
        {
            this.service = service;
        }

        public void Execute()
        {
            service.AddCustomer();
        }
    }
}
