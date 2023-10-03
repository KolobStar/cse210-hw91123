using System;

public class Word
{
    public string value;
    public bool hidden;
    private string hiddenValue;

    public Word(string value){
        this.value = value;
        for(int i = 0; i < value.Length; i++){
            hiddenValue += "_";
        }
    }
     override public string ToString()
     {
        if(hidden){
            return hiddenValue;
        }
          return value;
     }
}