using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatterns.Iterator
{
    public class BrowseHistory
    {
        private string[] urls = new string[10];
        private int count;

        public void Push(string url)
        {
            urls[count++] = url;
        }

        public string Pop()
        {
            return urls[--count];
        }

        public Iterator CreateIterator()
        {
            return new ArrayIterator(this);
        }

        public class ArrayIterator : Iterator
        {
            private BrowseHistory history;
            private int index;

            public ArrayIterator(BrowseHistory history)
            {
                this.history = history;
            }

            public string current()
            {
                return history.urls[index];
            }

            public bool hasNext()
            {
                return index < history.count;
            }

            public void next()
            {
                index++;
            }
        }
    }
}
