using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento.Exercise
{
    class HistoryDocument
    {
        private List<DocumentState> states = new List<DocumentState>();

        public void Push(DocumentState state)
        {
            states.Add(state);
        }

        public DocumentState Pop()
        {
            var lastIndex = states.Count - 1;
            var lastState = states[lastIndex];
            states.Remove(lastState);

            return lastState;
        }
    }
}
