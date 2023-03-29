using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");
        Address lectureAddress = new Address("14 Phalanges Dr.", "Bristol", "Vermont");
        LectureEvent lecture = new LectureEvent("How to Tell Your Left Hand from Your Right", "Indoor Lecture Series by Professor Manos on the benefits of body organization.", "12/12/2023", "10:00am", lectureAddress, "R.L.Manos", 200);
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.GetFullLectureDetails());
        Console.WriteLine();
        Console.WriteLine("Short Details:");
        Console.WriteLine(lecture.GetShortDetails());
        Console.WriteLine();

        Address receptionAdress = new Address("35 Grace St.", "Tupelo", "MS");
        ReceptionEvent reception = new ReceptionEvent("Wedding Reception of Vernon & Gladys", "Join in celebrating the marital union of Vernon and Gladys!", "6/12/2024", "3:00pm", receptionAdress, "VandG@yahoo.com");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(reception.GetFullReceptionDetails());
        Console.WriteLine();
        Console.WriteLine("Short Details:");
        Console.WriteLine(reception.GetShortDetails());
        Console.WriteLine();

        Address outdoorAddress = new Address("Cortaro Park at Silverbell and Cortaro", "Phoenix", "AZ");
        OutdoorEvent outdoor = new OutdoorEvent("Mariza Fernandez Quinceanera", "Come Celebrate Mariza's 15th Birthday!", "March 28,2023", "5:00pm", outdoorAddress, "Sunny, high 70's");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(outdoor.GetFullOutdoorDetails());
        Console.WriteLine();
        Console.WriteLine("Short Details:");
        Console.WriteLine(outdoor.GetShortDetails());
    }
}