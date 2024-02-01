using Homework_25;
using System.Collections.Concurrent;

Dictionary<string, DateTime> exam=new Dictionary<string, DateTime>();
exam.Add("riyaziyyat", new DateTime(2010, 12, 23));

foreach(KeyValuePair<string, DateTime> item in exam)
{
    Console.WriteLine(item.Key);
    Console.WriteLine(item.Value);
}


string opt;

do
{
    Console.WriteLine("1. Add book");
    Console.WriteLine("2. Delete book");
    Console.WriteLine("3. Show all books");
    Console.WriteLine("4. Search book");
    Console.WriteLine("0. Cix");

    Console.WriteLine("Emeliyyati secin: ");
    opt= Console.ReadLine();

    switch (opt)
    {
        case "1":
            Library
            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
            break;

    }

} while (opt != "0");

void AddBook()
{
    Console.WriteLine("Book name: ");
    string name=Console.ReadLine();
    
}