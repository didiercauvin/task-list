using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class ShowTasksCommand
    {
        public ShowTasksCommand(IDictionary<string, IList<Task>> tasks)
        {
            Tasks = tasks;
        }

        public IDictionary<string, IList<Task>> Tasks { get; }

        public class ShowTasksCommandHandler
        {
            private readonly IConsole _console;

            public ShowTasksCommandHandler(IConsole console)
            {
                _console = console;
            }

            public void Execute(ShowTasksCommand command)
            {
                foreach (var project in command.Tasks)
                {
                    _console.WriteLine(project.Key);
                    foreach (var task in project.Value)
                    {
                        _console.WriteLine("    [{0}] {1}: {2}", (task.Done ? 'x' : ' '), task.Id, task.Description);
                    }
                    _console.WriteLine();
                }
            }
        }
    }
}
