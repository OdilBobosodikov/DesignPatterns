
namespace DesignPatterns.SOLID.O.CooktTmplate
{
    internal abstract class MealBase
    {
        protected string? name;
        internal void Process(string name)
        {
            this.name = name;

            Prepare();
            Cook();
            Serve();
        }
        abstract public void Prepare(); 
        abstract public void Cook(); 
        abstract public void Serve(); 
    }
}