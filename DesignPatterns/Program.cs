using DesignPatterns.Creational_patterns.Abstract_Factory;
using DesignPatterns.Creational_patterns.Factory_Method;
using DesignPatterns.Creational_patterns.Prototype;
using DesignPatterns.Creational_patterns.Singleton;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Factory pattern

            var BMW = new CarManufacturer("BMW");
            var car = BMW.Manufacture();

            var MAN = new TruckManufacturer("MAN");
            var truck = MAN.Manufacture();

            Console.WriteLine(car);
            Console.WriteLine(truck);

            Console.WriteLine();

            #endregion

            #region Abstract Factory

            Hero elf = new Hero(new ElfFactory());
            elf.Move();
            elf.Hit();

            Console.WriteLine();

            Hero paladin = new Hero(new PaladinFactory());
            paladin.Move();
            paladin.Hit();

            Console.WriteLine();

            #endregion

            #region Singleton

            var userProfile1 = UserProfile.LogIn("User1");

            var userProfile2 = UserProfile.LogIn("User2");

            if (userProfile1 == userProfile2)
            {
                Console.WriteLine("Both users are Identical");
            }

            Console.WriteLine();

            #endregion

            #region Prototype

            IFigure rectangle = new Rectangle(10, 20);
            IFigure clonedRectangle = rectangle.Clone();
            
            rectangle.GetInfo();
            clonedRectangle.GetInfo();


            Console.WriteLine();

            IFigure circle = new Circle(10);
            IFigure clonedCircle = circle.Clone();

            circle.GetInfo();
            clonedCircle.GetInfo();

            Console.WriteLine();

            #endregion
        }
    }
}
