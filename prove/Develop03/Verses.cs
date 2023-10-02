public class Verses
{
    public string id { get; set; }
    public string bibleId { get; set; }
    public string number { get; set; }
    public string bookId { get; set; }
    public string reference { get; set; }
    public string content {get; set;}
    public  int verseCount  {get; set;}

    override
    public string ToString()
    {
        return id;
    }
}
public class JSONVersesdata
{
    public Verses[] data { get; set; }
}