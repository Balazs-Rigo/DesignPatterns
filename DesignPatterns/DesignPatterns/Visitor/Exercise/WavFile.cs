using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor.Exercise
{
    public class WavFile
    {
        private List<Segment> segments = new List<Segment>();

        public static WavFile Read(string fileName)
        {
            WavFile wavFile = new WavFile();
            wavFile.segments.Add(new FormatSegment());
            wavFile.segments.Add(new FactSegment());
            wavFile.segments.Add(new FactSegment());
            wavFile.segments.Add(new FactSegment());
            return wavFile;
        }

        public void ApplyFilter(IAudioFilter filter)
        {
            List<Segment>.Enumerator var2 = this.segments.GetEnumerator();

            while (var2.MoveNext())
            {
                Segment segment = var2.Current;
                segment.ApplyFilter(filter);
            }
        }
    }
}
