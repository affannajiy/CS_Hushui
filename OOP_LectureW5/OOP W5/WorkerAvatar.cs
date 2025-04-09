using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_W5 //packages
{
    internal class WorkerAvatar //private class (only be used in the class)
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        public float CurrPosition { get; set; }

        public WorkerAvatar(string name, string description, int id)
        {
            Name = name;
            Description = description;
            ID = id;
        }
        
        //Function is VERB!
        //Username
      
        //Position
      
        //Movement
    
        //Avatar or Skin
    }
}
