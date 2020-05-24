using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor.Exercise
{
    public class FormatSegment : Segment
    {
        public override void ApplyFilter(IAudioFilter filter)
        {
            filter.Apply(this);
        }
    }
}
