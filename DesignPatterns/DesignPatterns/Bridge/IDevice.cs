using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int number);
    }
}
