using System;

namespace ECLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Author myAuthor = new Author("Jeff Lucas", 'm', "jslucas@cba.ua.edu");
            Console.WriteLine(myAuthor.ToString());

            Book myBook = new Book("12243", "My book", myAuthor); //the constructor only had three spots, not four. I took yourBooks out.
            System.Console.WriteLine(myBook.ToString());

            Console.WriteLine(myBook.GetAuthor().ToString());

            Book yourBook = new Book("4321", "The Phantom Book", new Author("Jamie", 'f', "jamie@mail.com"));
            System.Console.WriteLine(yourBook.ToString());
            yourBook.GetAuthor().SetEmail("jamie@crimson.ua.edu");
            System.Console.WriteLine(yourBook.ToString());
        }
    }
}
