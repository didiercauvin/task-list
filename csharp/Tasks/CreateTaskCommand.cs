using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class CreateTaskCommand
    {
        public Projects Projects { get; }
        public string TaskDescription { get; }
        public string ProjectName { get; }

        public CreateTaskCommand(Projects projects, string taskDescription, string projectName)
        {
            Projects = projects;
            TaskDescription = taskDescription;
            ProjectName = projectName;
        }

        public class Handler
        {
            public void Execute(CreateTaskCommand command)
            {

            }
        }
    }
}
