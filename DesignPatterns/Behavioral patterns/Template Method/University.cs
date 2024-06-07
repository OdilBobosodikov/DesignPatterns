using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.Template_Method
{
    internal class University : Education
    {
        public override void Enter()
        {
            Console.WriteLine("We pass the entrance exams and enter the university");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Receiving a diploma of higher education");
        }

        public override void Study()
        {
            Console.WriteLine("Attend lectures");
        }

        public override void PassExams()
        {
            Console.WriteLine("Passing the specialty exam");
        }
    }
}
