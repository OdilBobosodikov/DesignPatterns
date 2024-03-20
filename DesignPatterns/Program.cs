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

            #endregion
        }
    }
}
