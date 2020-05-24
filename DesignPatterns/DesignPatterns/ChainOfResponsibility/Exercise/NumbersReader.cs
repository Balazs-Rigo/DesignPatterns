using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility.Exercise
{
    public class NumbersReader : DataReader
    {
        protected override void DoRead(string var1)
        {
            Console.WriteLine("Reading data from a numbers spreadsheet.");
        }

        protected override string GetExtension()
        {
            return ".numbers";
        }
    }
}
