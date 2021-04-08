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

            public void Handler(ShowTasksCommand command)
            {

            }
        }
    }
}
