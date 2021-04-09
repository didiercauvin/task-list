using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class UncheckTaskCommand
    {
        public UncheckTaskCommand(Projects projects)
        {
            Projects = projects;
        }

        public Projects Projects { get; }

        public class Handler
        {
            public void Execute(UncheckTaskCommand command)
            {

            }
        }
    }
}
