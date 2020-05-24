﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor.Exercise
{
    public class NoiseReductionFilter : IAudioFilter
    {
        public void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Noise reduction on format segment");
        }

        public void Apply(FactSegment factSegment)
        {
            Console.WriteLine("Noise reduction on fact segment");
        }
    }
}
