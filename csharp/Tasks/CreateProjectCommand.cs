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

        public class Handler
        {
            public void Execute(CreateProjectCommand command)
            {

            }
        }
    }
}
