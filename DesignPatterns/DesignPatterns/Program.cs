using System;
using DesignPatterns.Memento;
using DesignPatterns.Memento.Exercise;
using DesignPatterns.State;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region memento
            /*
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

            //memento exercise

            Document document = new Document();
            HistoryDocument historyDoc = new HistoryDocument();

            document.SetContent("Hello");
            historyDoc.Push(document.CreateState());
            document.SetFontName("Font 1");
            historyDoc.Push(document.CreateState());
            document.SetFontSize(10);
            document.SetContent("No more captain Kirk chit chat!");
            Console.WriteLine(document);
            document.Restore(historyDoc.Pop());
            Console.WriteLine(document);
            document.Restore(historyDoc.Pop());
            Console.WriteLine(document);
            */
            #endregion

            #region state

            var canvas = new Canvas();
            canvas.SetCurrentTool(new SelectionTool());
            canvas.MouseDown();
            canvas.MouseUp();

            #endregion
        }
    }
}
