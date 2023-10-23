using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Comment com1 = new Comment();
        com1._username = "Ady1989";
        com1._text = "It was fun!";
        Comment com2 = new Comment();
        com2._username = "Lila786";
        com2._text = "Nice Video";
        Comment com3 = new Comment();
        com3._username = "Dan123";
        com3._text = "Nice faiths";

        Video vid1 = new Video();
        vid1._title = "Funny Videos";
        vid1._author = "funnylifevideos";
        vid1._length = 1000;
        vid1._comments.Add(com1);
        vid1._comments.Add(com2);
        vid1._comments.Add(com3);
        vid1.DisplayVideoInfo();
        Comment com4 = new Comment();
        com4._username = "Adela345";
        com4._text = "Don't try that at home";
        Comment com5 = new Comment();
        com5._username = "Carrabas";
        com5._text = "Not funny";
        Comment com6 = new Comment();
        com6._username = "Beninava78";
        com6._text = "Nex video please!";
         Video vid2 = new Video();

        vid2._title = "How to fix a car";
        vid2._author = "fixityourself";
        vid2._length = 70;
        vid2._comments.Add(com4);
        vid2._comments.Add(com5);
        vid2._comments.Add(com6);
        vid2.DisplayVideoInfo();
        Comment com7 = new Comment();
        com7._username = "technic";
        com7._text = "That method is not the rigth one";
        Comment com8 = new Comment();
        com8._username = "Bodyshop59";
        com8._text = "That looks easier than I thouth";
        Comment com9 = new Comment();
        com9._username = "babyface";
        com9._text = "Where did you got those tools?";

        Video vid3 = new Video();
        vid3._title = "Cooking with Mia";
        vid3._author = "cookingchanel";
        vid3._length = 30;
        vid3._comments.Add(com7);
        vid3._comments.Add(com8);
        vid3._comments.Add(com9);
        vid3.DisplayVideoInfo();
    }
}