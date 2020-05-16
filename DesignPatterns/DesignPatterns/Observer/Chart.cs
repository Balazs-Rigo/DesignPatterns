﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public class Chart : IObserver
    {
        private DataSource dataSource;

        public Chart(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("Chart got updated: " + dataSource.GetValue());
        }
    }
}
