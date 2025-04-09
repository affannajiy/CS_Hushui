using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_W5
{
    internal class Program
    {
        //Main is the entry point of the program.
        //USe it to do unit/integration testing.
        static void Main(string[] args)
        {
            //Create objects (fName, lName, ID, Position)
            WorkerList workerlist = new WorkerList();
            WorkerAvatar worker = new WorkerAvatar("John", "Hardworking", 1000);
            //Add ProjectManager
            ProjectManagerList projectManagerList = new ProjectManagerList();
            ProjectManager projectManager = new ProjectManager("Jane", "Project Manager", 2000);

            //polymorphism at work
            workerlist.AddWorker(projectManager);
            workerlist.AddWorker(worker);
        }
    }
}
