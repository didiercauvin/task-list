using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class UncheckTaskCommand
    {
        public UncheckTaskCommand(Projects projects, string taskId)
        {
            Projects = projects;
            TaskId = taskId;
        }

        public Projects Projects { get; }
        public string TaskId { get; }

        public class Handler
        {
            private readonly IConsole _console;

            public Handler(IConsole console)
            {
                _console = console;
            }

            public void Execute(UncheckTaskCommand command)
            {

            }
        }
    }
}
