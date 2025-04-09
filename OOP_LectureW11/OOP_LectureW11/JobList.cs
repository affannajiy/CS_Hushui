using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LectureW11
{
    // JobList manages a list of Jobs
    // Has the following operations: Add Job, Report on All Jobs
    public class JobList
    {
        // Create list of Jobs
        public List<Job> jobs = new List<Job>();

        // Add Job
        public void AddJob(Job job)
        {
            jobs.Add(job);
        }

        //Report All Jobs (Polymorphism)
        public void ReportAllJobs()
        {
            foreach (Job job in jobs)
            {
                job.Report();
            }
        }
    }
}