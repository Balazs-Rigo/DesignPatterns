using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public class SpreadSheet : IObserver
    {
        private DataSource dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine("SpreadSheet got notified: " + dataSource.GetValue());
        }
    }
}
