using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class ShowProjectsCommand
    {
        public ShowProjectsCommand(Projects projects)
        {
            Projects = projects;
        }

        public Projects Projects { get; }

        public class Handler
        {
            private readonly IConsole _console;

            public Handler(IConsole console)
            {
                _console = console;
            }

            public void Execute(ShowProjectsCommand command)
            {
                foreach (var project in command.Projects)
                {
                    _console.WriteLine(project.Name);
                    foreach (var task in project.Tasks)
                    {
                        _console.WriteLine("    [{0}] {1}: {2}", (task.Done ? 'x' : ' '), task.Id, task.Description);
                    }
                    _console.WriteLine();
                }
            }
        }
    }
}
