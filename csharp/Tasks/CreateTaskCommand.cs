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

        public CreateTaskCommand(Projects projects, string taskDescription)
        {
            Projects = projects;
            TaskDescription = taskDescription;
        }

        public class Handler
        {
            public void Execute(CreateTaskCommand command)
            {

            }
        }
    }
}
