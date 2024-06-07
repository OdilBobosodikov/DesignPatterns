using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.Template_Method
{
    internal abstract class Education
    {


        public void Learn()
        {
            Enter();
            Study();
            PassExams();
            GetDocument();
        }

        public abstract void Enter();
        public abstract void Study();
        public virtual void PassExams() 
        {
            Console.WriteLine("Passing final exams!");
        }

        public abstract void GetDocument();
    }
}
