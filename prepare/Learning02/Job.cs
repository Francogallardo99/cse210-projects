using System;

public class Job
        {
            public string _jobTitle;
            public string _company;
            public int _sinceYear;
            public int _toYear;
            public void Display()
            {
                Console.WriteLine($"{_jobTitle} ({_company}) {_sinceYear}-{_toYear}");
            }
        }