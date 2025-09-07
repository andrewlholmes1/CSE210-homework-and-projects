using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Firefly Studios";
        job1._startYear = "2020";
        job1._endYear = "2023";

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Bethesda Softworks";
        job2._startYear = "2023";
        job2._endYear = "2024";

        Resume myResume = new Resume();
        myResume._name = "Andrew Holmes";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();



    }
}