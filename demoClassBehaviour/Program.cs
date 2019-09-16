using System;
using System.Collections.Generic;

namespace demoClassBehaviour
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Job> jobs = Job.CreateJobList();

            PrintCompactJobList(jobs);
            

        }

        static void PrintJobList(List<Job> jobList)
        {
            foreach (Job job in jobList)
            {
                Console.WriteLine(job.ToMultilineString());
            }
        }

        static void PrintCompactJobList(List<Job> jobList)
        {
            foreach (Job job in jobList)
            {
                Console.WriteLine(job.ToString());
            }
        }
    }
}
