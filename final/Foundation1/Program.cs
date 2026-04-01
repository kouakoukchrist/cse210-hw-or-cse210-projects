using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        Video v1 = new Video("Comedy", "PaulYveEttien",500);
        Video v2 = new Video("La Servante", "Idolo",700);
        Video v3 = new Video("La Tontine", "Kouakou Tayson",1000);


        Comment c1 = new Comment("The video was extremely fun, I have enjoyed it", "Christ Kouakou");
        Comment c2 = new Comment("I am waiting for thee next video, I have enjoyed it", "Melyssa");
        Comment c3 = new Comment("Hey This was cool, I have enjoyed it", "Mael Kouakou");

        Comment c4 = new Comment("This was a masterpiece, loved every second", "Marie Claire");
        Comment c5 = new Comment("The acting was incredible, well done", "Kouassi Brou");
        Comment c6 = new Comment("I cried watching this, so touching", "Adjoua Fatima");

        Comment c7 = new Comment("This brought back so many memories", "Amenan Grace");
        Comment c8 = new Comment("The story was so relatable, great job", "Didier Zadi");
        Comment c9 = new Comment("I watched this three times already", "Solange Aya");

        v1.AddComment(c1);
        v1.AddComment(c2);
        v1.AddComment(c3);

        v2.AddComment(c4);
        v2.AddComment(c5);
        v2.AddComment(c6);

        v3.AddComment(c7);
        v3.AddComment(c8);
        v3.AddComment(c9);


     List<Video> videos = new List<Video>();
     videos.Add(v1);
     videos.Add(v2);
     videos.Add(v3);

     foreach(Video video in videos)
        {
            Console.WriteLine( "Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length: " + video.GetLength() + "sec") ;
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComment());
            Console.WriteLine();


         foreach(Comment comment in video.GetComments())
        {
            Console.WriteLine( "Commenter Name:" + " " + comment.GetName() + "~" + " "+ comment.GetText());
            Console.WriteLine();

        }

        }
    }

}
