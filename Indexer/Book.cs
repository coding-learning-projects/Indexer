using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Book
    {
        public Book(string title, int publication_year)
        {
            Title = title;
            Publication_year = publication_year;
        }

        public string Title { get; set; }
        public int Publication_year { get; set; }

        public override string ToString() => $"{Title}, {Publication_year}";

    }
}
