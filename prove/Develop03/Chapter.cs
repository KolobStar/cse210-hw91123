public class Chapter
{
    public string id { get; set; }
    public string bibleId { get; set; }
    public string number { get; set; }
    public string bookId { get; set; }
    public string reference { get; set; }
    override
    public string ToString()
    {
        return id;
    }
}
public class JSONChapterdata
{
    public Chapter[] data { get; set; }
}