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
            private readonly Func<long> _nextId;

            public Handler(Func<long> nextId)
            {
                _nextId = nextId;
            }

            public void Execute(CreateTaskCommand command)
            {
                var project = command.Projects.FirstOrDefault(x => x.Name == command.ProjectName);
                if (project == null)
                {
                    Console.WriteLine("Could not find a project with the name \"{0}\".", command.ProjectName);
                    return;
                }
                project.Add(new Task { Id = _nextId(), Description = command.TaskDescription, Done = false });
            }
        }
    }
}
