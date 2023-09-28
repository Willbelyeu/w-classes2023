using System;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Job job1=new Job();
        job1._company="mycrosoft";
        job1._jobTitle="software engineeer";
        job1._startYear=1997;
        job1._endYear=2004;
        
        Job job2=new Job();
        job2._jobTitle="hardware engineeer";
        job2._company="apple";
        job2._startYear=1999;
        job2._endYear=2016;

        Resume myResume=new Resume();
        myResume._name="Robert Sanders";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}