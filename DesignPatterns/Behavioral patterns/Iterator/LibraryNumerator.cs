﻿namespace DesignPatterns.Behavioral_patterns.Iterator
{
    internal class LibraryNumerator : IBookIterator
    {
        private readonly IBookNumerable aggregate;
        private int index = 0;

        public LibraryNumerator(IBookNumerable a)
        {
            aggregate = a;
        }
        public bool HasNext()
        {
            return index < aggregate.Count;
        }

        public Book Next()
        {
            return aggregate[index++];
        }
    }
}