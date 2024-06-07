using DesignPatterns.Behavioral_patterns;
using DesignPatterns.Behavioral_patterns.Command;
using DesignPatterns.Behavioral_patterns.Iterator;
using DesignPatterns.Behavioral_patterns.Observer;
using DesignPatterns.Behavioral_patterns.State;
using DesignPatterns.Behavioral_patterns.Strategy;
using DesignPatterns.Behavioral_patterns.Template_Method;
using DesignPatterns.Creational_patterns.Abstract_Factory;
using DesignPatterns.Creational_patterns.Builder;
using DesignPatterns.Creational_patterns.Factory_Method;
using DesignPatterns.Creational_patterns.Prototype;
using DesignPatterns.Creational_patterns.Singleton;
using DesignPatterns.SOLID.S;
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

            Water water = new Water();
            water.Heat();
            water.Freeze();
            water.Freeze();
            water.Freeze();
            water.Heat();

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



            #endregion
            Console.ReadLine();
        }
    }
}
