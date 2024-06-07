using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.Iterator
{
    internal class Library : IBookNumerable 
    {
        private readonly Book[] _books;
        public Library(Book[] books)
        {
            _books = books;
        }
        public Book this[int index] => _books[index];

        public int Count => _books.Count();

        public IBookIterator CreateNumerator()
        {
            return new LibraryNumerator(this);
        }
    }
}
