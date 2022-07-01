using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Library
    {
        public List<Book> books;
        public Library() { 
            books = new List<Book>();
        }
        public Book this[int i]{
            get
            {
                return books[i];
            }
            set
            {
                books[i] = value;
            }
        }
    }
}
