using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_25
{
    internal class Library
    {
        public Library[] _books=new Library[0];
        public Library[] Books => _books;
        public int BookLimit;
        public int No;


        public void AddBook(Library books)
        {
            Array.Resize(ref _books, _books.Length+1);
            _books[_books.Length-1] = books;

            for(int i=0; i<_books.Length; i++)
            {
                if(books is books[i])
                {

                }
            }
        }

        public Library FindBookByNo(int no)
        {
            for(int i=0; i<_books.Length; i++)
            {
                return _books[i];
            }
            return null;
        }

        public int FindIndexByNo(int no)
        {
            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i].No == no)
                {
                    return i;
                }
                
            }
            return -1;
        }

        public bool RemoveBook(int no)
        {
            var wantedbook = FindBookByNo(no);

            if (wantedbook == null) return false;

            var wantedIndex=FindIndexByNo(no);

            for(int i=wantedIndex;i<_books.Length;i++)
            {
                var temp = _books[i];
                _books[i] = _books[i+1];
                _books[i+1] = temp;
            }
            Array.Resize(ref _books, _books.Length-1);
            return true;
        }
    }
}
