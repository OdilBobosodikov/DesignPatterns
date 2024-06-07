using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.Iterator
{
    internal interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }
}
