using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_W5
{
    internal class ProjectManager : WorkerAvatar
    {
        public string ProjectName { get; set; }
        public string DepartmentName { get; set; }
        public string ProgramName { get; set; }

        public ProjectManager()
        {

        }

        public ProjectManager(string name, string description, int id, string projectName, string departmentName, string programName) : base(name, description, id)
        {
            ProjectName = projectName;
            DepartmentName = departmentName;
            ProgramName = programName;
        }
    }
}
