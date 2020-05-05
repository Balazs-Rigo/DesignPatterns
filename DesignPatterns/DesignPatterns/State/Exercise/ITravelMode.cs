using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State.Exercise
{
    interface ITravelMode
    {
        object GetEta();

        object GetDirection();
    }
}
