using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Title 1", "Author 1", 500);
        Video v2 = new Video("Title 2", "Author 2", 1000);
        Video v3 = new Video("Title 3", "Author 3", 1500);
        Video v4 = new Video("Title 4", "Author 4", 2000);

        Comment c1 = new Comment("User 1", "text sample 1");
        Comment c2 = new Comment("User 2", "text sample 2");
        Comment c3 = new Comment("User 3", "text sample 3");
        Comment c4 = new Comment("User 4", "text sample 4");
        Comment c5 = new Comment("User 5", "text sample 5");
        Comment c6 = new Comment("User 6", "text sample 6");
        Comment c7 = new Comment("User 7", "text sample 7");
        Comment c8 = new Comment("User 8", "text sample 8");
        Comment c9 = new Comment("User 9", "text sample 9");
        Comment c10 = new Comment("User 10", "text sample 10");
        Comment c11 = new Comment("User 11", "text sample 11");
        Comment c12 = new Comment("User 12", "text sample 12");

        v1.AddComment(c1);
        v1.AddComment(c2);
        v1.AddComment(c3);
        v2.AddComment(c4);
        v2.AddComment(c5);
        v2.AddComment(c6);
        v3.AddComment(c7);
        v3.AddComment(c8);
        v3.AddComment(c9);
        v4.AddComment(c10);
        v4.AddComment(c11);
        v4.AddComment(c12);

        List<Video> videos = new List<Video> {v1, v2, v3, v4};

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.NumberOfComments()}");
            Console.WriteLine();

            foreach(Comment comment in video.DisplayComments())
            {
                Console.WriteLine(comment._commenterName + " " + comment._text);
            }
            Console.WriteLine();
        }

    }
}