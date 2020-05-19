using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public interface IFilter
    {
        void Apply(string fileName);
    }
}
