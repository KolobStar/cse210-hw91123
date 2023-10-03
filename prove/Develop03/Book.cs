public class Book 
{
    public string id{get;set;}
    public string bibleId{get;set;}
    public string name{get;set;}
    public string nameLong{get;set;}
    public string abbreviation{get;set;}

    override public string ToString(){
          return id;
    }
}
public class JSONBookData 
{
    public Book[] data {get;set;}
}