using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");
        Video video1 = new Video();
        video1._author = "Sally Smith";
        video1._title = "The World Around Us";
        video1._lengthInSeconds = 10800;

        Video video2 = new Video();
        video2._author = "Mali Barishna";
        video2._title = "How to Cut Squares";
        video2._lengthInSeconds = 7228;

        Video video3 = new Video();
        video3._author = "Bubba Gump";
        video3._title = "I Like Shrimp";
        video3._lengthInSeconds = 13923;

        Video video4 = new Video();
        video4._author = "Lucy Smith";
        video4._title = "Kicking the Football";
        video4._lengthInSeconds = 8543;

        Comments worldComments = new Comments();
        worldComments.videos.Add(video1);
        video1.AddComment("Excellent", "Julio Iglesia");
        video1.AddComment("I disagree about the penguins", "Fred Jones");
        video1.AddComment("The earth is flat!!", "Knows-All Bob");
        worldComments.Display();
        video1.GetNumberOfComments();
        video1.DisplayComment();
        Console.WriteLine();

        Comments squareComments = new Comments();
        squareComments.videos.Add(video2);
        video2.AddComment("Squares Rule!", "PinkGirl245");
        video2.AddComment("I don't see why they need four sides. Circles work just fine", "Confused in Toledo");
        video2.AddComment("I thought this was a cooking show.", "Marge");
        squareComments.Display();
        video2.GetNumberOfComments();
        video2.DisplayComment();
        Console.WriteLine();

        Comments shrimpComments = new Comments();
        shrimpComments.videos.Add(video3);
        video3.AddComment("Run, Forest, Run!", "Mary");
        video3.AddComment("Are you calling me short?", "Big Al");
        video3.AddComment("Yum!", "Chef Daree");
        video3.AddComment("Clams are good too", "John Smith");
        shrimpComments.Display();
        video3.GetNumberOfComments();
        video3.DisplayComment();
        Console.WriteLine();

        Comments footballComments = new Comments();
        footballComments.videos.Add(video4);
        video4.AddComment("Not again!", "Charlie");
        video4.AddComment("You should be a psychatrist", "Maris Toolen");
        video4.AddComment("Very informative", "Joe");
        video4.AddComment("I liked the surprise ending", "M. Sham");
        footballComments.Display();
        video4.GetNumberOfComments();
        video4.DisplayComment();
    }
}