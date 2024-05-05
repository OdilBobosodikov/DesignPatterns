using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.Strategy
{
    //Since we already used Car in Factory method, I am forced to rename Car in the Strategy Folder To CarStrategy
    internal class CarStrategy
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public IDrivable DrivingMethod { get; set; }


        public CarStrategy(string brand, string model, IDrivable drivable)
        {
            Brand = brand;
            Model = model;
            DrivingMethod = drivable;
        }

        public void Drive()
        {
            DrivingMethod.Drive();
        }
    }
}
