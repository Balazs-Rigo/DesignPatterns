﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    class History
    {
        private List<EditorState> states = new List<EditorState>();

        public void Push(EditorState state)
        {
            states.Add(state);
        }

        public EditorState Pop()
        {
            var lastIndex = states.Count - 1;
            var lastState = states[lastIndex];
            states.Remove(lastState);

            return lastState;
        }
    }
}
