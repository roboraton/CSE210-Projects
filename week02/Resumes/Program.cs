using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Safety Engineer";
        job1._company = "Kiewit";
        job1._startYear = 2024;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Hexagon";
        job2._startYear = 2025;
        job2._endYear = 2050;


        Resume myResume = new Resume();
        myResume._name = "Hector Gomez";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}