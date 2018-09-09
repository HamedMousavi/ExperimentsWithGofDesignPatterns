using Patterns.Command;
using Patterns.Command.Invokers;
using Patterns.Command.Receivers;
using Patterns.Decorator;
using Patterns.Factory.RealWorld;
using Patterns.Singleton;
using Patterns.TemplateMethod;
using Patterns.Composite;
using Patterns.State;
using Patterns.Proxy;
using Patterns.Visitor;


namespace Patterns
{

    public class TestPatterns
    {


        internal void Run(string pattern)
        {
            System.Diagnostics.Debug.WriteLine(
                string.Format("____________________________________________"));
            System.Diagnostics.Debug.WriteLine(
                string.Format("Testing {0} Pattern:\r\n...........................................", pattern));
            switch (pattern)
            {
                case "Strategy": TestStrategy(); break;
                case "Observer": TestObserver(); break;
                case "Decorator": TestDecorator(); break;
                case "FactoryMethod": TestFactoryMethod(); break;
                case "Singleton": TestSingleton(); break;
                case "Command": TestCommand(); break;
                case "Adapter": TestAdapter(); break;
                case "TemplateMethod": TestTemplateMethod(); break;
                case "Composite": TestComposite(); break;
                case "State": TestState(); break;
                case "Proxy": TestProxy(); break;
                case "Visitor": TestVisitor(); break;
            }
        }


        private void TestVisitor()
        {
            var accountant = new AccountatntVisitor();
            var reportGen = new HtmlReportGenVisitor(accountant);

            var gift = new GiftPackage();
            gift.Items.Add(new Book { Title = "Design Patterns", Price = 50 });
            gift.Items.Add(new Book { Title = "Applying UML", Price = 30 });
            gift.Items.Add(new Book { Title = "CLR via C#", Price = 40 });
            gift.Items.Add(new ElectronicBookReader());

            gift.Accept(accountant);
            gift.Accept(reportGen);

            System.Diagnostics.Debug.WriteLine(reportGen.Report);
        }


        public void TestStrategy()
        {
            Patterns.Strategy.Target target = new Strategy.Target(
                new Patterns.Strategy.Strategies.Strategy1());
            target.Run();


            target.Strategy = new Patterns.Strategy.Strategies.Strategy2();
            target.Run();
        }


        public void TestObserver()
        {
            Patterns.Observer.Observable subject = new Patterns.Observer.Observable("Subject 1");
            Patterns.Observer.Observer ob1 = new Observer.Observer(subject);
            Patterns.Observer.Observer ob2 = new Observer.Observer(subject);

            subject.Value = 5;

            ob1.Dispose();
            ob2.Dispose();
        }


        internal void TestDecorator()
        {
            ExistingClass ec = new ExistingClass();
            ec = new ExtendedClass2(ec);
            ec = new ExtendedClass1(ec);
            ec.Functionality();
        }


        internal void TestFactoryMethod()
        {
            //IFlower flower;
            //FlowerFactory gf = new GermanFactory();
            //FlowerFactory ff = new FrenchFactory();

            //flower = gf.CreateFlower("rose");
            //flower.Display();

            //flower = ff.CreateFlower("ROSE");
            //flower.Display();

            Document doc = new PdfDoument();
            doc.Print();

            doc = new XmlDouent();
            doc.Print();
        }


        internal void TestSingleton()
        {
            MySingleClass.Instance.SomeFunc();
        }


        internal void TestCommand()
        {
            IInvoker invk = new SimpleInvoker();

            invk.Command = new BaseCommand(new SimpleReceiver());
            invk.ExecuteCommands();
            invk.Undo();
            invk.Redo();
        }


        internal void TestAdapter()
        {
            Patterns.Adopter.ITarget target = new Patterns.Adopter.ConcreeteTarget();
            target.DoSomething();

            target = new Patterns.Adopter.Adapter(
                new Patterns.Adopter.ConcreeteAdaptee());
            target.DoSomething();
        }


        internal void TestTemplateMethod()
        {
            PlaneAutoPilot pilot = new BoeingAutoPilot();
            pilot.Takeoff();

            pilot = new AirbusAutoPilot();
            pilot.Takeoff();
        }


        internal void TestComposite()
        {
            IShapeElement canvas = new Canvas("Canvas 1");
            IShapeElement line = new LineElement("\tLine 1");
            IShapeElement canvas2 = new Canvas("\tCanvas 2");

            canvas.Add(line);
            canvas.Add(canvas2);

            canvas.Draw();
            canvas.DrawLines(); // Extension method
        }

        
        internal void TestState()
        {
            IStateContext hamed = new Hamed();

            hamed.HowAreYou();
            //hamed.HandleRejection();
            //hamed.HandleSuccess();

            hamed.ApplyForAJob();
            hamed.HowAreYou();

            hamed.HandleRejection();
            hamed.HowAreYou();

            hamed.ApplyForAJob();
            hamed.HowAreYou();


            hamed.HandleSuccess();
            hamed.HowAreYou();

            hamed.HandleSuccess();
            hamed.HowAreYou();

            hamed.ApplyForAJob();
        }


        internal void TestProxy()
        {
            var proxy = new HostProxy();
            proxy.Function();
            proxy.Function();
        }
    }
}