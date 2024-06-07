namespace DesignPatterns.SOLID.S
{
    class ConsolePhoneReader : IPhoneReader
    {
        public string?[] GetInputData()
        {
            Console.WriteLine("Input Model:");
            string? model = Console.ReadLine();
            Console.WriteLine("Input Cost:");
            string? price = Console.ReadLine();
            return new string?[] { model, price };
        }
    }
}
