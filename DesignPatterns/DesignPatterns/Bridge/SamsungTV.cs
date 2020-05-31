using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    public class SamsungTV : IDevice
    {
        public void SetChannel(int number)
        {
            Console.WriteLine("Samsung: SetChannel");
        }

        public void TurnOff()
        {
            Console.WriteLine("Samsung: TurnOff");
        }

        public void TurnOn()
        {
            Console.WriteLine("Samsung: TurnOn");
        }
    }
}
