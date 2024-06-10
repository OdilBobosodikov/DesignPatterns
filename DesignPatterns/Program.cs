using DesignPatterns.Behavioral_patterns;
using DesignPatterns.Behavioral_patterns.Chain_of_responsobility;
using DesignPatterns.Behavioral_patterns.Command;
using DesignPatterns.Behavioral_patterns.Iterator;
using DesignPatterns.Behavioral_patterns.Mediator;
using DesignPatterns.Behavioral_patterns.Observer;
using DesignPatterns.Behavioral_patterns.State;
using DesignPatterns.Behavioral_patterns.Strategy;
using DesignPatterns.Behavioral_patterns.Template_Method;
using DesignPatterns.Creational_patterns.Abstract_Factory;
using DesignPatterns.Creational_patterns.Builder;
using DesignPatterns.Creational_patterns.Factory_Method;
using DesignPatterns.Creational_patterns.Prototype;
using DesignPatterns.Creational_patterns.Singleton;
using DesignPatterns.SOLID.I;
using DesignPatterns.SOLID.O.CookStrategy;
using DesignPatterns.SOLID.O.CookTmplate;
using DesignPatterns.SOLID.O.CooktTmplate;
using DesignPatterns.SOLID.S;
using DesignPatterns.Structural_patterns.Adapter;
using DesignPatterns.Structural_patterns.Decorator;
using DesignPatterns.Structural_patterns.Facade;
using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Design patterns

            #region Creational patterns

            #region Factory pattern

            //var BMW = new CarManufacturer("BMW");
            //var car = BMW.Manufacture();

            //var MAN = new TruckManufacturer("MAN");
            //var truck = MAN.Manufacture();

            //Console.WriteLine(car);
            //Console.WriteLine(truck);

            //Console.WriteLine();

            #endregion

            #region Abstract Factory

            //Hero elf = new Hero(new ElfFactory());
            //elf.Move();
            //elf.Hit();

            //Console.WriteLine();

            //Hero paladin = new Hero(new PaladinFactory());
            //paladin.Move();
            //paladin.Hit();

            //Console.WriteLine();

            #endregion

            #region Singleton

            //var userProfile1 = UserProfile.LogIn("User1");

            //var userProfile2 = UserProfile.LogIn("User2");

            //if (userProfile1 == userProfile2)
            //{
            //    Console.WriteLine("Both users are Identical");
            //}

            //Console.WriteLine();

            #endregion

            #region Prototype

            //IFigure rectangle = new Rectangle(10, 20);
            //IFigure clonedRectangle = rectangle.Clone();

            //rectangle.GetInfo();
            //clonedRectangle.GetInfo();


            //Console.WriteLine();

            //IFigure circle = new Circle(10);
            //IFigure clonedCircle = circle.Clone();

            //circle.GetInfo();
            //clonedCircle.GetInfo();

            //Console.WriteLine();

            #endregion

            #region Builder

            //Bakery baker = new Bakery();

            //BreadBuilder builder = new RyeBreadBuilder();

            //Bread ryeBread = baker.Bake(builder);
            //Console.WriteLine(ryeBread.ToString());

            //builder = new WheatBreadBuilder();

            //Bread wheatBread = baker.Bake(builder);
            //Console.WriteLine(wheatBread.ToString());

            //Console.WriteLine();

            #endregion

            #endregion

            #region Behavioral patterns

            #region Strategy 

            ////Example Hybrid car changes his driving method
            //CarStrategy car = new CarStrategy("BYD", "Chazor", new GasDrive());
            //car.Drive();

            //car.DrivingMethod = new ElectricDrive();
            //car.Drive();

            #endregion

            #region Observer

            ////Brokers cant assign to stock, only stock can assign them
            ////Banks have a two-way subscriprion
            //var stockInfo = new StockInfo() { USD = 50, EUR = 20 };

            ////Register Observers from Observable
            //var brokersList = new List<IObserver> { new Broker("Mike", stockInfo), new Broker("Liam", stockInfo), new Bank("SQB", stockInfo)};
            //Stock stock = new Stock(stockInfo, brokersList);

            ////Register Observable from Observer
            //var bank = new Bank("Ipoteka", stock, stockInfo);

            //stock.MarketChanges();
            //stock.NotifyObservers();

            #endregion

            #region Command

            //RemoteController rc = new RemoteController();
            //TV tv = new TV();

            ////Generate command
            //TVCommand tVCommand = new TVCommand(tv);

            ////Assign command to Executer
            //rc.SetCommand(tVCommand);
            //rc.PressButton();
            //rc.PressUndo();

            ////Here we call Undo while command is executed
            //Microwave microwave = new Microwave();
            //rc.SetCommand(new MicrowaveCommand(microwave, 10, new CancellationTokenSource()));
            //rc.PressButton();
            //Thread.Sleep(3000);
            //rc.PressUndo();

            ////we save all commands in stack to undo all changes
            //Volume volume = new Volume();
            //MultiRemoter mPult = new MultiRemoter();
            //mPult.SetCommand(0, new TVCommand(tv));
            //mPult.SetCommand(1, new VolumeCommand(volume));

            //mPult.PressButton(0);

            //mPult.PressButton(1);
            //mPult.PressButton(1);
            //mPult.PressButton(1);

            //mPult.PressUndoButton();
            //mPult.PressUndoButton();
            //mPult.PressUndoButton();
            //mPult.PressUndoButton();

            #endregion

            #region Template Method

            //List<Education> educationsSystems = new List<Education>() {new School(), new University() };

            //foreach (var system in educationsSystems)
            //{
            //    system.Learn();
            //}

            #endregion

            #region Iterator

            //Library library = new Library(new Book[] { new Book() {Name = "War and Piece" },
            //                              new Book() {Name = "Witcher: Last Wish" },
            //                              new Book() {Name = "C# in a nutshell"} });

            //Reader reader = new Reader();
            //reader.SeeBooks(library);

            #endregion

            #region State

            //Water water = new Water();
            //water.Heat();
            //water.Freeze();
            //water.Freeze();
            //water.Freeze();
            //water.Heat();

            #endregion

            #region Chain of responsobility

            //Receiver receiver = new Receiver(true, false, true);

            //List<PaymentHandler> paymeTransfers = new List<PaymentHandler>() { new CashTransfer(), new PaymeTransfer(), new BankTransfer()};

            //paymeTransfers[0].paymentHandler = paymeTransfers[1];
            //paymeTransfers[1].paymentHandler = paymeTransfers[2];

            //paymeTransfers[0].Handle(receiver);

            #endregion

            #region Momento

            //Behavioral_patterns.Memento.Hero hero = new Behavioral_patterns.Memento.Hero(3, 3);

            //hero.GetDammage();
            //hero.Shoot();
            //hero.Shoot();
            //hero.SaveMemento();
            //hero.GetDammage();
            //hero.GetDammage();


            #endregion

            #region Mediator

            //Manager management = new Manager();

            //Colleague customer = new CustomerColleague(management);
            //Colleague programmer = new ProgrammerColleague(management);
            //Colleague HR = new HRColleague(management);

            //management.Customer = customer;
            //management.Programmer = programmer;
            //management.HR = HR;

            //customer.Send("We need to implement all features by Tuesday");
            //programmer.Send("OK, we will work on it");
            //HR.Send("We need to hire more people!");

            #endregion

            //TODO: Visitor

            #endregion

            #region Structural patterns

            #region Decorator

            //Pizza pizza = new ItalianPizza();
            //Console.WriteLine($"{pizza.Name} casts {pizza.GetCost()}");
            //pizza = new PepperoniPizza(pizza);
            //Console.WriteLine($"{pizza.Name} casts {pizza.GetCost()}");

            //Pizza pizza1 = new BulgerianPizza();
            //Console.WriteLine($"{pizza1.Name} casts {pizza1.GetCost()}");
            //pizza1 = new CheesePizza(pizza1);
            //Console.WriteLine($"{pizza1.Name} casts {pizza1.GetCost()}");

            //Pizza pizza3 = new BulgerianPizza();
            //pizza3 = new PepperoniPizza(pizza3);
            //pizza3 = new CheesePizza(pizza3);
            //Console.WriteLine($"{pizza3.Name} casts {pizza3.GetCost()}");

            #endregion

            #region Adapter

            //Traveler traveler = new Traveler();

            //traveler.Travel(new Structural_patterns.Adapter.Car());
            //traveler.Travel(new AnimalToTransportAdapter(new Horse()));
            //traveler.Travel(new AnimalToTransportAdapter(new Camel()));

            #endregion

            #region Facade

            //Facade is used to simplify the usage of complex sistem
            //TextEditor textEditor = new TextEditor();
            //Compiller compiller = new Compiller();
            //CLR clr = new CLR();

            //VisualStudioFacade ide = new VisualStudioFacade(compiller,textEditor, clr);

            //Client client = new Client();
            //client.CreateApplication(ide);

            #endregion

            #region Composite

            //Structural_patterns.Composite.Component fileSystem = new Structural_patterns.Composite.Directory("File system");
            //Structural_patterns.Composite.Component diskC = new Structural_patterns.Composite.Directory("Disk C");
            //Structural_patterns.Composite.Component docxFile = new Structural_patterns.Composite.File("text.docx");
            //Structural_patterns.Composite.Component pngFile = new Structural_patterns.Composite.File("test.png");

            // diskC.Add(pngFile);
            // diskC.Add(docxFile);
            // fileSystem.Add(diskC);

            // fileSystem.Print();
            // Console.WriteLine();

            // diskC.Remove(pngFile);

            // Structural_patterns.Composite.Component docsFolder = new Structural_patterns.Composite.Directory("new folder");
            // Structural_patterns.Composite.Component txtFile = new Structural_patterns.Composite.File("readme.txt");
            // Structural_patterns.Composite.Component csFile = new Structural_patterns.Composite.File("Program.cs");
            // docsFolder.Add(txtFile);
            // docsFolder.Add(csFile);
            // diskC.Add(docsFolder);

            // fileSystem.Print();

            #endregion



            #endregion

            #endregion

            #region SOLID

            /*  SOLID stands for:
             *  S - Single Responsibility Principle 
             *  O - Open/Closed Principle 
             *  L - Liskov Substitution Principle 
             *  I - Interface Segregation Principle 
             *  D - Dependency Inversion Principle */

            #region S - Single Responsibility Principle

            //MobileStore ms = new MobileStore(new ConsolePhoneReader(), new GeneralPhoneBinder(), new GeneralPhoneValidator(), new TextPhoneSaver());
            //ms.Process();

            #endregion

            #region O - Open/Closed Principle 

            ////software entities (classes, modules, functions, and so on) should be open for extension, but closed for modification.
            ////That means that we cannot change the code, we can only extend it

            ////To add new functionality  we need to redesign whole method
            //Cook cook = new Cook("Jerry, the mashed potato maker");
            //cook.MakeDinner();

            //Console.WriteLine();

            ////In both cases to add a new meal we do not need to change initial architecture

            ////Implemented Open/Closed Principle using strategy 
            //CookStrategy cook2 = new CookStrategy("Tom, cook that can do any dish!");
            //List<IMeal> order = new List<IMeal> { new MashPotato(), new Salad() };
            //cook2.MakeDinner(order);

            ////Implemented Open/Closed Principle using Template method
            //CookTemplate cook3 = new CookTemplate("Liam, cook that can do any dish!");
            //List<MealBase> order1 = new List<MealBase> { new PotatoMeal(), new SaladMeal() };
            //cook3.MakeDinner(order1);


            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}
