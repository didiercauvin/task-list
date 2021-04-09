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
                int id = int.Parse(command.TaskId);
                var identifiedTask = command.Projects
                    .Select(project => project.Tasks.FirstOrDefault(task => task.Id == id))
                    .Where(task => task != null)
                    .FirstOrDefault();
                if (identifiedTask == null)
                {
                    _console.WriteLine("Could not find a task with an ID of {0}.", id);
                    return;
                }

                identifiedTask.Done = false;
            }
        }
    }
}
