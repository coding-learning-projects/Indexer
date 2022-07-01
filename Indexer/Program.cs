
using Indexer;

Library l = new Library();
l.books.Add(new Book("Hello", 1900));
l.books.Add(new Book("World", 1910));

Console.WriteLine(l[0]);
Console.WriteLine(l[1]);

l[0] = new Book("C#", 1998);
l[1] = new Book("Language", 2010);


Console.WriteLine(l[0]);
Console.WriteLine(l[1]);