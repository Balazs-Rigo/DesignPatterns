using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility.Exercise
{
    public class ExcelReader : DataReader
    {
        protected override void DoRead(string var1)
        {
            Console.WriteLine("Reading Data from an excel spreadsheet.");
        }

        protected override string GetExtension()
        {
            return ".xls";
        }
    }
}
