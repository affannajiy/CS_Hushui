using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LectureW11
{
    public class OneTimeJobs : Job, Payable
    {
        //Inheritance from superclass Job
        //We want to show OneTimeJobs as a kind of Job (subclass)
        //We want to show OneTimeJobs as a kind of Payable
        public DateTime Date { get; set; }

        //ReportOTJob (Special Report for OneTimeJobs)
        public override void Report() //override
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Perform on the Date: " + Date.ToString());
        }

        public float CalcCost()
        {
            return 100.0f;
        }
    }
}
