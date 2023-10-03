//How to use Inheritance in C# Language

using System;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.SetAuthor("Smith");
        book1.SetTitle("A Great Book");

        Console.WriteLine(book1.GetBookInfo());//Calling book1

        PictureBook book2 = new PictureBook();
        book2.SetAuthor("Jones");
        book2.SetTitle("A Great Picture Book");
        book2.SetIllustrator("Burton");

        Console.WriteLine(book2.GetBookInfo());
        Console.WriteLine(book2.GetPictureBookInfo());

        Book book3 = new Book("Edwars", "Another Book");
        Console.WriteLine(book3.GetBookInfo());

        PictureBook book4 = new PictureBook();
        Console.WriteLine(book4.GetBookInfo());







    }
}