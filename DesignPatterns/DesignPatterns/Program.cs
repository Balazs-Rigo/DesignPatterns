using System;
using DesignPatterns.Memento;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new History();

            editor.SetContent("a");
            history.Push(editor.CreateState());

            editor.SetContent("b");
            history.Push(editor.CreateState());

            editor.SetContent("c");

            editor.Restore(history.Pop());
            editor.Restore(history.Pop());

            Console.WriteLine(editor.GetContent());
        }
    }
}
