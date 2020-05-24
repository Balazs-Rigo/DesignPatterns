using DesignPatterns.Visitor.Exercise;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor.Exercise
{
    public abstract class Segment
    {
        public abstract void ApplyFilter(IAudioFilter var1);
    }
}
