using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor.Exercise
{
    public interface IAudioFilter
    {
        void Apply(FormatSegment var1);
        void Apply(FactSegment var1);
    }
}
