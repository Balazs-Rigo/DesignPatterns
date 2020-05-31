using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) 
            : base(device)
        {
            
        }

        public void SetChannel(int number)
        {
            device.SetChannel(number);
        }
    }
}
