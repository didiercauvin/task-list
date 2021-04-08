using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class ShowTasksCommand
    {
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
