using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_patterns.Facade
{
    internal class TextEditor
    {
        public void CreateCode()
        {
            Console.WriteLine("Writing code");
        }
        public void Save()
        {
            Console.WriteLine("saving code");
        }
    }
}
