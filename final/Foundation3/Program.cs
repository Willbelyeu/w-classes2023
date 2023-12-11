using System;

class Program
{
    static void Main(string[] args)
    {
        string speaker="Matthew Horner";
        int seating=60;
        string discription="A lecture on military infastructure in the federation, and its importance. Matt Horner has served as captain of the Hyperion in the Raynor's Raiders mercenary army since the Mar Sara revolt";
        string date="14/27/1999";
        string time="12:00P.M.";
        string title="Lecture on infastructure";

        string street="527 Mainstreeet";
        string city="Browntown";
        string state="Arazona";
        string country="United States";
        Address address=new Address(street, city, state, country);
        Lecture lecture=new Lecture(speaker, seating, title, discription, date, time, address);
        string shortIntro = lecture.ShortDescription();
        string intro=lecture.StandardDetails();
        string fullIntro = lecture.FullDetails();
        Console.WriteLine("");
        Console.WriteLine(shortIntro);
        Console.WriteLine("");
        Console.WriteLine(intro);
        Console.WriteLine("");
        Console.WriteLine(fullIntro);

        Console.WriteLine("");
        Console.WriteLine("");

        string email="JohnDoe@bogus.com";
        discription="The wedding reception of Mr. and newly Mrs. Doe";
        date="07/04/2002";
        time="9:00A.M.";
        title="Doe reception";
        street="527 Mainstreeet";
        city="Browntown";
        state="Arazona";
        country="United States";
        Address addressReception=new Address(street, city, state, country);
        Reception reception=new Reception(email, title, discription, date, time, addressReception);
        intro=reception.StandardDetails();
        fullIntro=reception.FullDetails();
        shortIntro=reception.ShortDescription();
        Console.WriteLine($"{shortIntro}");
        Console.WriteLine("");
        Console.WriteLine($"{intro}");
        Console.WriteLine("");
        Console.WriteLine($"{fullIntro}");

        Console.WriteLine("");
        Console.WriteLine("");

        string weather="sunny";
        discription="A great chance to get out and meet new people, we will be dancing in the morning in the park";
        date="07/11/2008";
        time="11:00A.M.";
        title="Country dancing in the park";
        street="527 Mainstreeet";
        city="Brovo";
        state="New Mexico";
        country="United States";
        OutDoorGathering gathering=new OutDoorGathering(weather, title, discription, date, time, addressReception);
        intro=gathering.StandardDetails();
        fullIntro=gathering.FullDetails();
        shortIntro=gathering.ShortDescription();
        Console.WriteLine($"{shortIntro}");
        Console.WriteLine("");
        Console.WriteLine($"{intro}");
        Console.WriteLine("");
        Console.WriteLine($"{fullIntro}");
    }
}