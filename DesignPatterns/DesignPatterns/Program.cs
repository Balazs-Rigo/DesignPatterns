using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.Command;
using DesignPatterns.Command.editor;
using DesignPatterns.Command.fx;
using DesignPatterns.Iterator;
using DesignPatterns.Memento;
using DesignPatterns.Memento.Exercise;
using DesignPatterns.Observer;
using DesignPatterns.Observer.Exercise;
using DesignPatterns.State;
using DesignPatterns.State.Exercise;
using DesignPatterns.Strategy;
using DesignPatterns.Template;
using DesignPatterns.Template.Exercise;
using DesignPatterns.Visitor;
using HtmlDocument = DesignPatterns.Visitor.HtmlDocument;

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
            /*
            var canvas = new Canvas();
            canvas.SetCurrentTool(new SelectionTool());
            canvas.MouseDown();
            canvas.MouseUp();

            //state Execrice

            DirectionService service = new DirectionService(new Walking());

            service.getEta();
            service.GetDirection();
            */
            #endregion

            #region iterator
            /*
            var history = new BrowseHistory();

            history.Push("a");
            history.Push("c");
            history.Push("b");

            DesignPatterns.Iterator.Iterator iterator = history.CreateIterator();
            while (iterator.hasNext())
            {
                var url = iterator.current();
                Console.WriteLine(url);
                iterator.next();
            }           
    */
            #endregion

            #region Strategy
            /*
            var imageStorage = new ImageStorage();

            imageStorage.Store("a",new JpegCompressor(), new BlackAndWhiteFilter());
            imageStorage.Store("b",new PngCompressor(), new BlackAndWhiteFilter());
            */
            #endregion

            #region template
            /*
            //var task = new TransferMoneyTask();
            //task.Execute();

            //exercise template code
            ChatWindow window = new ChatWindow();
            window.Close();
            */
            #endregion

            #region Command
            /*
            var service = new CustomerService();
            var command = new AddCustomerCommand(service);
            var button = new Button(command);
            button.Click();

            var composite = new CompositeCommand();
            composite.Add(new BlackAndWhiteCommand());
            composite.Add(new ResizeCommand());
            composite.Execute();
            composite.Execute();

            var history = new Command.editor.History();
            var document = new HtmlDocument();
            document.SetContent("HTML-es dokumentes istenfasza");

            var boldCommand = new BoldCommand(document, history);

            boldCommand.Execute();
            Console.WriteLine(document.getContent());

            var undoCommand = new UndoCommand(history);

            undoCommand.Execute();
            Console.WriteLine(document.getContent());
            undoCommand.Execute();

            */
            #endregion

            #region Observer
            /*
            var dataSource = new DataSource();
            var sheet1 = new SpreadSheet(dataSource);
            var sheet2 = new SpreadSheet(dataSource);
            var chart = new Chart(dataSource);

            dataSource.AddObserver(sheet1);
            dataSource.AddObserver(sheet2);
            dataSource.AddObserver(chart);

            dataSource.SetValue(1);
            */

            StatusBar statusBar = new StatusBar();
            StockListView stockListView = new StockListView();
            Stock stock1 = new Stock("stock1", 10.0f);
            Stock stock2 = new Stock("stock2", 30.0f);
            Stock stock3 = new Stock("stock3", 30.0f);

            statusBar.AddStock(stock1);
            statusBar.AddStock(stock2);
            stockListView.AddStock(stock1);
            stockListView.AddStock(stock2);
            stockListView.AddStock(stock3);
            stock2.SetPrice(21.0f);
            stock3.SetPrice(9.0f);
            #endregion

            #region ChainOfResponisbility
            /*
            var compression = new Compressor(null);
            var logger = new Logger(compression);
            var authentication = new Authenticator(logger);
            var server = new WebServer(authentication);


            server.Handle(new HttpRequest("admin", "1234"));
            */
            #endregion

            #region visitor
            /*
            var document = new HtmlDocument();
            document.Add(new HeadingNode());
            document.Add(new AnchorNode());
            document.Execute(new HighlightOperation());
            document.Execute(new PlaintextOperation());
            */
            #endregion
        }
    }
}
