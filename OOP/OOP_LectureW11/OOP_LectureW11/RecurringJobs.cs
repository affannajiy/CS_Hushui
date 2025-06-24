using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LectureW11
{
    public class RecurringJobs : Job, Payable
    {
        public DateTime LastDone { get; set; } //Property: a cover for smth that's private
        public TimeSpan TimeBeforeNext { get; set; }
        //TimeSpan: struct, that represents a time interval

        //ReportRecurringJob (Special Report for RecurringJobs)
        public override void Report() //override
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Last Done: " + LastDone.ToString());
            Console.WriteLine("Time Before Next: " + TimeBeforeNext.ToString());
        }

        public float CalcCost()
        {
            return 10.0f;
        }
    }
}
