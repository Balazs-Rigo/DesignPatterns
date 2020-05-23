using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer.Exercise
{
    public class Stock
    {
        private string symbol;
        private float price;
        private List<IObserver> observers = new List<IObserver>();

        public Stock(string symbol, float price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public void AddObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            List<IObserver>.Enumerator var1 = this.observers.GetEnumerator();

            while (var1.MoveNext())
            {
                IObserver observer = var1.Current;
                observer.PriceChanged();
            }
        }

        public float GetPrice()
        {
            return this.price;
        }

        public void SetPrice(float price)
        {
            this.price = price;
            this.NotifyObservers();
        }

        public override string ToString()
        {
            return "Stock{symbol='" + this.symbol + "', price=" + this.price + "}";
        }
    }
}
