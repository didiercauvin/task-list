using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class CheckTaskCommand
    {
        public CheckTaskCommand(Projects projects, string taskId)
        {
            TaskId = taskId;
            Projects = projects;
        }

        public string TaskId { get; }
        public Projects Projects { get; }

        public class Handler
        {
            public void Execute(CheckTaskCommand command)
            {

            }
        }
    }
}
