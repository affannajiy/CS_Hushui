using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_W5
{
    internal class WorkerList
    {
        //Worker List
        public List<WorkerAvatar> Workers;

        public WorkerList()
        {
            Workers = new List<WorkerAvatar>();
        }

        public void AddWorker(WorkerAvatar worker)
        {
            Workers.Add(worker); //Add Worker
        }

        public void RemoveWorker(WorkerAvatar worker)
        {
            Workers.Remove(worker); //Remove Worker
        }

        public void Display()
        {
            foreach (WorkerAvatar worker in Workers)
            {
                Console.WriteLine(worker.Name);
                Console.WriteLine(worker.Description);
                Console.WriteLine(worker.ID);
                Console.WriteLine(worker.CurrPosition);
            }
        }
    }
}
