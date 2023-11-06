using System;
using System.Collections.ObjectModel;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {

        Rectangle runthroughr=new Rectangle("Red", 4, 3);
        double arear=runthroughr.GetArea();
        Console.WriteLine($"{arear}");

        Circle runthroughc=new Circle("Red", 4);
        double areac=runthroughc.GetArea();
        Console.WriteLine($"{areac}");

        Square runthroughs=new Square("green", 4);
        double areas=runthroughs.GetArea();
        Console.WriteLine($"{areas}");
    }
}