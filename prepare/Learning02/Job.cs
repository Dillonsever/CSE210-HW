using System;

public class Job
{

    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Constructor to initialize the job object
    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        _company = company;
        _jobTitle = jobTitle;
        _startYear = startYear;
        _endYear = endYear;
    }

    // Method to display job details
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
