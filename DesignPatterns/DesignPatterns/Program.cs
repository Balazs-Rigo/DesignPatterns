using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using DesignPatterns.Adapter;
using DesignPatterns.Adapter.avaFilter;
using DesignPatterns.Adapter.Exercise;
using DesignPatterns.Bridge;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.ChainOfResponsibility.Exercise;
using DesignPatterns.Command;
using DesignPatterns.Command.editor;
using DesignPatterns.Command.fx;
using DesignPatterns.Composite;
using DesignPatterns.Composite.Exercise;
using DesignPatterns.Decorator;
using DesignPatterns.Decorator.Exercise;
using DesignPatterns.Facade.Exercise;
using DesignPatterns.Flyweight;
using DesignPatterns.Iterator;
using DesignPatterns.Memento;
using DesignPatterns.Memento.Exercise;
using DesignPatterns.Observer;
using DesignPatterns.Observer.Exercise;
using DesignPatterns.Proxy;
using DesignPatterns.Proxy.Exercise;
using DesignPatterns.State;
using DesignPatterns.State.Exercise;
using DesignPatterns.Strategy;
using DesignPatterns.Template;
using DesignPatterns.Template.Exercise;
using DesignPatterns.Visitor;
using DesignPatterns.Visitor.Exercise;
using Editor = DesignPatterns.Decorator.Exercise.Editor;
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

            //Exercise

            /*
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
            */
            #endregion

            #region Mediator

            #endregion

            #region ChainOfResponisbility
            /*
            var compression = new Compressor(null);
            var logger = new Logger(compression);
            var authentication = new Authenticator(logger);
            var server = new WebServer(authentication);


            server.Handle(new HttpRequest("admin", "1234"));
            */

            //exercise
            /*
            DataReader reader = DataReaderFactory.GetDataReaderChain();
            reader.Read("data.xls");
            reader.Read("data.numbers");
            reader.Read("data.qbw");
            // reader.Read("data.jpg");
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

            //exercise
            /*
            WavFile wavFile = WavFile.Read("myfile.wav");
            wavFile.ApplyFilter(new NoiseReductionFilter());
            wavFile.ApplyFilter(new ReverbFilter());
            wavFile.ApplyFilter(new NormalizeFilter());
            */
            #endregion

            #region composite
            /*
            var group1 = new Group();
            group1.Add(new Shape());
            group1.Add(new Shape());

            var group2 = new Group();
            group2.Add(new Shape());
            group2.Add(new Shape());

            var group = new Group();
            group.Add(group1);
            group.Add(group2);
            group.Render();
            group.Move();

            //Exercise

            var subTeam1 = new Team();
            subTeam1.Add(new Truck());
            subTeam1.Add(new HumanResource());
            subTeam1.Add(new HumanResource());

            var subTeam2 = new Team();
            subTeam2.Add(new Truck());
            subTeam2.Add(new HumanResource());
            subTeam2.Add(new HumanResource());

            var team = new Team();
            team.Add(subTeam1);
            team.Add(subTeam2);

            team.Deploy();
            */
            #endregion

            #region adapter
            /*
            //var imageView = new ImageView(new Image());
            //imageView.Apply(new CaramelFilter(new Caramel()));

            //Exercise
            var client = new EmailClient();
            client.AddProvider(new GmailAdapter());
            client.DownloadEmails();
            */
            #endregion

            #region Decorator
            /*
            StoreCreditCard(new EncryptedCloudStream(new CloudStream()));

            //Exercise
            var editor = new Editor();
            editor.openProject("....");
            */
            #endregion

            #region Facade
            /*
            var twitterAPI = new TwitterAPI("appKey","secret");
            var tweets = twitterAPI.GetRecentTweets();
            */
            #endregion

            #region Fylweight
            /*
            var service = new PointService(new PointIconFactory());
            foreach (var point in service.GetPoints())
            {
                point.Draw();
            }
             */
            #endregion

            #region Bridge
            /*
            var remoteControl = new AdvancedRemoteControl(new SamsungTV());
            remoteControl.TurnOn();
            */
            #endregion

            #region Proxy

            var library = new Library();
            string[] fileNames = {"a","b","c" };
            foreach (var fileName in fileNames)
                library.Add(new LoggingEbookProxy(fileName));

            library.openEbook("a");
            library.openEbook("b");

            //exercise

            var dbContext = new DbContext();
            var product = dbContext.GetProduct(1);
            product.SetName("updated name");
            dbContext.SaveChanges();

            product.SetName("Another name");
            dbContext.SaveChanges();

            #endregion
        }

        public static void StoreCreditCard(IStream stream)
        {
            stream.Write("1234-4342-1200-0012");
        }
    }
}
