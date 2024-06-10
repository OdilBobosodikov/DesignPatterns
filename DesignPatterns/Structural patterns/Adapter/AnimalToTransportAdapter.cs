using DesignPatterns.Behavioral_patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_patterns.Adapter
{
    internal class AnimalToTransportAdapter : ITransport
    {
        private readonly IAnimal animal;

        public AnimalToTransportAdapter(IAnimal animal)
        {
            this.animal = animal;
        }

        public void Drive()
        {
            animal.Move();
        }
    }
}
