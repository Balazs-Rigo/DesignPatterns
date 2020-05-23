using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer.Exercise
{
    public class StockListView : IObserver
    {
        private List<Stock> stocks = new List<Stock>();

        public void AddStock(Stock stock)
        {
            this.stocks.Add(stock);
            stock.AddObserver(this);
        }

        public void Show()
        {
            Console.WriteLine("Stock List View");
            List<Stock>.Enumerator var1 = this.stocks.GetEnumerator();

            while (var1.MoveNext())
            {
                Stock stock = var1.Current;
                Console.WriteLine(stock);
            }
        }

        public void PriceChanged()
        {
            Console.WriteLine("Price Changed - Refreshing StockListView");
            this.Show();
        }
    }
}
