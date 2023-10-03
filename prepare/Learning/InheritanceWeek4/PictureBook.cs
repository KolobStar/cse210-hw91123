using System;
public class PictureBook : Book // the way to know that is a book is by adding ((:)a colon)
{
    private string _illustrator = "";//atributes (_illustrator)
    
    public PictureBook() : base()
    {}
    
    public PictureBook(string author, string title, string illustrator) : base(author, title)
    {
        _illustrator = illustrator;
    }
    
    
    public string GetIllustratos()//method (GetIllustratos)
    {
        return _illustrator;
    }

    public void SetIllustrator(string illustrator)
    {
        _illustrator = illustrator;
    }

    public string GetPictureBookInfo()
    {
        return $"{_title} by {_author} illustrated by {_illustrator}";
    }
}