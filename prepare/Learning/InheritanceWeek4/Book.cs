using System;

public class Book
{
    protected string _author = ""; //Protected says it's accessible to to this class ans any that derive (la obtienen) from it 
    protected string _title = "";

    public Book()
    {
        _author ="Anonymous";
        _title ="Unknown";
    }
    public Book(string author, string title)
    {
        _author = author;
        _title = title;
    }

    public string GetAuthor()//Geters(GetAuthor)
    {
        return _author;
    }
    public void SetAuthor(string author)//Setters(SetAuthor)
    {
        _author = author;
    }
    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }


    public string GetBookInfo()
    {
        return $"{_title} by {_author}";
    }


}