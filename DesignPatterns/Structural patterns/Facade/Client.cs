using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_patterns.Facade
{
    internal class Client
    {
        public void CreateApplication(VisualStudioFacade facade)
        {
            facade.Start();

            //Workflow imitation
            for (int i = 0; i < 5; i++)
            {
                Console.Write(". ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
            facade.Stop();
        }
    }
}
