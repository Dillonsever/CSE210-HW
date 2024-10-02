using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables (fields)
    public string _name;
    public List<Job> _jobs;

    // Constructor to initialize the resume object
    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>(); // Initialize the list of jobs
    }

    // Method to add a job to the resume
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // Method to display resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails(); // Call the DisplayJobDetails method from Job class
        }
    }
}

