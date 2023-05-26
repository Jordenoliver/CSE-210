using System;

class Program
{
    static void Main(string[] args)
    {
       

        Comment com1 = new Comment();
        com1._username = "benover";
        com1._text = "Had a good laugh";

        Comment com2 = new Comment();
        com2._username = "seashanties123";
        com2._text = "could have better music";

        Comment com3 = new Comment();
        com3._username = "brucelee20";
        com3._text = "more fighting please";
        
        Video vid1 = new Video();
        vid1._title = "funny dog videos";
        vid1._author = "puppygowoof";
        vid1._length = 1000;
        vid1._comments.Add(com1);
        vid1._comments.Add(com2);
        vid1._comments.Add(com3);
        vid1.DisplayVideoInfo();


        Comment com4 = new Comment();
        com4._username = "MiddleNameDanger";
        com4._text = "ya, you gonna die one day";

        Comment com5 = new Comment();
        com5._username = "Carnut";
        com5._text = "why, just why";

        Comment com6 = new Comment();
        com6._username = "user1835648923";
        com6._text = "That's so dangerous";
        
        Video vid2 = new Video();
        vid2._title = "telling my mexican mother her salsa is not spicy";
        vid2._author = "thiswasamistake";
        vid2._length = 70;
        vid2._comments.Add(com4);
        vid2._comments.Add(com5);
        vid2._comments.Add(com6);
        vid2.DisplayVideoInfo();

        Comment com7 = new Comment();
        com7._username = "autobodyshop";
        com7._text = "We will see you here again soon I see";

        Comment com8 = new Comment();
        com8._username = "Carnut";
        com8._text = "why, just why";

        Comment com9 = new Comment();
        com9._username = "user8739248345";
        com9._text = "WHAT HAVE YOU DONE";
        
        Video vid3 = new Video();
        vid3._title = "2023 Corvette getting its second accident";
        vid3._author = "CorvetteDriver";
        vid3._length = 30;
        vid3._comments.Add(com7);
        vid3._comments.Add(com8);
        vid3._comments.Add(com9);
        vid3.DisplayVideoInfo();
    }
}