using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class CheckTaskCommand
    {
        public CheckTaskCommand(string taskId)
        {
            TaskId = taskId;
        }

        public string TaskId { get; }

        public class Handler
        {
            public void Execute(CheckTaskCommand command)
            {

            }
        }
    }
}
