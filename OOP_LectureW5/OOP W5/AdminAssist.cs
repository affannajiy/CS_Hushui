using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_W5
{
    internal class AdminAssist : WorkerAvatar
    {
        public string pmName { get; set; }

        public AdminAssist(string name, string description, int id, string pmName) : base(name, description, id)
        {
            pmName = ProjectManagerName;
        }
    }
}
