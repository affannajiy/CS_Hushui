using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LectureW11
{
    //Abstract Class
    public abstract class Job
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //Report (Virtual: Polymorphism - smth that can be reimplemented)
        //When you have a method that is not complete, the class is not concrete (complete)
        //Like a building, we have the building, but we don't know what it looks like yet, condominium?
        public abstract void Report(); //abstract
        
        /*
        public virtual void Report() //virtual - to override
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Job: " + Name + " Done!");
            Console.WriteLine("Description: " + Description);
        }
        */
    }
}
