using DesignPatterns.Creational_patterns.Abstract_Factory;
using DesignPatterns.Creational_patterns.Factory_Method;

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
        }
    }
}
