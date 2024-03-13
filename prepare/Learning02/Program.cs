using System;

class Program
{
    static void Main(string[] args)
    {
        Resume cv = new Resume("Jean Andrade");
        Job job1 = new Job("Software Engineer", "Microsoft", 2019, 2022);
        Job job2 = new Job("Manager", "Apple", 2022, 2023);
        // Adds the jobs to the resume.
        cv._jobs.Add(job1);
        cv._jobs.Add(job2);
        cv.display();
    }
}