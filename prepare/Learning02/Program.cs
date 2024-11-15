using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._sinceYear = 2011;
        job1._toYear =2020;
        
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company="Apple";
        job2._sinceYear=2020;
        job2._toYear=2024;

        Resume myResume = new Resume();
        myResume._name =  "Franco Gallardo";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}