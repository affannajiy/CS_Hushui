using OOP_LectureW11;
using System.Net.WebSockets;

Job job = new OneTimeJobs() { Name = "WashDish", Description = "Use Soap" };

// Need Speacial types of Jobs
// One Time Job: has a certain fixed start and end date
// Recurring Job: has a certain fixed start date when it was last done and a certain time interval before next execution (Sweep Floor)

RecurringJobs rjob = new RecurringJobs()
{
    Name = "OpenShop",
    Description = "Use Key",
    LastDone = DateTime.Now,
    TimeBeforeNext = TimeSpan.FromHours(10)
};

OneTimeJobs otjob = new OneTimeJobs() 
{ 
    Name = "SweepFloor", 
    Description = "Use Broom", 
    Date = DateTime.Now 
};

JobList jobList = new JobList();

jobList.AddJob(job);
jobList.AddJob(rjob);
jobList.AddJob(otjob);
jobList.ReportAllJobs();

Account account = new Account();
//account.AddPayable(rjob);
//account.AddPayable(otjob);
//Console.WriteLine(account.Total());

FoodProduct fp = new FoodProduct();
account.AddPayable(fp);