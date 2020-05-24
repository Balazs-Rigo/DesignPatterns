using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor.Exercise
{
    public class ReverbFilter : IAudioFilter
    {
        public void Apply(FormatSegment var1)
        {
            Console.WriteLine("Reverb filter on format segment");
        }

        public void Apply(FactSegment var1)
        {
            Console.WriteLine("Reverb filter on fact segment");
        }
    }
}
