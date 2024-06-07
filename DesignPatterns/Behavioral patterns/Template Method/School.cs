using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.Template_Method
{
    internal class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Entered to School");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Getting a certificate of secondary education");
        }

        public override void Study()
        {
            Console.WriteLine("Study at school!");
        }
    }
}
