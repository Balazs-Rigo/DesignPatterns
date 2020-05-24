using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility.Exercise
{
    public class DataReaderFactory
    {
        public static DataReader GetDataReaderChain()
        {
            ExcelReader excelReader = new ExcelReader();
            NumbersReader numbersReader = new NumbersReader();
            QuickBooksReader quickBooksReader = new QuickBooksReader();
            quickBooksReader.SetNext(numbersReader);
            numbersReader.SetNext(excelReader);
            return quickBooksReader;
        }
    }
}
