using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class CreateProjectCommand
    {
        public Projects Projects { get; }
        public string Name { get; }

        public CreateProjectCommand(Projects projects, string name)
        {
            Projects = projects;
            Name = name;
        }

        public class Handler
        {
            public void Execute(CreateProjectCommand command)
            {

            }
        }
    }
}
