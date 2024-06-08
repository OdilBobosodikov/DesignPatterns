namespace DesignPatterns.Structural_patterns.Decorator
{
    internal class BulgerianPizza : Pizza
    {
        public BulgerianPizza()
            : base("Bulgarian pizza")
        { }
        public override int GetCost()
        {
            return 8;
        }
    }

}
