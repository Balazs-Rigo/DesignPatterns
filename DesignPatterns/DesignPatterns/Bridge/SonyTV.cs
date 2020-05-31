using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    public class SonyTV : IDevice
    {
        public void SetChannel(int number)
        {
            Console.WriteLine("Sony: SetChannel");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony: TurnOff");
        }

        public void TurnOn()
        {
            Console.WriteLine("Sony: TurnOn");
        }
    }
}
