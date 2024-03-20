namespace DesignPatterns.Creational_patterns.Factory_Method
{
    abstract public class Vehicle
    {
        public Vehicle(string manufacturerName)
        {
            ManufacturerName = manufacturerName;
        }
        public string ManufacturerName { get; }
    }
}
