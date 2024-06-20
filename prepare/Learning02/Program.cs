using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Job instances
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Job instances 2
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Google";
        job2._startYear = 2018;
        job2._endYear = 2024;

        // resume instnce
        Resume myResume = new Resume();
        myResume._name = "Isaac L. Quelemine";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        // Display resume Information
        myResume.Display();
        // job1.Display();
        // job2.Display();
    }
}