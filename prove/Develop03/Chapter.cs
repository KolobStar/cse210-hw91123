public class Chapter
{
     public string id { get; set; }
     public string bibleId { get; set; }
     public string number { get; set; }
     public string bookId { get; set; }
     public string reference { get; set; }
     public string content { get; set; }
     public List<string> verses;
     public List<Word> scripture;
     public List<Word> hiddenWords;
     public int scriptureStart;
     public int scriptureLength;

     public void CreateScripture(int start, int length)
     {
          if (scripture == null)
          {
               scripture = new List<Word>();
               hiddenWords = new List<Word>();
          }
          if (verses == null)
          {
               verses = new List<string>();
               string[] splitContent = content.Split("[");
               for (int i = 0; i < splitContent.Length; i++)
               {
                    if(splitContent[i].Trim().Length == 0){
                         continue;
                    }
                    verses.Add("[" + splitContent[i].Trim());
               }
          }

          scriptureStart = start;
          scriptureLength = length;

          scripture.Clear();
          hiddenWords.Clear();
          for (int i = start; i < length && i < verses.Count; i++)
          {
               string[] scriptureSplit = verses[i].Split(" ");
               foreach(string s in scriptureSplit){
                    scripture.Add(new Word(s));
               }
          }
     }

     public string Scripture(){
          string value = "";
          for (int i = 0; i < scripture.Count; i++)
          {
               value += scripture[i];
               if(i < scripture.Count - 1){
                    value += " ";
               }
          }
          return value;
     }

     public string ScriptureReference(){
          return $"{reference}: {scriptureStart}-{scriptureStart + scriptureLength}";
     }

     public void HideWord(int index){
          if(index >= scripture.Count){
               return;
          }

          if(!hiddenWords.Contains(scripture[index])){
               scripture[index].hidden = true;
               hiddenWords.Add(scripture[index]);
          }
     }

     override public string ToString()
     {
          return id;
     }
}
public class JSONChapterData
{
     public Chapter[] data { get; set; }
}
public class JSONVersesData
{
     public Chapter data { get; set; }
}