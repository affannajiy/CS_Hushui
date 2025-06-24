using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_W5
{
    internal class ProjectManagerList 
    {
        //Worker List
        public List<ProjectManager> ProjectManagers;

        public ProjectManagerList()
        {
            ProjectManagers = new List<ProjectManager>();
        }

        public void AddProjectManager(ProjectManager ProjectManagers)
        {
            ProjectManagers.Add(ProjectManagers); //Add Project Manager
        }

        public void RemoveWorker(ProjectManager worker)
        {
            ProjectManagers.Remove(ProjectManagers); //Remove Project Manager
        }

        public void Display()
        {
            foreach 
        }
    }
}
